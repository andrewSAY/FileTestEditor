namespace FileTestEditor {
    partial class FormSettings {
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
            this .tabPage1 = new System .Windows .Forms .TabPage();
            this .groupBox2 = new System .Windows .Forms .GroupBox();
            this .useDuplex = new System .Windows .Forms .CheckBox();
            this .buttonDeviceSelect = new System .Windows .Forms .Button();
            this .device = new System .Windows .Forms .Label();
            this .groupBox4 = new System .Windows .Forms .GroupBox();
            this .comboBox1 = new System .Windows .Forms .ComboBox();
            this .groupBox3 = new System .Windows .Forms .GroupBox();
            this .label2 = new System .Windows .Forms .Label();
            this .label1 = new System .Windows .Forms .Label();
            this .groupBox1 = new System .Windows .Forms .GroupBox();
            this .buttonFolderShow = new System .Windows .Forms .Button();
            this .tabControl1 = new System .Windows .Forms .TabControl();
            this .folderBrowserDialog1 = new System .Windows .Forms .FolderBrowserDialog();
            this .buttonOk = new System .Windows .Forms .Button();
            this .buttonCancel = new System .Windows .Forms .Button();
            this .groupBox5 = new System .Windows .Forms .GroupBox();
            this .resolution = new FileTestEditor .ExpansionControllers .RegMaskTetxBox();
            this .height = new FileTestEditor .ExpansionControllers .RegMaskTetxBox();
            this .width = new FileTestEditor .ExpansionControllers .RegMaskTetxBox();
            this .pathToProjectFolder = new FileTestEditor .ExpansionControllers .RegMaskTetxBox();
            this .tabPage1 .SuspendLayout();
            this .groupBox2 .SuspendLayout();
            this .groupBox4 .SuspendLayout();
            this .groupBox3 .SuspendLayout();
            this .groupBox1 .SuspendLayout();
            this .tabControl1 .SuspendLayout();
            this .groupBox5 .SuspendLayout();
            this .SuspendLayout();
            // 
            // tabPage1
            // 
            this .tabPage1 .Controls .Add(this .groupBox2);
            this .tabPage1 .Controls .Add(this .groupBox1);
            this .tabPage1 .Location = new System .Drawing .Point(4 , 22);
            this .tabPage1 .Name = "tabPage1";
            this .tabPage1 .Padding = new System .Windows .Forms .Padding(3);
            this .tabPage1 .Size = new System .Drawing .Size(514 , 410);
            this .tabPage1 .TabIndex = 0;
            this .tabPage1 .Text = "Общие";
            this .tabPage1 .UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this .groupBox2 .BackColor = System .Drawing .Color .WhiteSmoke;
            this .groupBox2 .Controls .Add(this .groupBox5);
            this .groupBox2 .Controls .Add(this .useDuplex);
            this .groupBox2 .Controls .Add(this .buttonDeviceSelect);
            this .groupBox2 .Controls .Add(this .device);
            this .groupBox2 .Controls .Add(this .groupBox4);
            this .groupBox2 .Controls .Add(this .groupBox3);
            this .groupBox2 .Location = new System .Drawing .Point(7 , 102);
            this .groupBox2 .Name = "groupBox2";
            this .groupBox2 .Size = new System .Drawing .Size(233 , 295);
            this .groupBox2 .TabIndex = 1;
            this .groupBox2 .TabStop = false;
            this .groupBox2 .Text = "Настройки сканирования";
            // 
            // useDuplex
            // 
            this .useDuplex .AutoSize = true;
            this .useDuplex .Location = new System .Drawing .Point(15 , 269);
            this .useDuplex .Name = "useDuplex";
            this .useDuplex .Size = new System .Drawing .Size(137 , 17);
            this .useDuplex .TabIndex = 1;
            this .useDuplex .Text = "Использавть дуплекс";
            this .useDuplex .UseVisualStyleBackColor = true;
            // 
            // buttonDeviceSelect
            // 
            this .buttonDeviceSelect .Location = new System .Drawing .Point(15 , 40);
            this .buttonDeviceSelect .Name = "buttonDeviceSelect";
            this .buttonDeviceSelect .Size = new System .Drawing .Size(132 , 21);
            this .buttonDeviceSelect .TabIndex = 3;
            this .buttonDeviceSelect .Text = "Изменить устройство";
            this .buttonDeviceSelect .UseVisualStyleBackColor = true;
            this .buttonDeviceSelect .Click += new System .EventHandler(this .buttonDeviceSelect_Click);
            // 
            // device
            // 
            this .device .AutoSize = true;
            this .device .Location = new System .Drawing .Point(15 , 24);
            this .device .Name = "device";
            this .device .Size = new System .Drawing .Size(35 , 13);
            this .device .TabIndex = 2;
            this .device .Text = "label3";
            // 
            // groupBox4
            // 
            this .groupBox4 .Controls .Add(this .comboBox1);
            this .groupBox4 .Location = new System .Drawing .Point(15 , 160);
            this .groupBox4 .Name = "groupBox4";
            this .groupBox4 .Size = new System .Drawing .Size(173 , 54);
            this .groupBox4 .TabIndex = 1;
            this .groupBox4 .TabStop = false;
            this .groupBox4 .Text = "Режми сканирования";
            // 
            // comboBox1
            // 
            this .comboBox1 .DropDownStyle = System .Windows .Forms .ComboBoxStyle .DropDownList;
            this .comboBox1 .FormattingEnabled = true;
            this .comboBox1 .Location = new System .Drawing .Point(14 , 22);
            this .comboBox1 .Name = "comboBox1";
            this .comboBox1 .Size = new System .Drawing .Size(133 , 21);
            this .comboBox1 .TabIndex = 0;
            // 
            // groupBox3
            // 
            this .groupBox3 .Controls .Add(this .height);
            this .groupBox3 .Controls .Add(this .width);
            this .groupBox3 .Controls .Add(this .label2);
            this .groupBox3 .Controls .Add(this .label1);
            this .groupBox3 .Location = new System .Drawing .Point(15 , 72);
            this .groupBox3 .Name = "groupBox3";
            this .groupBox3 .Size = new System .Drawing .Size(173 , 82);
            this .groupBox3 .TabIndex = 0;
            this .groupBox3 .TabStop = false;
            this .groupBox3 .Text = "Размеры листа в мм";
            // 
            // label2
            // 
            this .label2 .AutoSize = true;
            this .label2 .Location = new System .Drawing .Point(11 , 49);
            this .label2 .Name = "label2";
            this .label2 .Size = new System .Drawing .Size(45 , 13);
            this .label2 .TabIndex = 1;
            this .label2 .Text = "Высота";
            // 
            // label1
            // 
            this .label1 .AutoSize = true;
            this .label1 .Location = new System .Drawing .Point(11 , 26);
            this .label1 .Name = "label1";
            this .label1 .Size = new System .Drawing .Size(46 , 13);
            this .label1 .TabIndex = 0;
            this .label1 .Text = "Ширина";
            // 
            // groupBox1
            // 
            this .groupBox1 .Controls .Add(this .buttonFolderShow);
            this .groupBox1 .Controls .Add(this .pathToProjectFolder);
            this .groupBox1 .Location = new System .Drawing .Point(7 , 12);
            this .groupBox1 .Name = "groupBox1";
            this .groupBox1 .Size = new System .Drawing .Size(506 , 75);
            this .groupBox1 .TabIndex = 0;
            this .groupBox1 .TabStop = false;
            this .groupBox1 .Text = "Путь к папке проектов";
            // 
            // buttonFolderShow
            // 
            this .buttonFolderShow .Location = new System .Drawing .Point(364 , 45);
            this .buttonFolderShow .Name = "buttonFolderShow";
            this .buttonFolderShow .Size = new System .Drawing .Size(133 , 24);
            this .buttonFolderShow .TabIndex = 1;
            this .buttonFolderShow .Text = "Обзор";
            this .buttonFolderShow .UseVisualStyleBackColor = true;
            this .buttonFolderShow .Click += new System .EventHandler(this .buttonFolderShow_Click);
            // 
            // tabControl1
            // 
            this .tabControl1 .Controls .Add(this .tabPage1);
            this .tabControl1 .Location = new System .Drawing .Point(0 , 0);
            this .tabControl1 .Name = "tabControl1";
            this .tabControl1 .SelectedIndex = 0;
            this .tabControl1 .Size = new System .Drawing .Size(522 , 436);
            this .tabControl1 .TabIndex = 0;
            // 
            // buttonOk
            // 
            this .buttonOk .Location = new System .Drawing .Point(302 , 438);
            this .buttonOk .Name = "buttonOk";
            this .buttonOk .Size = new System .Drawing .Size(105 , 32);
            this .buttonOk .TabIndex = 1;
            this .buttonOk .Text = "Ok";
            this .buttonOk .UseVisualStyleBackColor = true;
            this .buttonOk .Click += new System .EventHandler(this .buttonOk_Click);
            // 
            // buttonCancel
            // 
            this .buttonCancel .Location = new System .Drawing .Point(413 , 438);
            this .buttonCancel .Name = "buttonCancel";
            this .buttonCancel .Size = new System .Drawing .Size(105 , 32);
            this .buttonCancel .TabIndex = 2;
            this .buttonCancel .Text = "Отмена";
            this .buttonCancel .UseVisualStyleBackColor = true;
            this .buttonCancel .Click += new System .EventHandler(this .buttonCancel_Click);
            // 
            // groupBox5
            // 
            this .groupBox5 .Controls .Add(this .resolution);
            this .groupBox5 .Location = new System .Drawing .Point(17 , 220);
            this .groupBox5 .Name = "groupBox5";
            this .groupBox5 .Size = new System .Drawing .Size(170 , 43);
            this .groupBox5 .TabIndex = 4;
            this .groupBox5 .TabStop = false;
            this .groupBox5 .Text = "Разарешенеи в dpi";
            // 
            // resolution
            // 
            this .resolution .Location = new System .Drawing .Point(66 , 15);
            this .resolution .Name = "resolution";
            this .resolution .regMask = "[0-9]";
            this .resolution .Size = new System .Drawing .Size(73 , 20);
            this .resolution .TabIndex = 3;
            this .resolution .TextAlign = System .Windows .Forms .HorizontalAlignment .Right;
            // 
            // height
            // 
            this .height .Location = new System .Drawing .Point(68 , 49);
            this .height .Name = "height";
            this .height .regMask = "[0-9]";
            this .height .Size = new System .Drawing .Size(73 , 20);
            this .height .TabIndex = 3;
            this .height .TextAlign = System .Windows .Forms .HorizontalAlignment .Center;
            // 
            // width
            // 
            this .width .Location = new System .Drawing .Point(68 , 23);
            this .width .Name = "width";
            this .width .regMask = "[0-9]";
            this .width .Size = new System .Drawing .Size(73 , 20);
            this .width .TabIndex = 2;
            this .width .TextAlign = System .Windows .Forms .HorizontalAlignment .Center;
            // 
            // pathToProjectFolder
            // 
            this .pathToProjectFolder .Location = new System .Drawing .Point(11 , 18);
            this .pathToProjectFolder .Name = "pathToProjectFolder";
            this .pathToProjectFolder .regMask = "";
            this .pathToProjectFolder .Size = new System .Drawing .Size(485 , 20);
            this .pathToProjectFolder .TabIndex = 0;
            // 
            // FormSettings
            // 
            this .AutoScaleDimensions = new System .Drawing .SizeF(6F , 13F);
            this .AutoScaleMode = System .Windows .Forms .AutoScaleMode .Font;
            this .ClientSize = new System .Drawing .Size(522 , 472);
            this .Controls .Add(this .buttonCancel);
            this .Controls .Add(this .buttonOk);
            this .Controls .Add(this .tabControl1);
            this .FormBorderStyle = System .Windows .Forms .FormBorderStyle .FixedToolWindow;
            this .Name = "FormSettings";
            this .StartPosition = System .Windows .Forms .FormStartPosition .CenterParent;
            this .Text = "Настройки";
            this .Load += new System .EventHandler(this .FormSettings_Load);
            this .tabPage1 .ResumeLayout(false);
            this .groupBox2 .ResumeLayout(false);
            this .groupBox2 .PerformLayout();
            this .groupBox4 .ResumeLayout(false);
            this .groupBox3 .ResumeLayout(false);
            this .groupBox3 .PerformLayout();
            this .groupBox1 .ResumeLayout(false);
            this .groupBox1 .PerformLayout();
            this .tabControl1 .ResumeLayout(false);
            this .groupBox5 .ResumeLayout(false);
            this .groupBox5 .PerformLayout();
            this .ResumeLayout(false);

        }

        #endregion

        private System .Windows .Forms .TabPage tabPage1;
        private System .Windows .Forms .GroupBox groupBox1;
        private System .Windows .Forms .Button buttonFolderShow;
        private ExpansionControllers .RegMaskTetxBox pathToProjectFolder;
        private System .Windows .Forms .TabControl tabControl1;
        private System .Windows .Forms .FolderBrowserDialog folderBrowserDialog1;
        private System .Windows .Forms .GroupBox groupBox2;
        private System .Windows .Forms .GroupBox groupBox3;
        private ExpansionControllers .RegMaskTetxBox height;
        private ExpansionControllers .RegMaskTetxBox width;
        private System .Windows .Forms .Label label2;
        private System .Windows .Forms .Label label1;
        private System .Windows .Forms .GroupBox groupBox4;
        private System .Windows .Forms .ComboBox comboBox1;
        private System .Windows .Forms .Button buttonDeviceSelect;
        private System .Windows .Forms .Label device;
        private System .Windows .Forms .CheckBox useDuplex;
        private System .Windows .Forms .Button buttonOk;
        private System .Windows .Forms .Button buttonCancel;
        private System .Windows .Forms .GroupBox groupBox5;
        private ExpansionControllers .RegMaskTetxBox resolution;


    }
}