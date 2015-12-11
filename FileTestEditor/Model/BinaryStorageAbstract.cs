using System;
using System .Collections .Generic;
using System .Linq;
using System .Text;
using System .Runtime .Serialization .Formatters .Binary;
using System .IO;

namespace FileTestEditor .Model {
    [Serializable()]
    public abstract class BinaryStorageAbstract {
        public bool hasChanged { get; protected set; }
        public void saveToHardwareStorage(string pathToStorage) {          
            BinaryFormatter formatter = new BinaryFormatter();            
            Stream str = File .Open(pathToStorage , FileMode .Create);
            try {
                this .hasChanged = false;
                formatter .Serialize(str , this);                
            }
            catch (Exception e) {
                string a = e .Message;
                this .hasChanged = true;
            }
            finally {               
                str .Close();
            }            
        }
        
        public void  loadFromHardwareStorage(string pathToStorage)
        {                    
            BinaryFormatter formatter = new BinaryFormatter();
            if(!File.Exists(pathToStorage)){
                return;
            }
            Stream str = File .OpenRead(pathToStorage);
            try {                
                var deserObject = formatter .Deserialize(str);
                Type T = deserObject.GetType();
                System .Reflection .FieldInfo[] fields = T .GetFields(System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance);
                foreach (System .Reflection .FieldInfo field in fields) {
                    if (field .GetValue(deserObject) != null) {
                        field .SetValue(this , field .GetValue(deserObject));
                    }
                }                    
            }
            catch (Exception e) {
                string a = e .Message;
            }
            finally {
                str .Close();
            }
        }
    }
}
