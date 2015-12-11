namespace FileTestEditor {
    partial class FormPrintVariants {
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
            this .printerList = new System .Windows .Forms .ComboBox();
            this .groupBox2 = new System .Windows .Forms .GroupBox();
            this .qstTypeList = new System .Windows .Forms .CheckedListBox();
            this .buttonPrint = new System .Windows .Forms .Button();
            this .buttonCancel = new System .Windows .Forms .Button();
            this .groupBox1 .SuspendLayout();
            this .groupBox2 .SuspendLayout();
            this .SuspendLayout();
            // 
            // groupBox1
            // 
            this .groupBox1 .Controls .Add(this .printerList);
            this .groupBox1 .Location = new System .Drawing .Point(18 , 21);
            this .groupBox1 .Name = "groupBox1";
            this .groupBox1 .Size = new System .Drawing .Size(350 , 49);
            this .groupBox1 .TabIndex = 0;
            this .groupBox1 .TabStop = false;
            this .groupBox1 .Text = "Принтер";
            // 
            // printerList
            // 
            this .printerList .Dock = System .Windows .Forms .DockStyle .Fill;
            this .printerList .DropDownStyle = System .Windows .Forms .ComboBoxStyle .DropDownList;
            this .printerList .FormattingEnabled = true;
            this .printerList .Location = new System .Drawing .Point(3 , 16);
            this .printerList .Name = "printerList";
            this .printerList .Size = new System .Drawing .Size(344 , 21);
            this .printerList .TabIndex = 0;
            this .printerList .SelectedIndexChanged += new System .EventHandler(this .printerList_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this .groupBox2 .Controls .Add(this .qstTypeList);
            this .groupBox2 .Location = new System .Drawing .Point(18 , 83);
            this .groupBox2 .Name = "groupBox2";
            this .groupBox2 .Size = new System .Drawing .Size(114 , 85);
            this .groupBox2 .TabIndex = 1;
            this .groupBox2 .TabStop = false;
            this .groupBox2 .Text = "Типы заданий";
            // 
            // qstTypeList
            // 
            this .qstTypeList .CheckOnClick = true;
            this .qstTypeList .Dock = System .Windows .Forms .DockStyle .Fill;
            this .qstTypeList .FormattingEnabled = true;
            this .qstTypeList .Items .AddRange(new object[] {
            "A",
            "B",
            "C",
            "T"});
            this .qstTypeList .Location = new System .Drawing .Point(3 , 16);
            this .qstTypeList .Name = "qstTypeList";
            this .qstTypeList .Size = new System .Drawing .Size(108 , 66);
            this .qstTypeList .TabIndex = 0;
            this .qstTypeList .SelectedIndexChanged += new System .EventHandler(this .qstTypeList_SelectedIndexChanged);
            // 
            // buttonPrint
            // 
            this .buttonPrint .Location = new System .Drawing .Point(21 , 183);
            this .buttonPrint .Name = "buttonPrint";
            this .buttonPrint .Size = new System .Drawing .Size(142 , 48);
            this .buttonPrint .TabIndex = 2;
            this .buttonPrint .Text = "Печатаь";
            this .buttonPrint .UseVisualStyleBackColor = true;
            this .buttonPrint .Click += new System .EventHandler(this .buttonPrint_Click);
            // 
            // buttonCancel
            // 
            this .buttonCancel .Location = new System .Drawing .Point(186 , 183);
            this .buttonCancel .Name = "buttonCancel";
            this .buttonCancel .Size = new System .Drawing .Size(182 , 48);
            this .buttonCancel .TabIndex = 3;
            this .buttonCancel .Text = "Отмена";
            this .buttonCancel .UseVisualStyleBackColor = true;
            // 
            // FormPrintVariants
            // 
            this .AutoScaleDimensions = new System .Drawing .SizeF(6F , 13F);
            this .AutoScaleMode = System .Windows .Forms .AutoScaleMode .Font;
            this .ClientSize = new System .Drawing .Size(379 , 255);
            this .Controls .Add(this .buttonCancel);
            this .Controls .Add(this .buttonPrint);
            this .Controls .Add(this .groupBox2);
            this .Controls .Add(this .groupBox1);
            this .FormBorderStyle = System .Windows .Forms .FormBorderStyle .FixedToolWindow;
            this .Name = "FormPrintVariants";
            this .StartPosition = System .Windows .Forms .FormStartPosition .CenterScreen;
            this .Text = "Печать вариантов";
            this .Load += new System .EventHandler(this .FormPrintVariants_Load);
            this .groupBox1 .ResumeLayout(false);
            this .groupBox2 .ResumeLayout(false);
            this .ResumeLayout(false);

        }

        #endregion

        private System .Windows .Forms .GroupBox groupBox1;
        private System .Windows .Forms .ComboBox printerList;
        private System .Windows .Forms .GroupBox groupBox2;
        private System .Windows .Forms .CheckedListBox qstTypeList;
        private System .Windows .Forms .Button buttonPrint;
        private System .Windows .Forms .Button buttonCancel;
    }
}