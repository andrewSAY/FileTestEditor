using System;
using System .Collections .Generic;
using System .ComponentModel;
using System .Data;
using System .Drawing;
using System .Linq;
using System .Text;
using System .IO;
using System .Windows .Forms;

namespace FileTestEditor {
    public partial class FormMain : Form {

        private string memoryCaption { get; set; }
        private FormQstEditor formEdit = new FormQstEditor();
        public FormMain() {
            InitializeComponent();
            memoryCaption = this .Text;
            Program .AppManager .changeVariantEvent += new Data .ApplicationManager .changeVariantVoid(this .formAdoptation);
            Program.AppManager.dbWorker.connectCnanged+=new Data.DataBase.Worker.hasConnectChanged(this.formAdoptation);
            pictureBox1.changeCutingImage+=new ExpansionControllers.PaintPictureBox.changecutingImageDelegate(this.showQstEditor);            
            formEdit.FormClosing +=new FormClosingEventHandler(closingQstEditor);
            Program. AppManager .loadApplication();
        }

        private void buttonScan_Click(object sender , EventArgs e) {            
            List<Image> dumpList = new List<Image>();            
            Helper.MessageManager.showInfoMessage(Program .AppManager .wiaS .scaningMulti(ref dumpList , Program .AppManager .scanSettings).message);            
            foreach (Image img in dumpList) {
                Program .AppManager .variant .addImageList(img);
            }
            listBoxImg .Items.AddRange(Program .AppManager .variant .getImageList().ToArray());

        }

        private void настройкиToolStripMenuItem_Click(object sender , EventArgs e) {
            FormSettings form = new FormSettings();
            form .ShowDialog(this);
        }

        private void новыйВариантToolStripMenuItem_Click(object sender , EventArgs e) {
            FormCreateVariant formCreate = new FormCreateVariant();
            formCreate .ShowDialog(this);
        }

        private void formAdoptation() {
            if (Program .AppManager .variant == null) {
                listBoxImg .Items .Clear();
                listBoxQst .Items .Clear();
                pictureBox1 .Image = null;
                this .panelLeft .Enabled = false;
                this .panelRight .Enabled = false;
                this .panelMiddle .Enabled = false;
                сохранитьToolStripMenuItem1 .Enabled = false;
                закрытьToolStripMenuItem .Enabled = false;
                this .Text = memoryCaption;
            }
            else {
                listBoxImg .Items .AddRange(Program .AppManager .variant .getImageList() .ToArray());                
                listBoxQst .Items .AddRange(Program .AppManager .variant .getDataSource() .ToArray());
                this .panelLeft .Enabled = true;
                this .panelRight .Enabled = true;
                this .panelMiddle .Enabled = true;
                сохранитьToolStripMenuItem1 .Enabled = true;
                закрытьToolStripMenuItem .Enabled = true;
                this .Text = String .Format(" [{0}] Вариант №{1}" , Program .AppManager .variant .eduObject .caption , Program .AppManager .variant .number);
            }

            if (!Program .AppManager .dbWorker .hasConnect) {
                установитьСоединениеToolStripMenuItem .Enabled = true;
                импортИУдалениеToolStripMenuItem .Enabled = false;
                экспортироватьТекущийВариантToolStripMenuItem .Enabled = false;
                массовыйЭкспортToolStripMenuItem .Enabled = false;
                закрытьСоединениеToolStripMenuItem .Enabled = false;
            }
            else {
                установитьСоединениеToolStripMenuItem .Enabled = false;
                импортИУдалениеToolStripMenuItem .Enabled = true;
                if (Program .AppManager .variant != null) {
                    экспортироватьТекущийВариантToolStripMenuItem .Enabled = true;
                }
                else {
                    экспортироватьТекущийВариантToolStripMenuItem .Enabled = false;
                }
                массовыйЭкспортToolStripMenuItem .Enabled = true;
                закрытьСоединениеToolStripMenuItem .Enabled = true;
            }
        }

        private void showQstEditor(bool isNew) {
            this .formEdit .isNew = isNew;
            this .formEdit .img = pictureBox1 .cutingImage;
            if (!isNew) {
                formEdit .editQst = (Data .Items .ItemVariant)listBoxQst .SelectedItem;
            }
            formEdit .ShowDialog(this);
        }

        private void closingQstEditor(object sender , EventArgs e) {
            listBoxQst .Items .Clear();
            Program.AppManager.variant.sortDataSource();
            listBoxQst .Items .AddRange(Program .AppManager .variant .getDataSource() .ToArray());
        }

        private void FormMain_Load(object sender , EventArgs e) {
            listBoxImg .DisplayMember = "caption";
            listBoxQst .DisplayMember = "caption";
        }

        

        private void открытьToolStripMenuItem_Click(object sender , EventArgs e) {           
            openFileDialog1 .InitialDirectory = Program .AppManager .appSettings .pathToProjectFolder;
            openFileDialog1 .ShowDialog(this);
            if (File .Exists(openFileDialog1 .FileName)) { 
                Program.AppManager.loadVariant(openFileDialog1.FileName);               
            }
        }

        private void listBoxImg_SelectedIndexChanged(object sender , EventArgs e) {
            if (listBoxImg .SelectedIndex == -1) {
                pictureBox1 .Image = null;
                return;
            }
            pictureBox1 .Image = ((Data .Items .ItemImageList)listBoxImg .SelectedItem) .img;
        }

