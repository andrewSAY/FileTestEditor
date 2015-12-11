using System;
using System .Collections .Generic;
using System .Linq;
using System .Text;

namespace FileTestEditor .Model {
    [Serializable()]
    abstract class ItemsAdapter:BinaryStorageAbstract {
        private List<object> _dataSource { get; set; }


        public void addVariant(object item) {
            _dataSource .Add(item);
        }

        public void removeVariant(object item) {
            _dataSource .Remove(item);
        }

        public void updateVariant(object item , object newItem) {
            var selected = _dataSource .Select(x => x) .First();
            selected = newItem;
        }

        public object getVariant(object item) {
            return _dataSource .Select(x => x == item) .First();
        }

        public void setDataSource(List<object> dataSource) {
            this ._dataSource = dataSource;
        }

        public List<object> getDataSource() {
            return this ._dataSource;
        }
    }
}
