namespace FileTestEditor {
    partial class FormDSConnectDialog {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System .ComponentModel .IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components .Dispose();
            }
            base .Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this .groupBox1 = new System .Windows .Forms .GroupBox();
            this .pathToDS = new System .Windows .Forms .TextBox();
            this .groupBox2 = new System .Windows .Forms .GroupBox();
            this .catalog = new System .Windows .Forms .TextBox();
            this .groupBox3 = new System .Windows .Forms .GroupBox();
            this .user = new System .Windows .Forms .TextBox();
            this .groupBox4 = new System .Windows .Forms .GroupBox();
            this .pass = new System .Windows .Forms .TextBox();
            this .buttonOk = new System .Windows .Forms .Button();
            this .buttonCancel = new System .Windows .Forms .Button();
            this .groupBox1 .SuspendLayout();
            this .groupBox2 .SuspendLayout();
            this .groupBox3 .SuspendLayout();
            this .groupBox4 .SuspendLayout();
            this .SuspendLayout();
            // 
            // groupBox1
            // 
            this .groupBox1 .Controls .Add(this .pathToDS);
            this .groupBox1 .Location = new System .Drawing .Point(11 , 11);
            this .groupBox1 .Name = "groupBox1";
            this .groupBox1 .Size = new System .Drawing .Size(365 , 49);
            this .groupBox1 .TabIndex = 0;
            this .groupBox1 .TabStop = false;
            this .groupBox1 .Text = "Путь к экземрляру источника данных";
            // 
            // pathToDS
            // 
            this .pathToDS .Location = new System .Drawing .Point(14 , 17);
            this .pathToDS .Name = "pathToDS";
            this .pathToDS .Size = new System .Drawing .Size(335 , 20);
            this .pathToDS .TabIndex = 0;
            this .pathToDS .TextChanged += new System .EventHandler(this .pathToDS_TextChanged);
            // 
            // groupBox2
            // 
            this .groupBox2 .Controls .Add(this .catalog);
            this .groupBox2 .Location = new System .Drawing .Point(11 , 63);
            this .groupBox2 .Name = "groupBox2";
            this .groupBox2 .Size = new System .Drawing .Size(365 , 49);
            this .groupBox2 .TabIndex = 1;
            this .groupBox2 .TabStop = false;
            this .groupBox2 .Text = "Название каталога (БД)";
            // 
            // catalog
            // 
            this .catalog .Location = new System .Drawing .Point(14 , 17);
            this .catalog .Name = "catalog";
            this .catalog .Size = new System .Drawing .Size(149 , 20);
            this .catalog .TabIndex = 0;
            this .catalog .TextChanged += new System .EventHandler(this .catalog_TextChanged);
            // 
            // groupBox3
            // 
            this .groupBox3 .Controls .Add(this .user);
            this .groupBox3 .Location = new System .Drawing .Point(12 , 118);
            this .groupBox3 .Name = "groupBox3";
            this .groupBox3 .Size = new System .Drawing .Size(179 , 49);
            this .groupBox3 .TabIndex = 2;
            this .groupBox3 .TabStop = false;
            this .groupBox3 .Text = "Имя пользователя";
            // 
            // user
            // 
            this .user .Location = new System .Drawing .Point(14 , 17);
            this .user .Name = "user";
            this .user .Size = new System .Drawing .Size(149 , 20);
            this .user .TabIndex = 0;
            this .user .TextChanged += new System .EventHandler(this .user_TextChanged);
            // 
            // groupBox4
            // 
            this .groupBox4 .Controls .Add(this .pass);
            this .groupBox4 .Location = new System .Drawing .Point(197 , 118);
            this .groupBox4 .Name = "groupBox4";
            this .groupBox4 .Size = new System .Drawing .Size(179 , 49);
            this .groupBox4 .TabIndex = 3;
            this .groupBox4 .TabStop = false;
            this .groupBox4 .Text = "Пароль";
            // 
            // pass
            // 
            this .pass .Location = new System .Drawing .Point(14 , 17);
            this .pass .Name = "pass";
            this .pass .PasswordChar = '*';
            this .pass .Size = new System .Drawing .Size(149 , 20);
            this .pass .TabIndex = 0;
            this .pass .TextChanged += new System .EventHandler(this .pass_TextChanged);
            // 
            // buttonOk
            // 
            this .buttonOk .Location = new System .Drawing .Point(12 , 183);
            this .buttonOk .Name = "buttonOk";
            this .buttonOk .Size = new System .Drawing .Size(163 , 36);
            this .buttonOk .TabIndex = 4;
            this .buttonOk .Text = "Ok";
            this .buttonOk .UseVisualStyleBackColor = true;
            this .buttonOk .Click += new System .EventHandler(this .buttonOk_Click);
            // 
            // buttonCancel
            // 
            this .buttonCancel .Location = new System .Drawing .Point(184 , 182);
            this .buttonCancel .Name = "buttonCancel";
            this .buttonCancel .Size = new System .Drawing .Size(189 , 36);
            this .buttonCancel .TabIndex = 5;
            this .buttonCancel .Text = "Отмена";
            this .buttonCancel .UseVisualStyleBackColor = true;
            this .buttonCancel .Click += new System .EventHandler(this .buttonCancel_Click);
            // 
            // FormDSConnectDialog
            // 
            this .AutoScaleDimensions = new System .Drawing .SizeF(6F , 13F);
            this .AutoScaleMode = System .Windows .Forms .AutoScaleMode .Font;
            this .ClientSize = new System .Drawing .Size(395 , 230);
            this .Controls .Add(this .buttonCancel);
            this .Controls .Add(this .buttonOk);
            this .Controls .Add(this .groupBox4);
            this .Controls .Add(this .groupBox3);
            this .Controls .Add(this .groupBox2);
            this .Controls .Add(this .groupBox1);
            this .FormBorderStyle = System .Windows .Forms .FormBorderStyle .FixedToolWindow;
            this .Name = "FormDSConnectDialog";
            this .StartPosition = System .Windows .Forms .FormStartPosition .CenterParent;
            this .Text = "Установка соединения с источником даных";
            this .Load += new System .EventHandler(this .FormDSConnectDialog_Load);
            this .groupBox1 .ResumeLayout(false);
            this .groupBox1 .PerformLayout();
            this .groupBox2 .ResumeLayout(false);
            this .groupBox2 .PerformLayout();
            this .groupBox3 .ResumeLayout(false);
            this .groupBox3 .PerformLayout();
            this .groupBox4 .ResumeLayout(false);
            this .groupBox4 .PerformLayout();
            this .ResumeLayout(false);

        }

        #endregion

        private System .Windows .Forms .GroupBox groupBox1;
        private System .Windows .Forms .TextBox pathToDS;
        private System .Windows .Forms .GroupBox groupBox2;
        private System .Windows .Forms .TextBox catalog;
        private System .Windows .Forms .GroupBox groupBox3;
        private System .Windows .Forms .TextBox user;
        private System .Windows .Forms .GroupBox groupBox4;
        private System .Windows .Forms .TextBox pass;
        private System .Windows .Forms .Button buttonOk;
        private System .Windows .Forms .Button buttonCancel;
    }
}