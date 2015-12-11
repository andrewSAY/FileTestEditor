using System;
using System .Collections .Generic;
using System .ComponentModel;
using System .Data;
using System .Drawing;
using System .Linq;
using System .Text;
using System .Windows .Forms;

namespace FileTestEditor {
    public partial class FormCreateVariant : Form {
        public FormCreateVariant() {
            InitializeComponent();
        }

        private void eduObjects_SelectedIndexChanged(object sender , EventArgs e) {
            Unblocked();
        }

        private void Unblocked() {
            if (eduObjects .SelectedIndex != -1 && variantNumber .Text .Length > 0) {
                ok .Enabled = true;
                return;
            }
            ok .Enabled = false;
        }

        private void variantNumber_TextChanged(object sender , EventArgs e) {
            Unblocked();
        }

        private void FormCreateVariant_Load(object sender , EventArgs e) {
            eduObjects .DataSource = Program .AppManager .listEduObjects;
            eduObjects .DisplayMember = "caption";
            eduObjects .ValueMember = "caption";
        }

        private void Cancel_Click(object sender , EventArgs e) {
            Close();
        }

        private void ok_Click(object sender , EventArgs e) {
            string filename = (new Data.VariantAdapter(((Data.Items.ItemEduObject)eduObjects.SelectedItem),Convert.ToInt32(variantNumber.Text))).fileName;
            if (System .IO .File .Exists(Program.AppManager .appSettings .pathToProjectFolder + "\\" + filename)) {
                if (System .Windows .Forms .DialogResult .OK == Helper .MessageManager .showOKCancelMessage("Такой файл " + filename + " уже существует. Заменить его?")) {
                    Program .AppManager .createVarirant((Data .Items .ItemEduObject)eduObjects .SelectedItem , Convert .ToInt32(variantNumber .Text));
                    this .Close();
                }
                else {
                    return;
                }
            }
            Program .AppManager .createVarirant((Data .Items .ItemEduObject)eduObjects .SelectedItem , Convert .ToInt32(variantNumber .Text));
            this .Close();
        }
    }
}
