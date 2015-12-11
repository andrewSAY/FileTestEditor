using System;
using System .Collections .Generic;
using System .Linq;
using System .Text;
using System.Drawing;

namespace FileTestEditor .Data. Items {
    [Serializable()]
    class ItemImageList {
        public Image img { get; set; }
        public string caption { get; set; }

        public ItemImageList(Image img, string caption) {
            this .img = img;
            this .caption = caption;
        }
    }
}
