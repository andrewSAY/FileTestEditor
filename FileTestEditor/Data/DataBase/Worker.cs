using System;
using System .Collections .Generic;
using System .Linq;
using System .Text;
using FileTestEditor .Data .DataBase .Entity;

namespace FileTestEditor .Data .DataBase {
    
    class Worker {
        private Entities _db { get; set; }
        private string _connectionStringTempalte = "metadata=res://*/Data.DataBase.Entity.DataBaseVariantsModel.csdl|res://*/Data.DataBase.Entity.DataBaseVariantsModel.ssdl|res://*/Data.DataBase.Entity.DataBaseVariantsModel.msl;provider=System.Data.SqlClient;provider connection string=\"Data Source={0};Initial Catalog={1};User ID={2};Password={3}\"";
        private bool _hasConnect { get; set; }
        public bool hasConnect { get {
            return _hasConnect;
            } private set {
                _hasConnect = value;
                if (connectCnanged != null) {
                    connectCnanged();
                }
            } }
        public delegate void hasConnectChanged();
        public event hasConnectChanged connectCnanged;

        public Worker() {
            hasConnect = false;
        }

        public bool connect(string dataSource , string dbName , string user , string password) {
            string connString = string .Format(_connectionStringTempalte , dataSource , dbName , user , password);
            try {
                _db = new Entities(connString);
                _db .Connection .Open();
                if (_db .Connection .State != System .Data .ConnectionState .Open) {
                    hasConnect = false;
                    return false;
                }
                closeConnect();
                hasConnect = true;
                _db.Connection.StateChange +=new System.Data.StateChangeEventHandler(onConnectionStateChange);
                return true;
            }
            catch(Exception e) {
                closeConnect();
                hasConnect = false;
                return false;
            }
        }

        /// <summary>
        /// object[0] - изображение, тип byte[];
        /// object[1] - тип задания (A,B,C,Text), тип string;
        /// object[2] - номер задания внутри типа задания, тип int;
        /// object[3] - ключ к заданию, тип string
        /// </summary>
        /// <param name="eduObjectCode"></param>
        /// <param name="variantNumber"></param>
        /// <returns>        
        /// </returns>
        public List<object[]> getQuests(int eduObjectCode , int variantNumber) {
            openConnect();
            var returnValue = new List<object[]>();           
            var list = (from x in _db .Quests where x .edu_object.Value == eduObjectCode && x .variant.Value == variantNumber orderby x.type, x.number_order select x) .ToList();                        
            closeConnect();
             foreach(Quest item in list){
               object[] row = {item.qst, item.type, item.number_order, item.right_answer};
               returnValue.Add(row);
            }
            return returnValue;
        }
        /// <summary>
        /// Возвращает список предметов, где 
        /// object[0] - код предмета, 
        /// object[1] - название предмета
        /// </summary>
        /// <returns></returns>
        public List<object[]> getEduObjects() {
            openConnect();
            var returnValue = new List<object[]>();
            var list = (from x in _db .predmet orderby x.Name_pr select x) .ToList();
            closeConnect();
            foreach(predmet item in list){
               object[] row = {item.Kod_pr, item.Name_pr};
               returnValue.Add(row);
            }
            return returnValue;
        }

        /// <summary>
        /// Возвращает список номеров вариантов по данному предмету
        /// </summary>
        /// <param name="eduObjectCode"></param>
        /// <returns></returns>
        public List<int> getVariant(int eduObjectCode) {
            openConnect();
            var returnValue = new List<int>();
            var list = (from x in _db .Variant_lock where x .edu_object == eduObjectCode select x) .ToList();
            closeConnect();
            foreach(Variant_lock item in list){
               returnValue.Add(item.Variant.Value);
            }
            return returnValue;
        }
        /// <summary>
        /// Возвращает список номеров вариантов по данному предмету
        /// </summary>
        /// <param name="eduObjectCode"></param>
        /// <param name="variantNumber"></param>
        /// <returns></returns>
        public List<int> getVariant(int eduObjectCode, int variantNumber) {
            openConnect();
            var returnValue = new List<int>();
            var list = (from x in _db .Variant_lock where x .edu_object == eduObjectCode && x.Variant == variantNumber select x) .ToList();
            closeConnect();
            foreach (Variant_lock item in list) {
                returnValue .Add(item .Variant .Value);
            }
            return returnValue;
        }

