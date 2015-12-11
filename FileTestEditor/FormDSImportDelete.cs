using System;
using System .Collections .Generic;
using System .ComponentModel;
using System .Data;
using System .Drawing;
using System .Linq;
using System .Text;
using System .Windows .Forms;

namespace FileTestEditor {
    public partial class FormDSImportDelete : Form {
        public FormDSImportDelete() {
            InitializeComponent();
        }

        private void FormDSExportDelete_Load(object sender , EventArgs e) {
            eduObjectList .DataSource = Program .AppManager .listEduObjects;
            eduObjectList .DisplayMember = "caption";
            eduObjectList .ValueMember = "number";            
        }

        private DataTable getDataSource(int eduObj) {
            string[] columnsName = { "Код предмета" , "Название предмета" , "Номер варианта" };
            return Helper .DataWorker .buildDataTable(columnsName , Program .AppManager .dbWorker .getVariantInfo(eduObj));
        }

        private void eduObjectList_SelectedIndexChanged(object sender , EventArgs e) {
            if (eduObjectList .SelectedIndex == -1) {
                return;
            }

            variantList .DataSource = getDataSource(((Data.Items.ItemEduObject)eduObjectList.SelectedItem).number);
        }

        private void variantList_SelectionChanged(object sender , EventArgs e) {
            Unblocked();
        }

        private void Unblocked() {
            if (variantList .SelectedRows .Count == 0) {
                buttonDelete .Enabled = false;
                buttonImport .Enabled = false;
                buttonPrint .Enabled = false;
            }

            if (variantList .SelectedRows .Count == 1) {
                buttonDelete .Enabled = true;
                buttonImport .Enabled = true;
                buttonPrint .Enabled = true;
            }

            if (variantList .SelectedRows .Count > 1) {
                buttonDelete .Enabled = true;
                buttonPrint .Enabled = true;
                buttonImport .Enabled = false;
            }
        }

        private void buttonImport_Click(object sender , EventArgs e) {
            if (Program .AppManager .variant != null) {
                if (Program .AppManager .variant .hasChanged) {
                    DialogResult dialResult = Helper .MessageManager .showYesNoCancelMessage("Обнаружены несохраненные изменениея. Сохранить перед закрытием?");
                    if (DialogResult .Yes == dialResult) {
                        Program .AppManager .saveVariant();
                    }
                    if (DialogResult .Cancel == dialResult) {
                        return;
                    }
                }
            }

            Program .AppManager .importVariantFromDataSource(int.Parse(variantList .SelectedRows[0] .Cells["Код предмета"] .Value.ToString()) , 
                                                                        int.Parse(variantList .SelectedRows[0] .Cells["Номер варианта"] .Value.ToString()));
        }

        private void buttonDelete_Click(object sender , EventArgs e) {
            DialogResult dRes = Helper .MessageManager .showOKCancelMessage("Вы действительно хотите удалить выбранные варианты?");
            if (dRes == System .Windows .Forms .DialogResult .OK) {

                foreach (DataGridViewRow row in variantList .SelectedRows) {
                    int eduObjCode = int.Parse(row .Cells["Код предмета"] .Value.ToString());
                    int variantNumber = int.Parse(row .Cells["Номер варианта"] .Value.ToString());
                    Program .AppManager .dbWorker .deleteVariant(eduObjCode , variantNumber);                    
                }
                Helper .MessageManager .showInfoMessage("Удаление выбранных вариантов завершено");
                eduObjectList_SelectedIndexChanged(sender , e);
            }

        }

        private void buttonPrint_Click(object sender , EventArgs e) {
            List<object[]> printList = new List<object[]>();
            foreach (DataGridViewRow row in variantList .SelectedRows) {
                int eduObjCode = int .Parse(row .Cells["Код предмета"] .Value .ToString());
                int variantNumber = int .Parse(row .Cells["Номер варианта"] .Value .ToString());
                string eduObjectName = row .Cells["Название предмета"] .Value .ToString();
                object[] item ={eduObjCode, variantNumber, eduObjectName};
                printList .Add(item);
            }

            FormPrintVariants form = new FormPrintVariants(printList);
            form .ShowDialog(this);
        }
    }
}
