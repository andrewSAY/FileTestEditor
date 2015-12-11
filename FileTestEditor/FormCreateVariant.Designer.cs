namespace FileTestEditor {
    partial class FormCreateVariant {
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
            this .eduObjects = new System .Windows .Forms .ComboBox();
            this .groupBox2 = new System .Windows .Forms .GroupBox();
            this .variantNumber = new FileTestEditor .ExpansionControllers .RegMaskTetxBox();
            this .ok = new System .Windows .Forms .Button();
            this .Cancel = new System .Windows .Forms .Button();
            this .groupBox1 .SuspendLayout();
            this .groupBox2 .SuspendLayout();
            this .SuspendLayout();
            // 
            // groupBox1
            // 
            this .groupBox1 .Controls .Add(this .eduObjects);
            this .groupBox1 .Location = new System .Drawing .Point(9 , 9);
            this .groupBox1 .Name = "groupBox1";
            this .groupBox1 .Size = new System .Drawing .Size(193 , 52);
            this .groupBox1 .TabIndex = 0;
            this .groupBox1 .TabStop = false;
            this .groupBox1 .Text = "Предмет";
            // 
            // eduObjects
            // 
            this .eduObjects .DropDownStyle = System .Windows .Forms .ComboBoxStyle .DropDownList;
            this .eduObjects .FormattingEnabled = true;
            this .eduObjects .Location = new System .Drawing .Point(10 , 20);
            this .eduObjects .Name = "eduObjects";
            this .eduObjects .Size = new System .Drawing .Size(177 , 21);
            this .eduObjects .TabIndex = 0;
            this .eduObjects .SelectedIndexChanged += new System .EventHandler(this .eduObjects_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this .groupBox2 .Controls .Add(this .variantNumber);
            this .groupBox2 .Location = new System .Drawing .Point(208 , 9);
            this .groupBox2 .Name = "groupBox2";
            this .groupBox2 .Size = new System .Drawing .Size(82 , 52);
            this .groupBox2 .TabIndex = 1;
            this .groupBox2 .TabStop = false;
            this .groupBox2 .Text = "Вариант";
            // 
            // variantNumber
            // 
            this .variantNumber .Location = new System .Drawing .Point(21 , 19);
            this .variantNumber .Name = "variantNumber";
            this .variantNumber .regMask = "[0-9]";
            this .variantNumber .Size = new System .Drawing .Size(57 , 20);
            this .variantNumber .TabIndex = 4;
            this .variantNumber .TextAlign = System .Windows .Forms .HorizontalAlignment .Right;
            this .variantNumber .TextChanged += new System .EventHandler(this .variantNumber_TextChanged);
            // 
            // ok
            // 
            this .ok .Enabled = false;
            this .ok .Location = new System .Drawing .Point(66 , 81);
            this .ok .Name = "ok";
            this .ok .Size = new System .Drawing .Size(135 , 24);
            this .ok .TabIndex = 2;
            this .ok .Text = "Ok";
            this .ok .UseVisualStyleBackColor = true;
            this .ok .Click += new System .EventHandler(this .ok_Click);
            // 
            // Cancel
            // 
            this .Cancel .Location = new System .Drawing .Point(208 , 81);
            this .Cancel .Name = "Cancel";
            this .Cancel .Size = new System .Drawing .Size(82 , 24);
            this .Cancel .TabIndex = 3;
            this .Cancel .Text = "Отмена";
            this .Cancel .UseVisualStyleBackColor = true;
            this .Cancel .Click += new System .EventHandler(this .Cancel_Click);
            // 
            // FormCreateVariant
            // 
            this .AutoScaleDimensions = new System .Drawing .SizeF(6F , 13F);
            this .AutoScaleMode = System .Windows .Forms .AutoScaleMode .Font;
            this .ClientSize = new System .Drawing .Size(310 , 117);
            this .Controls .Add(this .Cancel);
            this .Controls .Add(this .ok);
            this .Controls .Add(this .groupBox2);
            this .Controls .Add(this .groupBox1);
            this .FormBorderStyle = System .Windows .Forms .FormBorderStyle .FixedToolWindow;
            this .Name = "FormCreateVariant";
            this .StartPosition = System .Windows .Forms .FormStartPosition .CenterParent;
            this .Text = "Новый вариант";
            this .Load += new System .EventHandler(this .FormCreateVariant_Load);
            this .groupBox1 .ResumeLayout(false);
            this .groupBox2 .ResumeLayout(false);
            this .groupBox2 .PerformLayout();
            this .ResumeLayout(false);

        }

        #endregion

        private System .Windows .Forms .GroupBox groupBox1;
        private System .Windows .Forms .GroupBox groupBox2;
        private ExpansionControllers .RegMaskTetxBox variantNumber;
        private System .Windows .Forms .ComboBox eduObjects;
        private System .Windows .Forms .Button ok;
        private System .Windows .Forms .Button Cancel;
    }
}