        public List<object[]> getVariantInfo(int eduObjectCode) {
            openConnect();
            var returnValue = new List<object[]>();
            var list = (from x in _db .Variant_lock
                       where x .edu_object == eduObjectCode                       
                       join y in _db .predmet
                       on x .edu_object equals y .Kod_pr
                       select new {
                           eduObject = x .edu_object ,
                           eduObjectName = y .Name_pr ,
                           variantNumber = x .Variant
                       }).OrderBy(x=> x.variantNumber);
            closeConnect();
            foreach (var item in list) {
                
                object[] row = { item .eduObject, item.eduObjectName, item.variantNumber };
                returnValue .Add(row);
            }
            return returnValue;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="eduObjectCode"></param>
        /// <param name="variantNumber"></param>
        /// <param name="questList">
        /// object[0] - изображение, тип byte[];
        /// object[1] - тип задания (A,B,C,Text), тип string;
        /// object[2] - номер задания внутри типа задания, тип int;
        /// object[3] - ключ к заданию, тип string
        /// </param>
        /// <param name="replaceExistes">Определяет поведение, если такой вариант уже существует в источнике данных.
        /// True - заменить найденный вариант, false - не заменять найденный вариант и вернуть false</param>
        /// <returns></returns>
        public bool addVariant(int eduObjectCode , int variantNumber, List<object[]> questList, bool replaceExistes = false) {           
            var qstList = getQuests(eduObjectCode , variantNumber);
            if (qstList .Count != 0) {
                if (!replaceExistes) {                    
                    return false;
                }
                else {
                    if (!deleteVariant(eduObjectCode , variantNumber)) {                        
                        return false;
                    }
                }
            }
            openConnect();
            var varList = getVariant(eduObjectCode , variantNumber);
            if (varList .Count == 0) {
                Variant_lock var = new Variant_lock();
                var .@lock = false;
                var .Variant = variantNumber;
                var .edu_object = eduObjectCode;

                _db .AddToVariant_lock(var);

                /*if (_db .SaveChanges(false) != 1) {
                    closeConnect();
                    return false;
                }*/
            }

            foreach (object[] item in questList) {
                Quest newQuest = new Quest();
                newQuest .qst = (byte[])item[0];
                newQuest .type = (string)item[1];
                newQuest .number_order = (int)item[2];
                newQuest .right_answer = (string)item[3];
                newQuest .edu_object = eduObjectCode;
                newQuest .variant = variantNumber;
                newQuest .name_qst = newQuest .type + newQuest .number_order .ToString();

                _db .AddToQuests(newQuest);
            }           

            int addedCount = _db.SaveChanges(false);
            if (addedCount != questList .Count + 1) {
                closeConnect();
                return false;
            }

            _db . AcceptAllChanges();
            closeConnect();

            return true;
        }

        public bool deleteVariant(int eduObjectCode , int variantNumber) { 
            openConnect();
            var deletedListQ = (from x in _db .Quests where x .edu_object == eduObjectCode && x .variant == variantNumber select x);
            var deletedListV = (from x in _db .Variant_lock where x .edu_object == eduObjectCode && x .Variant == variantNumber select x);
            foreach (Quest q in deletedListQ) {
                _db .DeleteObject(q);
            }
            foreach (Variant_lock v in deletedListV) {
                _db .DeleteObject(v);
            }
            int deletedCount = 0;
            bool returnValue = false;
            try {
                int watingDeletedCount = deletedListQ .Count() + deletedListV .Count();
                deletedCount = _db .SaveChanges(false);
                
                if (deletedCount == watingDeletedCount) {
                    _db .AcceptAllChanges();
                    returnValue = true;
                }
                else {
                    returnValue = false;
                }
            }
            catch(Exception e) {
                return returnValue;
            }
            finally {
                closeConnect();                
            }
            return returnValue;
        }

        public bool hasVariant(int eduObjectCode, int variantNumber) {
            var qstList = getQuests(eduObjectCode , variantNumber);
            if (qstList .Count == 0) {
                return false;
            }
            return true;
        }

        public void Close() {
            hasConnect = false;
        }

        private void closeConnect() {
            if (_db == null) {
                return;
            }
            if (_db .Connection .State != System .Data .ConnectionState .Closed) {
                _db .Connection .Close();
            }
        }

        private void openConnect() {
            if (_db == null) {
                return;
            }
            if (_db .Connection .State != System .Data .ConnectionState .Open) {
                _db .Connection .Open();
            }
        }

        private void onConnectionStateChange(object sender , System .Data .StateChangeEventArgs e) {
            //throw new NotImplementedException();
            if (e .CurrentState == System .Data .ConnectionState .Open &&
                    e.OriginalState == System.Data.ConnectionState.Closed) {
                /*_db .Refresh(System .Data .Objects .RefreshMode .StoreWins , _db.Quests);
                _db .Refresh(System .Data .Objects .RefreshMode .StoreWins , _db .Variant_lock);*/
            }
        }
        
    }
}
