using System;
using System .Collections .Generic;
using System .ComponentModel;
using System .Data;
using System .Drawing;
using System .Linq;
using System .Text;
using System .Windows .Forms;

namespace FileTestEditor {
    public partial class FormPrintVariants : Form {

        private Data .Print _printWorker { get; set; }
        private List<object[]> _printList { get; set; }

        public FormPrintVariants(List<object[]> printList) {
            InitializeComponent();
            _printList = printList;
        }

        private void FormPrintVariants_Load(object sender , EventArgs e) {
            _printWorker = new Data .Print(2100 , 2970);
            foreach (string item in _printWorker .getPrintDeviceList()) {
                printerList .Items .Add(item);
            }
            Unblocked();
        }

        private void Unblocked() {
            if (printerList .SelectedIndex <= 0 || qstTypeList.CheckedItems.Count == 0) {
                buttonPrint .Enabled = false;
                return;
            }
            buttonPrint .Enabled = true;
        }

        private void printerList_SelectedIndexChanged(object sender , EventArgs e) {
            Unblocked();
        }

        private void qstTypeList_SelectedIndexChanged(object sender , EventArgs e) {
            Unblocked();
        }

        private void buttonPrint_Click(object sender , EventArgs e) {
            string selectedTypes = string.Empty;
                foreach(string item in qstTypeList.CheckedItems){
                    selectedTypes +=item;
                }
                List<object[]> bufferList = new List<object[]>();               
                foreach (object[] row in _printList) {
                    var ranges = Program .AppManager .dbWorker .getQuests((int)row[0] , (int)row[1]);
                    List<object[]> newRange = new List<object[]>();

                    foreach (object[] rowR in ranges) {

                        object[] newRow = new object[rowR .Count() + 2];
                        int i = 0;
                        foreach (object item in rowR) {
                            newRow[i] = item;
                            i++;
                        }
                        newRow[newRow .Count() - 1] = row[1].ToString();
                        newRow[newRow .Count() - 2] = row[2];
                        newRange .Add(newRow);
                    }
                    bufferList .AddRange(newRange .AsEnumerable());
                }
                bufferList = (from x in bufferList where selectedTypes .IndexOf(x[1] .ToString()) != -1 select x) .ToList<object[]>();                    
                if (bufferList .Count == 0) {
                    Helper .MessageManager .showInfoMessage("Не найдено оъектов для печати. Возможно в выбранных заданиях нет заданий выбранных типов "+selectedTypes);
                    return;
                }
                
            _printWorker .printBatch(bufferList, printerList.SelectedItem.ToString());
            this .Close();
        }
    }
}
