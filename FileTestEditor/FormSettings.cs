using System;
using System .Collections .Generic;
using System .ComponentModel;
using System .Data;
using System .Drawing;
using System .Linq;
using System .Text;
using System .Windows .Forms;

namespace FileTestEditor {
    public partial class FormSettings : Form {
        public FormSettings() {
            InitializeComponent();
        }

        private void buttonFolderShow_Click(object sender , EventArgs e) {
            folderBrowserDialog1 .SelectedPath = pathToProjectFolder .Text;
            folderBrowserDialog1 .ShowDialog(this);
            pathToProjectFolder .Text = folderBrowserDialog1 .SelectedPath;
        }        

        private void FormSettings_Load(object sender , EventArgs e) {
            this. comboBox1 .Items .AddRange(Program .AppManager .listColorModes);
            this .comboBox1 .ValueMember = "mode";
            this .comboBox1 .DisplayMember = "caption";
            this .comboBox1 .SelectedIndex = 0;

            this .pathToProjectFolder.Text = Program .AppManager .appSettings .pathToProjectFolder;
            this .device .Text = Program .AppManager .wiaS .getDeviceName();
            this .width.Text = Program .AppManager .scanSettings .horisontalExtent .ToString();
            this .height .Text = Program .AppManager .scanSettings .verticalExtent .ToString();
            this .resolution .Text = Program .AppManager .scanSettings .resolution.ToString();
            this .useDuplex .Checked = Program .AppManager .scanSettings .useDuplex;

          //  this .autosaveTime .Text = Program .AppManager .appSettings .autosaveTimeoutMinute.ToString();
            
            foreach (Data .Items.ItemColorMode item in this .comboBox1 .Items) {
                if (item .mode == Program .AppManager .scanSettings .currentIntent) {
                    this .comboBox1 .SelectedItem = item;
                    break;
                }
            }
        }

        private void buttonCancel_Click(object sender , EventArgs e) {
            this .Close();
        }

        private void buttonDeviceSelect_Click(object sender , EventArgs e) {
            Scanning.MyWIA.OperationResult opRes = Program .AppManager .wiaS .selectDevice();
            if (opRes.hasError) {
                Helper .MessageManager .showErrorMessage(opRes .message);
                return;
            }
            if (Program .AppManager .wiaS .getDevice() != null) {
                Program .AppManager .scanSettings .deviceId = Program .AppManager .wiaS .getDevice() .DeviceID;
            }
            this .FormSettings_Load(sender , e);
        }

        private void buttonOk_Click(object sender , EventArgs e) {
            Program .AppManager .appSettings .pathToProjectFolder = this .pathToProjectFolder .Text;
            Program .AppManager .scanSettings .horisontalExtent = Convert.ToInt32(this .width .Text); 
            Program .AppManager .scanSettings .verticalExtent = Convert.ToInt32(this .height .Text);
            Program .AppManager .scanSettings .resolution = Convert.ToInt32(this .resolution .Text);
            Program .AppManager .scanSettings .useDuplex = this .useDuplex .Checked;

            Program .AppManager .scanSettings .saveToHardwareStorage(Program .AppManager .fileSettingScan);
            Program .AppManager .appSettings .saveToHardwareStorage(Program .AppManager .fileSettingApp);
          //  Program .AppManager .appSettings .autosaveTimeoutMinute = Convert.ToInt32(this .autosaveTime .Text); 
            this .Close();
        }


    }
}
