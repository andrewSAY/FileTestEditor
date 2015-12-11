using System;
using System .Collections .Generic;
using System .Linq;
using System .Text;

namespace FileTestEditor .Data {
    class ApplicationManager {       
        public Scanning.MyWIA.ScanSettings scanSettings { get; set; }
        public Data .AppSettings appSettings { get; set; }
        public Scanning .MyWIA wiaS { get; set; }
        public Data .Items.ItemColorMode[] listColorModes { get; set; }
        public List<Data .Items .ItemEduObject> listEduObjects { get; set; }
        public string fileSettingScan = System .Windows .Forms .Application .StartupPath + "/scan.settings";
        public string fileSettingApp = System .Windows .Forms .Application .StartupPath + "/app.settings";
        public DataBase .Worker dbWorker { get; set; }

        private Data .VariantAdapter _innerVariant { get; set; }
        public Data .VariantAdapter variant {
            get {
                return this ._innerVariant;
            }
            set {
                this ._innerVariant = value;
                if (changeVariantEvent != null) {
                    changeVariantEvent();
                }
            }
        }

        public delegate void changeVariantVoid();
        public event changeVariantVoid changeVariantEvent;        

        public ApplicationManager() {
            listEduObjects = new List<Items .ItemEduObject>();
            this .dbWorker = new DataBase .Worker();
            this .listColorModes = new Items .ItemColorMode[3];
            this .scanSettings = new Scanning .MyWIA .ScanSettings();
            this .wiaS = new Scanning .MyWIA();           
        }

        public void loadApplication() {            
            this .scanSettings .loadFromHardwareStorage(this .fileSettingScan);
            this .appSettings = new AppSettings();
            this .appSettings .loadFromHardwareStorage(this .fileSettingApp);            
            this .wiaS .setDevice(this .scanSettings .deviceId);
            
            
            
            this .listColorModes[0] = new Items .ItemColorMode("черно-белый" , Scanning .MyWIA .ColorMode .blackAndWhite);
            this .listColorModes[1] = new Items .ItemColorMode("оттенки серого" , Scanning .MyWIA .ColorMode .greyscale);
            this .listColorModes[2] = new Items .ItemColorMode("цветной" , Scanning .MyWIA .ColorMode .color);
            
            listEduObjects.Add(new Items.ItemEduObject("Английский язык",8));
            listEduObjects .Add(new Items .ItemEduObject("Биология" , 5));
            listEduObjects .Add(new Items .ItemEduObject("География" , 7));
            listEduObjects .Add(new Items .ItemEduObject("Информатика" , 15));
            listEduObjects .Add(new Items .ItemEduObject("Испанский язык" , 13));
            listEduObjects .Add(new Items .ItemEduObject("История" , 6));
            listEduObjects .Add(new Items .ItemEduObject("Литература" , 12));
            listEduObjects .Add(new Items .ItemEduObject("Немецкий язык" , 9));            
            listEduObjects .Add(new Items .ItemEduObject("Математика" , 2));
            listEduObjects .Add(new Items .ItemEduObject("Обществознание" , 11));
            listEduObjects .Add(new Items .ItemEduObject("Русский язык" , 1));
            listEduObjects .Add(new Items .ItemEduObject("Физика" , 3));
            listEduObjects .Add(new Items .ItemEduObject("Французский язык" , 10));
            listEduObjects .Add(new Items .ItemEduObject("Химия" , 4));
            listEduObjects .Add(new Items .ItemEduObject("Экология" , 14));
            
            this .variant = null;            
        }

        public void createVarirant(Data .Items .ItemEduObject eduObj , int variantNumber) {            
            this .variant = new VariantAdapter(eduObj , variantNumber);            
            variant .saveToHardwareStorage(this .appSettings .pathToProjectFolder + "/" + this .variant .fileName);            
        }

        public void loadVariant(string fileName) {
            Data.VariantAdapter opened = new VariantAdapter();
            opened.loadFromHardwareStorage(fileName);
            this .variant = opened;
        }

        public void closeVariant() {           
            this .variant = null;
        }

        public void saveVariant() {
            this .variant .saveToHardwareStorage(this .appSettings .pathToProjectFolder + "/" + this .variant .fileName);            
        }

        public void importVariantFromDataSource(int eduObjectNumber , int variantNumber) {            
            if (!dbWorker .hasConnect) {
                return;
            }
            var variantFromDS = dbWorker .getQuests(eduObjectNumber , variantNumber);
            Data.Items.ItemEduObject eduObject  = (from x in listEduObjects where x.number == eduObjectNumber select x).First();
            
            this .variant = null;
            Data .VariantAdapter opened = new VariantAdapter(eduObject , variantNumber);
            foreach(object[] item in variantFromDS){
                Items.TypesQuest newQstType = Items.TypesQuest.A;
                switch((string)item[1]){
                    case "A":  newQstType = Items.TypesQuest.A; break;
                    case "B":  newQstType = Items.TypesQuest.B; break;
                    case "C":  newQstType = Items.TypesQuest.C; break;
                    case "T": newQstType = Items .TypesQuest .T; break;
                    case "Text":  newQstType = Items.TypesQuest.T; break;
                    case "Текст":  newQstType = Items.TypesQuest.T; break;
                }
                Items.ItemVariant newQst = new Items.ItemVariant(newQstType, (int)item[2]);
                System.IO.MemoryStream ms = new System.IO.MemoryStream((byte[])item[0]);
                System.Drawing.Image bufferImg = System.Drawing.Image.FromStream(ms, true, true);
                newQst .imageQst = new System .Drawing .Bitmap(bufferImg);
                bufferImg .Dispose();
                newQst.key = (string)item[3];
                opened.addQuest(newQst);
                ms.Close();
            }
            opened .setNotChanges();
            variant = opened;
        }

        public bool exportVariantToDataSource(bool replaceExistes) {
            List<object[]> qstList = new List<object[]>();

            foreach (Items .ItemVariant qst in variant .getDataSource()) {
                System .IO .MemoryStream ms = new System .IO .MemoryStream();
                qst .imageQst .Save(ms , qst .imageQst .RawFormat);
                object[] row = { ms .ToArray() , qst .type .ToString() , qst .number , qst .key };
                ms .Close();
                qstList .Add(row);
            }            
            return dbWorker .addVariant(variant .eduObject .number , variant .number , qstList , replaceExistes);
        }

        public bool createConnectionWithDataSource(string dataSource , string dbName , string user , string password) { 
            return dbWorker.connect(dataSource , dbName , user , password);
        }
      

    }
}
