using System;
using System .Collections .Generic;
using System .ComponentModel;
using System .Data;
using System .Drawing;
using System .Linq;
using System .Text;
using System .Windows .Forms;

namespace FileTestEditor {
    public partial class FormQstEditor : Form {
        public bool isNew { get; set; }
        public Image img { get; set; }
        public Data .Items .ItemVariant editQst { get; set; }
        public FormQstEditor() {            
            InitializeComponent();
        }

        private void FormQstEditor_Load(object sender , EventArgs e) {            
            if (isNew) {
                qstType .SelectedIndex = -1;
                pictureBox1 .Image = img;
                qstNumber .Text = string .Empty;
                qstKey .Text = string .Empty;
            }
            else {
                foreach (string item in qstType .Items) {
                    if (item == editQst .type .ToString()) {
                        qstType .SelectedItem = item;
                        break;
                    }
                }
                qstNumber .Text = editQst .number .ToString();
                qstKey .Text = editQst .key;
                pictureBox1 .Image = editQst.imageQst;
            }
            Unblocked();
        }

        private void buttonOk_Click(object sender , EventArgs e) {
            Data .Items .TypesQuest type = Data .Items .TypesQuest .A;
            switch (qstType .SelectedIndex) {
                case 0: type = Data .Items .TypesQuest .A; break;
                case 1: type = Data .Items .TypesQuest .B; break;
                case 2: type = Data .Items .TypesQuest .C; break;
                case 3: type = Data .Items .TypesQuest .T; break;
            }
            Data.Items.ItemVariant newQst = new Data .Items .ItemVariant(type , Convert .ToInt32(qstNumber .Text));
            newQst .key = qstKey .Text;
            newQst .imageQst = pictureBox1 .Image;
            if (isNew || newQst .caption != editQst .caption) {
                if (!Program .AppManager .variant .isUniqQstName(newQst)) {
                    if (DialogResult .OK != Helper .MessageManager .showOKCancelMessage("Задание " + newQst .caption + " уже существует! Все равно продолжить?")) {
                        return;
                    }
                }
            }
            if (isNew) {
                Program .AppManager .variant .addQuest(newQst);
            }
            else {
                Program .AppManager .variant .updateQuest(editQst , newQst);
            }
            this .Close();
        }

        private void buttonCancel_Click(object sender , EventArgs e) {
            Close();
        }

        private void qstType_SelectedIndexChanged(object sender , EventArgs e) {
            Unblocked();
        }

        private void Unblocked() {
            if (qstType .SelectedIndex != -1 && qstNumber .Text .Length > 0 && qstKey .Text .Length > 0) {
                buttonOk .Enabled = true;
                return;
            }
            buttonOk .Enabled = false;
        }

        private void qstNumber_TextChanged(object sender , EventArgs e) {
            Unblocked();
        }

        private void qstKey_TextChanged(object sender , EventArgs e) {
            Unblocked();
        }
    }
}
