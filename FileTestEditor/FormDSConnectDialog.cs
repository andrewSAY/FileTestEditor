using System;
using System .Collections .Generic;
using System .ComponentModel;
using System .Data;
using System .Drawing;
using System .Linq;
using System .Text;
using System .Windows .Forms;

namespace FileTestEditor {
    public partial class FormDSConnectDialog : Form {
        public FormDSConnectDialog() {
            InitializeComponent();
        }

        private void FormDSConnectDialog_Load(object sender , EventArgs e) {
            pathToDS .Text = Program .AppManager .appSettings .pathToDataSource;
            catalog .Text = Program .AppManager .appSettings .catalogInDataSource;
            Unblocked();
        }

        private void Unblocked() {
            if (pathToDS .Text .Length == 0
                    || catalog .Text .Length == 0
                        || user .Text .Length == 0
                            || pass .Text .Length == 0) {
                                buttonOk .Enabled = false;
                                return;
            }
            buttonOk .Enabled = true;
        }

        private void pathToDS_TextChanged(object sender , EventArgs e) {
            Unblocked();
        }

        private void catalog_TextChanged(object sender , EventArgs e) {
            Unblocked();
        }

        private void user_TextChanged(object sender , EventArgs e) {
            Unblocked();
        }       

        private void pass_TextChanged(object sender , EventArgs e) {
            Unblocked();
        }

        private void buttonOk_Click(object sender , EventArgs e) {
            if (!Program .AppManager .createConnectionWithDataSource(pathToDS .Text , catalog .Text , user .Text , pass .Text)) {
                Helper .MessageManager .showErrorMessage("Не удалось установить соединение с источником данных");
                return;
            }
            Helper .MessageManager .showInfoMessage("Соединение с источником данных успешно установлено");
            Program .AppManager .appSettings .pathToDataSource = pathToDS .Text;
            Program .AppManager .appSettings .catalogInDataSource = catalog .Text;
            Program .AppManager .appSettings .saveToHardwareStorage(Program .AppManager .fileSettingApp);

            Close();
        }

        private void buttonCancel_Click(object sender , EventArgs e) {
            Close();
        }
    }
}
