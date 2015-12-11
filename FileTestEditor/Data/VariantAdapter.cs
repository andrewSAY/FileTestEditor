using System;
using System .Collections .Generic;
using System .Linq;
using System .Text;

namespace FileTestEditor .Data {
    [Serializable()]
    class VariantAdapter:Model.BinaryStorageAbstract {
        public Items .ItemEduObject eduObject { get; private set; }
        public int number { get; private set; }
        public string fileName { get; private set; }
        private List<Items .ItemVariant> _dataSource { get; set; }
        private List<Items .ItemImageList> _temporaryList { get; set; }        

        public VariantAdapter() {
            _dataSource = new List<Items .ItemVariant>();
            _temporaryList = new List<Items .ItemImageList>();
            hasChanged = false;
        }

        public VariantAdapter(Items.ItemEduObject eduObject, int number) {
            this .eduObject = eduObject;
            this .number = number;
            this .fileName = eduObject .caption + "_" +number .ToString() + ".variant";
            _dataSource = new List<Items .ItemVariant>();
            _temporaryList = new List<Items .ItemImageList>();
            hasChanged = false;
        }
        
        public void addQuest(Items .ItemVariant qst) {             
            _dataSource .Add(qst);
            this .hasChanged = true;
        }

        public void removeQuest(Items .ItemVariant variant) {            
            _dataSource .Remove(variant);
            this .hasChanged = true;
        }

        public void updateQuest(Items .ItemVariant qst, Items.ItemVariant newQst) {
            Items .ItemVariant selectedVariant = _dataSource .Where(x=>x == qst) .First();
            selectedVariant .type = newQst .type;
            selectedVariant .number = newQst .number;           
            selectedVariant .imageQst = newQst .imageQst;
            selectedVariant.key = newQst.key;
            this .hasChanged = true;
        }

        public Items.ItemVariant getQuest(Items .ItemVariant qst) {
            Items .ItemVariant selected = null;
            var selectedList = _dataSource .Where(x => x == qst);
            if (selectedList .Count() != 0) {
                selected = selectedList .First();
            }
            return selected;
        }

        public bool isUniqQstName(Items .ItemVariant qst) {
            var selectedList = _dataSource .Where(x => x.caption == qst.caption);
            if (selectedList .Count() == 0) {
                return true;
            }
            if (selectedList .Count() > 1) {
                return false;
            }
            return false;
        }        

        public void setDataSource(List<Items .ItemVariant> dataSource) {
            this ._dataSource = dataSource;
            this .hasChanged = true;
        }

        public List<Items .ItemVariant> getDataSource() {
            this .sortDataSource();
            return this ._dataSource;
        }
        
        public List<Items .ItemImageList> getImageList() {
            return _temporaryList;
        }

        public void setImageList(List<Items .ItemImageList> newImageList) {
            _temporaryList = newImageList;
            this .hasChanged = true;
        }

        public void addImageList(System .Drawing .Image img , string caption) { 
            Items.ItemImageList item =new Items.ItemImageList(img, caption);
            _temporaryList .Add(item);
            this .hasChanged = true;
        }
        public void addImageList(System .Drawing .Image img) {
            string caption = "1";
            if (_temporaryList .Count > 0) {
                caption = (Convert .ToInt32(_temporaryList .Last() .caption) + 1) .ToString();
            }
            Items .ItemImageList item = new Items .ItemImageList(img , caption);
            _temporaryList .Add(item);
            this .hasChanged = true;
        }

        public void removeImageList(Items .ItemImageList item) {
            _temporaryList .Remove(item);
            this .hasChanged = true;
        }

        public void sortDataSource() {
            _dataSource = _dataSource .OrderBy(x => x.type).ThenBy(x => x.number).ToList<Items.ItemVariant>();            
        }

        public void setNotChanges() {
            hasChanged = false;
        }
    }
}
