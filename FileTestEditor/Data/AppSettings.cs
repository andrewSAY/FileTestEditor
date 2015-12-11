using System;
using System .Collections .Generic;
using System .Linq;
using System .Text;

namespace FileTestEditor .Data {
    [Serializable()]
    public class AppSettings:Model.BinaryStorageAbstract {
        public string pathToProjectFolder { get; set; }
        public string pathToProjectFolderSave { get; set; }
        public string pathToDataSource { get; set; }
        public string catalogInDataSource { get; set; }
        public int autosaveTimeoutMiliSecunde {get; private set;}
        public int autosaveTimeoutMinute {
            get {
                return this .autosaveTimeoutMiliSecunde / 60000;
            }
            set {
                this .autosaveTimeoutMiliSecunde = value * 60000;
            }
        }
        
        public AppSettings() { 
            this.pathToProjectFolder = System.Windows.Forms.Application.StartupPath;
            this .pathToProjectFolderSave = this .pathToProjectFolder + "/Projects";
            this .autosaveTimeoutMinute = 10;
            this .pathToDataSource = "ServerName\\ExemlarName";
            this .catalogInDataSource = "MyDataBase";
        }
    }
}
