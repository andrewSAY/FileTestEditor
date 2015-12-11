using System;
using System .Collections .Generic;
using System .Linq;
using System .Text;

namespace FileTestEditor . Data. Items {
    [Serializable()]
    class ItemEduObject {
        public string caption { get; set; }
        public int number { get; set; }        

        public ItemEduObject(string  caption, int number) {
            this .caption = caption;
            this .number = number;
        }
    }
}
