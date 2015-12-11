using System;
using System .Collections .Generic;
using System .Linq;
using System .Text;
using System .IO;

namespace FileTestEditor .Data {
    class TextFileAdapter {
        private string _path { get; set; }
        private Encoding _encoding { get; set; }

        public TextFileAdapter(string fullFileName, Encoding encoding) {
            this ._path = fullFileName;
            this._encoding = encoding;

        }

        public string select(int rowNumber) {
            string[] lines = File .ReadAllLines(_path , _encoding);
            return lines[rowNumber];
        }

        public void insert(int rowNumber , string value) {
            string[] lines = File .ReadAllLines(_path , _encoding);
            int index = rowNumber;
            if (rowNumber > lines .Length-1) {
                int lastIndex = lines.Length -1;
                if(lastIndex < 0){
                    lastIndex = 0;
                }
                int delta = rowNumber - lastIndex;
                for (int i = 1; i <= delta; i++) {
                    if (i != delta) {
                        File .AppendAllText(_path , string .Empty , _encoding);
                        continue;
                    }
                    File .AppendAllText(_path , value , _encoding);
                }
            }
            if (rowNumber <= lines .Length - 1) {
                this .update(rowNumber , value);
                return;
            }
        }

        public void delete(int rowNumber) {
            string[] lines = File .ReadAllLines(_path , _encoding);
            string[] newLines = new string[lines .Length - 1];
            for (int i = 0; i < lines .Length; i++) {
                if (i == rowNumber) {
                    continue;
                }
                newLines[i] = lines[i];
            }
            File .WriteAllLines(_path , lines , _encoding);
        }

        public void update(int rowNumber , string value) {
            string[] lines = File .ReadAllLines(_path , _encoding);
            lines[rowNumber] = value;
            File .WriteAllLines(_path , lines , _encoding);
            for (int i = 0; i < lines .Length; i++) { 
            }
        }
    }
}
