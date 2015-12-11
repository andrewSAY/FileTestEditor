namespace FileTestEditor {
    partial class FormQstEditor {
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
            this .pictureBox1 = new System .Windows .Forms .PictureBox();
            this .groupBox1 = new System .Windows .Forms .GroupBox();
            this .qstType = new System .Windows .Forms .ComboBox();
            this .groupBox6 = new System .Windows .Forms .GroupBox();
            this .groupBox2 = new System .Windows .Forms .GroupBox();
            this .qstKey = new System .Windows .Forms .TextBox();
            this .buttonOk = new System .Windows .Forms .Button();
            this .buttonCancel = new System .Windows .Forms .Button();
            this .panel3 = new System .Windows .Forms .Panel();
            this .panel4 = new System .Windows .Forms .Panel();
            this .panel1 = new System .Windows .Forms .Panel();
            this .panel2 = new System .Windows .Forms .Panel();
            this .qstNumber = new FileTestEditor .ExpansionControllers .RegMaskTetxBox();
            ((System .ComponentModel .ISupportInitialize)(this .pictureBox1)) .BeginInit();
            this .groupBox1 .SuspendLayout();
            this .groupBox6 .SuspendLayout();
            this .groupBox2 .SuspendLayout();
            this .panel3 .SuspendLayout();
            this .panel4 .SuspendLayout();
            this .panel2 .SuspendLayout();
            this .SuspendLayout();
            // 
            // pictureBox1
            // 
            this .pictureBox1 .Dock = System .Windows .Forms .DockStyle .Fill;
            this .pictureBox1 .Location = new System .Drawing .Point(0 , 0);
            this .pictureBox1 .Name = "pictureBox1";
            this .pictureBox1 .Size = new System .Drawing .Size(1128 , 549);
            this .pictureBox1 .SizeMode = System .Windows .Forms .PictureBoxSizeMode .Zoom;
            this .pictureBox1 .TabIndex = 0;
            this .pictureBox1 .TabStop = false;
            // 
            // groupBox1
            // 
            this .groupBox1 .Controls .Add(this .qstType);
            this .groupBox1 .Location = new System .Drawing .Point(12 , 7);
            this .groupBox1 .Name = "groupBox1";
            this .groupBox1 .Size = new System .Drawing .Size(104 , 48);
            this .groupBox1 .TabIndex = 1;
            this .groupBox1 .TabStop = false;
            this .groupBox1 .Text = "Тип задания";
            // 
            // qstType
            // 
            this .qstType .DropDownStyle = System .Windows .Forms .ComboBoxStyle .DropDownList;
            this .qstType .FormattingEnabled = true;
            this .qstType .Items .AddRange(new object[] {
            "A",
            "B",
            "C",
            "Текст"});
            this .qstType .Location = new System .Drawing .Point(20 , 16);
            this .qstType .Name = "qstType";
            this .qstType .Size = new System .Drawing .Size(68 , 21);
            this .qstType .TabIndex = 0;
            this .qstType .SelectedIndexChanged += new System .EventHandler(this .qstType_SelectedIndexChanged);
            // 
            // groupBox6
            // 
            this .groupBox6 .Controls .Add(this .qstNumber);
            this .groupBox6 .Location = new System .Drawing .Point(122 , 7);
            this .groupBox6 .Name = "groupBox6";
            this .groupBox6 .Size = new System .Drawing .Size(105 , 48);
            this .groupBox6 .TabIndex = 6;
            this .groupBox6 .TabStop = false;
            this .groupBox6 .Text = "Номер задания";
            // 
            // groupBox2
            // 
            this .groupBox2 .Controls .Add(this .qstKey);
            this .groupBox2 .Location = new System .Drawing .Point(236 , 7);
            this .groupBox2 .Name = "groupBox2";
            this .groupBox2 .Size = new System .Drawing .Size(497 , 47);
            this .groupBox2 .TabIndex = 7;
            this .groupBox2 .TabStop = false;
            this .groupBox2 .Text = "Ключ к заданию";
            // 
            // qstKey
            // 
            this .qstKey .Location = new System .Drawing .Point(8 , 16);
            this .qstKey .Name = "qstKey";
            this .qstKey .Size = new System .Drawing .Size(488 , 20);
            this .qstKey .TabIndex = 0;
            this .qstKey .TextChanged += new System .EventHandler(this .qstKey_TextChanged);
            // 
            // buttonOk
            // 
            this .buttonOk .Location = new System .Drawing .Point(793 , 8);
            this .buttonOk .Name = "buttonOk";
            this .buttonOk .Size = new System .Drawing .Size(144 , 32);
            this .buttonOk .TabIndex = 8;
            this .buttonOk .Text = "Ok";
            this .buttonOk .UseVisualStyleBackColor = true;
            this .buttonOk .Click += new System .EventHandler(this .buttonOk_Click);
            // 
            // buttonCancel
            // 
            this .buttonCancel .Location = new System .Drawing .Point(949 , 8);
            this .buttonCancel .Name = "buttonCancel";
            this .buttonCancel .Size = new System .Drawing .Size(144 , 32);
            this .buttonCancel .TabIndex = 9;
            this .buttonCancel .Text = "Отмена";
            this .buttonCancel .UseVisualStyleBackColor = true;
            this .buttonCancel .Click += new System .EventHandler(this .buttonCancel_Click);
            // 
            // panel3
            // 
            this .panel3 .Controls .Add(this .buttonOk);
            this .panel3 .Controls .Add(this .buttonCancel);
            this .panel3 .Dock = System .Windows .Forms .DockStyle .Bottom;
            this .panel3 .Location = new System .Drawing .Point(0 , 628);
            this .panel3 .Name = "panel3";
            this .panel3 .Size = new System .Drawing .Size(1128 , 48);
            this .panel3 .TabIndex = 12;
            // 
            // panel4
            // 
            this .panel4 .Controls .Add(this .groupBox1);
            this .panel4 .Controls .Add(this .groupBox6);
            this .panel4 .Controls .Add(this .groupBox2);
            this .panel4 .Dock = System .Windows .Forms .DockStyle .Bottom;
            this .panel4 .Location = new System .Drawing .Point(0 , 570);
            this .panel4 .Name = "panel4";
            this .panel4 .Size = new System .Drawing .Size(1128 , 58);
            this .panel4 .TabIndex = 13;
            // 
            // panel1
            // 
            this .panel1 .Dock = System .Windows .Forms .DockStyle .Top;
            this .panel1 .Location = new System .Drawing .Point(0 , 0);
            this .panel1 .Name = "panel1";
            this .panel1 .Size = new System .Drawing .Size(1128 , 21);
            this .panel1 .TabIndex = 14;
            // 
            // panel2
            // 
            this .panel2 .BackColor = System .Drawing .SystemColors .ActiveCaption;
            this .panel2 .Controls .Add(this .pictureBox1);
            this .panel2 .Dock = System .Windows .Forms .DockStyle .Fill;
            this .panel2 .Location = new System .Drawing .Point(0 , 21);
            this .panel2 .Name = "panel2";
            this .panel2 .Size = new System .Drawing .Size(1128 , 549);
            this .panel2 .TabIndex = 15;
            // 
            // qstNumber
            // 
            this .qstNumber .Location = new System .Drawing .Point(12 , 15);
            this .qstNumber .Name = "qstNumber";
            this .qstNumber .regMask = "[0-9]";
            this .qstNumber .Size = new System .Drawing .Size(73 , 20);
            this .qstNumber .TabIndex = 3;
            this .qstNumber .TextAlign = System .Windows .Forms .HorizontalAlignment .Right;
            this .qstNumber .TextChanged += new System .EventHandler(this .qstNumber_TextChanged);
            // 
            // FormQstEditor
            // 
            this .AutoScaleDimensions = new System .Drawing .SizeF(6F , 13F);
            this .AutoScaleMode = System .Windows .Forms .AutoScaleMode .Font;
            this .ClientSize = new System .Drawing .Size(1128 , 676);
            this .Controls .Add(this .panel2);
            this .Controls .Add(this .panel1);
            this .Controls .Add(this .panel4);
            this .Controls .Add(this .panel3);
            this .FormBorderStyle = System .Windows .Forms .FormBorderStyle .Fixed3D;
            this .Name = "FormQstEditor";
            this .StartPosition = System .Windows .Forms .FormStartPosition .CenterParent;
            this .Text = "Редактирование задания";
            this .Load += new System .EventHandler(this .FormQstEditor_Load);
            ((System .ComponentModel .ISupportInitialize)(this .pictureBox1)) .EndInit();
            this .groupBox1 .ResumeLayout(false);
            this .groupBox6 .ResumeLayout(false);
            this .groupBox6 .PerformLayout();
            this .groupBox2 .ResumeLayout(false);
            this .groupBox2 .PerformLayout();
            this .panel3 .ResumeLayout(false);
            this .panel4 .ResumeLayout(false);
            this .panel2 .ResumeLayout(false);
            this .ResumeLayout(false);

        }

        #endregion

        private System .Windows .Forms .PictureBox pictureBox1;
        private System .Windows .Forms .GroupBox groupBox1;
        private System .Windows .Forms .ComboBox qstType;
        private System .Windows .Forms .GroupBox groupBox6;
        private ExpansionControllers .RegMaskTetxBox qstNumber;
        private System .Windows .Forms .GroupBox groupBox2;
        private System .Windows .Forms .TextBox qstKey;
        private System .Windows .Forms .Button buttonOk;
        private System .Windows .Forms .Button buttonCancel;
        private System .Windows .Forms .Panel panel3;
        private System .Windows .Forms .Panel panel4;
        private System .Windows .Forms .Panel panel1;
        private System .Windows .Forms .Panel panel2;
    }
}