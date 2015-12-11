namespace FileTestEditor {
    partial class FormDSImportDelete {
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
            System .Windows .Forms .DataGridViewCellStyle dataGridViewCellStyle4 = new System .Windows .Forms .DataGridViewCellStyle();
            System .Windows .Forms .DataGridViewCellStyle dataGridViewCellStyle5 = new System .Windows .Forms .DataGridViewCellStyle();
            System .Windows .Forms .DataGridViewCellStyle dataGridViewCellStyle6 = new System .Windows .Forms .DataGridViewCellStyle();
            this .groupBox1 = new System .Windows .Forms .GroupBox();
            this .eduObjectList = new System .Windows .Forms .ComboBox();
            this .groupBox2 = new System .Windows .Forms .GroupBox();
            this .variantList = new System .Windows .Forms .DataGridView();
            this .groupBox3 = new System .Windows .Forms .GroupBox();
            this .buttonDelete = new System .Windows .Forms .Button();
            this .buttonImport = new System .Windows .Forms .Button();
            this .buttonPrint = new System .Windows .Forms .Button();
            this .groupBox1 .SuspendLayout();
            this .groupBox2 .SuspendLayout();
            ((System .ComponentModel .ISupportInitialize)(this .variantList)) .BeginInit();
            this .groupBox3 .SuspendLayout();
            this .SuspendLayout();
            // 
            // groupBox1
            // 
            this .groupBox1 .Controls .Add(this .eduObjectList);
            this .groupBox1 .Location = new System .Drawing .Point(12 , 8);
            this .groupBox1 .Name = "groupBox1";
            this .groupBox1 .Size = new System .Drawing .Size(807 , 52);
            this .groupBox1 .TabIndex = 0;
            this .groupBox1 .TabStop = false;
            this .groupBox1 .Text = "Предмет";
            // 
            // eduObjectList
            // 
            this .eduObjectList .DropDownStyle = System .Windows .Forms .ComboBoxStyle .DropDownList;
            this .eduObjectList .FormattingEnabled = true;
            this .eduObjectList .Location = new System .Drawing .Point(6 , 19);
            this .eduObjectList .Name = "eduObjectList";
            this .eduObjectList .Size = new System .Drawing .Size(251 , 21);
            this .eduObjectList .TabIndex = 0;
            this .eduObjectList .SelectedIndexChanged += new System .EventHandler(this .eduObjectList_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this .groupBox2 .Controls .Add(this .variantList);
            this .groupBox2 .Location = new System .Drawing .Point(13 , 68);
            this .groupBox2 .Name = "groupBox2";
            this .groupBox2 .Size = new System .Drawing .Size(805 , 319);
            this .groupBox2 .TabIndex = 1;
            this .groupBox2 .TabStop = false;
            this .groupBox2 .Text = "Варианты";
            // 
            // variantList
            // 
            this .variantList .AllowUserToAddRows = false;
            this .variantList .AllowUserToDeleteRows = false;
            this .variantList .BackgroundColor = System .Drawing .SystemColors .ControlLightLight;
            dataGridViewCellStyle4 .Alignment = System .Windows .Forms .DataGridViewContentAlignment .MiddleLeft;
            dataGridViewCellStyle4 .BackColor = System .Drawing .SystemColors .Control;
            dataGridViewCellStyle4 .Font = new System .Drawing .Font("Microsoft Sans Serif" , 8.25F , System .Drawing .FontStyle .Regular , System .Drawing .GraphicsUnit .Point , ((byte)(204)));
            dataGridViewCellStyle4 .ForeColor = System .Drawing .SystemColors .WindowText;
            dataGridViewCellStyle4 .SelectionBackColor = System .Drawing .SystemColors .Highlight;
            dataGridViewCellStyle4 .SelectionForeColor = System .Drawing .SystemColors .HighlightText;
            dataGridViewCellStyle4 .WrapMode = System .Windows .Forms .DataGridViewTriState .True;
            this .variantList .ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this .variantList .ColumnHeadersHeightSizeMode = System .Windows .Forms .DataGridViewColumnHeadersHeightSizeMode .AutoSize;
            dataGridViewCellStyle5 .Alignment = System .Windows .Forms .DataGridViewContentAlignment .MiddleLeft;
            dataGridViewCellStyle5 .BackColor = System .Drawing .SystemColors .Window;
            dataGridViewCellStyle5 .Font = new System .Drawing .Font("Microsoft Sans Serif" , 8.25F , System .Drawing .FontStyle .Regular , System .Drawing .GraphicsUnit .Point , ((byte)(204)));
            dataGridViewCellStyle5 .ForeColor = System .Drawing .SystemColors .ControlText;
            dataGridViewCellStyle5 .SelectionBackColor = System .Drawing .SystemColors .Highlight;
            dataGridViewCellStyle5 .SelectionForeColor = System .Drawing .SystemColors .HighlightText;
            dataGridViewCellStyle5 .WrapMode = System .Windows .Forms .DataGridViewTriState .False;
            this .variantList .DefaultCellStyle = dataGridViewCellStyle5;
            this .variantList .Dock = System .Windows .Forms .DockStyle .Fill;
            this .variantList .Location = new System .Drawing .Point(3 , 16);
            this .variantList .Name = "variantList";
            this .variantList .ReadOnly = true;
            dataGridViewCellStyle6 .Alignment = System .Windows .Forms .DataGridViewContentAlignment .MiddleLeft;
            dataGridViewCellStyle6 .BackColor = System .Drawing .SystemColors .Control;
            dataGridViewCellStyle6 .Font = new System .Drawing .Font("Microsoft Sans Serif" , 8.25F , System .Drawing .FontStyle .Regular , System .Drawing .GraphicsUnit .Point , ((byte)(204)));
            dataGridViewCellStyle6 .ForeColor = System .Drawing .SystemColors .WindowText;
            dataGridViewCellStyle6 .SelectionBackColor = System .Drawing .SystemColors .Highlight;
            dataGridViewCellStyle6 .SelectionForeColor = System .Drawing .SystemColors .HighlightText;
            dataGridViewCellStyle6 .WrapMode = System .Windows .Forms .DataGridViewTriState .True;
            this .variantList .RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this .variantList .SelectionMode = System .Windows .Forms .DataGridViewSelectionMode .FullRowSelect;
            this .variantList .Size = new System .Drawing .Size(799 , 300);
            this .variantList .TabIndex = 0;
            this .variantList .SelectionChanged += new System .EventHandler(this .variantList_SelectionChanged);
            // 
            // groupBox3
            // 
            this .groupBox3 .Controls .Add(this .buttonPrint);
            this .groupBox3 .Controls .Add(this .buttonDelete);
            this .groupBox3 .Controls .Add(this .buttonImport);
            this .groupBox3 .Location = new System .Drawing .Point(11 , 404);
            this .groupBox3 .Name = "groupBox3";
            this .groupBox3 .Size = new System .Drawing .Size(807 , 66);
            this .groupBox3 .TabIndex = 2;
            this .groupBox3 .TabStop = false;
            this .groupBox3 .Text = "Действия";
            // 
            // buttonDelete
            // 
            this .buttonDelete .Location = new System .Drawing .Point(366 , 23);
            this .buttonDelete .Name = "buttonDelete";
            this .buttonDelete .Size = new System .Drawing .Size(156 , 32);
            this .buttonDelete .TabIndex = 1;
            this .buttonDelete .Text = "Удалить выделенные";
            this .buttonDelete .UseVisualStyleBackColor = true;
            this .buttonDelete .Click += new System .EventHandler(this .buttonDelete_Click);
            // 
            // buttonImport
            // 
            this .buttonImport .Location = new System .Drawing .Point(22 , 23);
            this .buttonImport .Name = "buttonImport";
            this .buttonImport .Size = new System .Drawing .Size(156 , 32);
            this .buttonImport .TabIndex = 0;
            this .buttonImport .Text = "Импорт";
            this .buttonImport .UseVisualStyleBackColor = true;
            this .buttonImport .Click += new System .EventHandler(this .buttonImport_Click);
            // 
            // buttonPrint
            // 
            this .buttonPrint .Location = new System .Drawing .Point(194 , 23);
            this .buttonPrint .Name = "buttonPrint";
            this .buttonPrint .Size = new System .Drawing .Size(156 , 32);
            this .buttonPrint .TabIndex = 2;
            this .buttonPrint .Text = "Напечатать выделенные";
            this .buttonPrint .UseVisualStyleBackColor = true;
            this .buttonPrint .Click += new System .EventHandler(this .buttonPrint_Click);
            // 
            // FormDSImportDelete
            // 
            this .AutoScaleDimensions = new System .Drawing .SizeF(6F , 13F);
            this .AutoScaleMode = System .Windows .Forms .AutoScaleMode .Font;
            this .ClientSize = new System .Drawing .Size(828 , 483);
            this .Controls .Add(this .groupBox3);
            this .Controls .Add(this .groupBox2);
            this .Controls .Add(this .groupBox1);
            this .FormBorderStyle = System .Windows .Forms .FormBorderStyle .FixedToolWindow;
            this .Name = "FormDSImportDelete";
            this .StartPosition = System .Windows .Forms .FormStartPosition .CenterParent;
            this .Text = "Импорт и удаление";
            this .Load += new System .EventHandler(this .FormDSExportDelete_Load);
            this .groupBox1 .ResumeLayout(false);
            this .groupBox2 .ResumeLayout(false);
            ((System .ComponentModel .ISupportInitialize)(this .variantList)) .EndInit();
            this .groupBox3 .ResumeLayout(false);
            this .ResumeLayout(false);

        }

        #endregion

        private System .Windows .Forms .GroupBox groupBox1;
        private System .Windows .Forms .ComboBox eduObjectList;
        private System .Windows .Forms .GroupBox groupBox2;
        private System .Windows .Forms .GroupBox groupBox3;
        private System .Windows .Forms .Button buttonDelete;
        private System .Windows .Forms .Button buttonImport;
        private System .Windows .Forms .DataGridView variantList;
        private System .Windows .Forms .Button buttonPrint;
    }
}