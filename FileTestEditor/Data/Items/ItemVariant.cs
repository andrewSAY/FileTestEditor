using System;
using System .Collections .Generic;
using System .Linq;
using System .Text;
using System .Drawing;

namespace FileTestEditor .Data. Items {
    [Serializable()]
    public class ItemVariant {
        public Image imageQst { get; set; }
        private TypesQuest _type { get; set; }
        private int _number { get; set; }
        public TypesQuest type { 
            get {
                return _type;
            } 
            set {
                _type = value;
                caption = value .ToString() + _number .ToString();
            } 
        }
        public int number { 
            get {
                return _number;
            } 
            set {
                _number = value;
                caption = _type .ToString() + value .ToString();
            } 
        }
        public string key { get; set; }
        public string caption {get; private set;}
        public ItemVariant(TypesQuest type, int number) {
            this .type = type;
            this .number = number;            
        }
    }

    
    public  enum TypesQuest{
        [StringValue("A")]
        A = 0,
        [StringValue("B")]
        B = 1,
        [StringValue("C")]
        C = 2,
        [StringValue("Текст")]
        T = 3
    }

    class StringValue:Attribute {
        private string _value;

        public StringValue(string value) {
            _value = value;
        }

        public string Value {
            get { return _value; }
        }
    }



}
