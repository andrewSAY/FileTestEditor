using System;
using System .Collections .Generic;
using System .Linq;
using System .Text;

namespace FileTestEditor .Data.Items {
    class ItemColorMode {
        public string caption { get; set; }
        public Scanning .MyWIA .ColorMode mode { get; set; }
        public ItemColorMode(string caption , Scanning .MyWIA .ColorMode mode) {
            this .caption = caption;
            this .mode = mode;
        }
    }
}