        private void buttonDelSelected_Click(object sender , EventArgs e) {
            if (listBoxImg .SelectedItems .Count == 0) {
                return;
            }
            if (Helper .MessageManager .showOKCancelMessage("Вы действительно хотите удалить выбранные изображения?") != System .Windows .Forms .DialogResult .OK) {
                return;
            }
            foreach (Data .Items .ItemImageList item in listBoxImg .SelectedItems) {
                Program .AppManager .variant .removeImageList(item);
            }
            listBoxImg .Items .Clear();
            listBoxImg .Items .AddRange(Program .AppManager .variant .getImageList() .ToArray());
        }

        private void buttonQstDel_Click(object sender , EventArgs e) {
            if (listBoxQst .SelectedItems.Count == 0) {
                return;
            }
            if (Helper .MessageManager .showOKCancelMessage("Вы действительно хотите удалить выбранное задание?") != System .Windows .Forms .DialogResult .OK) {
                return;
            }
            foreach (Data .Items .ItemVariant item in listBoxQst .SelectedItems) {
                Program .AppManager .variant .removeQuest(item);
            }
            listBoxQst .Items .Clear();
            listBoxQst .Items .AddRange(Program .AppManager .variant .getDataSource() .ToArray());
        }

        private void buttonQstEdit_Click(object sender , EventArgs e) {
            if (listBoxQst .SelectedIndex == -1) {
                return;
            }
            showQstEditor(false);
        }

        private void FormMain_FormClosing(object sender , FormClosingEventArgs e) {
            if (Program .AppManager .variant == null) {
                return;
            }
            if (Program .AppManager .variant .hasChanged) {
                DialogResult dialResult = Helper .MessageManager .showYesNoCancelMessage("Обнаружены несохраненные изменениея. Сохранить перед закрытием?");
                if (DialogResult .Yes == dialResult) {
                    Program .AppManager .saveVariant();
                }
                if (DialogResult .Cancel == dialResult) {
                    e .Cancel = true;
                }
            }            
        }

        private void buttonScanMulti_Click(object sender , EventArgs e) {
            List<Image> dumpList = new List<Image>();
            Helper .MessageManager .showInfoMessage(Program .AppManager .wiaS .scaningOne(ref dumpList , Program .AppManager .scanSettings) .message);
            foreach (Image img in dumpList) {
                Program .AppManager .variant .addImageList(img);
            }
            listBoxImg .Items .AddRange(Program .AppManager .variant .getImageList() .ToArray());
        }

        private void buttonDelAll_Click(object sender , EventArgs e) {
            if (listBoxImg .SelectedItems .Count == 0) {
                return;
            }
            if (Helper .MessageManager .showOKCancelMessage("Вы действительно хотите удалить все изображения?") != System .Windows .Forms .DialogResult .OK) {
                return;
            }
            foreach (Data .Items .ItemImageList item in listBoxImg .Items) {
                Program .AppManager .variant .removeImageList(item);
            }
            listBoxImg .Items .Clear();
            listBoxImg .Items .AddRange(Program .AppManager .variant .getImageList() .ToArray());
        }

        private void buttonOpenImg_Click(object sender , EventArgs e) {
            openFileDialog2 .ShowDialog(this);
            if (openFileDialog2 .FileNames .Count() == 0) {
                return;
            }                           
            foreach (string filename in openFileDialog2.FileNames) {
                Image img = Image .FromFile(filename);                
                Program .AppManager .variant .addImageList(img);
            }
            listBoxImg .Items .Clear();
            listBoxImg .Items .AddRange(Program .AppManager .variant .getImageList() .ToArray());
        }

        private void сохранитьToolStripMenuItem1_Click(object sender , EventArgs e) {
            Program .AppManager .saveVariant();
        }

        private void закрытьToolStripMenuItem_Click(object sender , EventArgs e) {
            if (Program .AppManager .variant .hasChanged) {
                DialogResult dialResult = Helper .MessageManager .showYesNoCancelMessage("Обнаружены несохраненные изменениея. Сохранить перед закрытием?");
                if (DialogResult .Yes == dialResult) {
                    Program .AppManager .saveVariant();
                }
                if (DialogResult .Cancel == dialResult) {
                    return;
                }
            }
            Program .AppManager .closeVariant();            
        }

        private void выходToolStripMenuItem_Click(object sender , EventArgs e) {
            Close();
        }

        private void установитьСоединениеToolStripMenuItem_Click(object sender , EventArgs e) {
            FormDSConnectDialog form = new FormDSConnectDialog();
            form .ShowDialog(this);
        }

        private void закрытьСоединениеToolStripMenuItem_Click(object sender , EventArgs e) {
            Program .AppManager .dbWorker .Close();
        }

        private void импортИУдалениеToolStripMenuItem_Click(object sender , EventArgs e) {
            FormDSImportDelete form = new FormDSImportDelete();
            form .ShowDialog(this);
        }

        private void listBoxQst_SelectedIndexChanged(object sender , EventArgs e) {

        }

        private void listBoxQst_MouseDoubleClick(object sender , MouseEventArgs e) {
            if (listBoxQst .SelectedIndex == -1) {
                return;
            }
            showQstEditor(false);
        }

        private void экспортироватьТекущийВариантToolStripMenuItem_Click(object sender , EventArgs e) {
            if (Program .AppManager .dbWorker .hasVariant(Program .AppManager .variant .eduObject .number , Program .AppManager .variant .number)) {
                DialogResult dRes = Helper .MessageManager .showOKCancelMessage("Такой вариант уже существует в источнике данных. Заменить его?");
                if (dRes == System .Windows .Forms .DialogResult .Cancel) {
                    return;
                }
            }
            Program .AppManager .exportVariantToDataSource(true);
        }
    }
}
