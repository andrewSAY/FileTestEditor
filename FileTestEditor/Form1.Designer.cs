namespace FileTestEditor {
    partial class FormMain {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System .ComponentModel .IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components .Dispose();
            }
            base .Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent() {
            System .ComponentModel .ComponentResourceManager resources = new System .ComponentModel .ComponentResourceManager(typeof(FormMain));
            this .panelRight = new System .Windows .Forms .Panel();
            this .groupBox2 = new System .Windows .Forms .GroupBox();
            this .buttonQstEdit = new System .Windows .Forms .Button();
            this .buttonQstDel = new System .Windows .Forms .Button();
            this .panelLeft = new System .Windows .Forms .Panel();
            this .groupBox1 = new System .Windows .Forms .GroupBox();
            this .buttonOpenImg = new System .Windows .Forms .Button();
            this .buttonDelAll = new System .Windows .Forms .Button();
            this .buttonScanMulti = new System .Windows .Forms .Button();
            this .buttonDelSelected = new System .Windows .Forms .Button();
            this .buttonScan = new System .Windows .Forms .Button();
            this .panelMiddle = new System .Windows .Forms .Panel();
            this .menuStrip1 = new System .Windows .Forms .MenuStrip();
            this .файлToolStripMenuItem = new System .Windows .Forms .ToolStripMenuItem();
            this .выходToolStripMenuItem = new System .Windows .Forms .ToolStripMenuItem();
            this .вариантToolStripMenuItem = new System .Windows .Forms .ToolStripMenuItem();
            this .новыйВариантToolStripMenuItem = new System .Windows .Forms .ToolStripMenuItem();
            this .открытьToolStripMenuItem = new System .Windows .Forms .ToolStripMenuItem();
            this .сохранитьToolStripMenuItem1 = new System .Windows .Forms .ToolStripMenuItem();
            this .закрытьToolStripMenuItem = new System .Windows .Forms .ToolStripMenuItem();
            this .сервисToolStripMenuItem = new System .Windows .Forms .ToolStripMenuItem();
            this .настройкиToolStripMenuItem = new System .Windows .Forms .ToolStripMenuItem();
            this .panelTop = new System .Windows .Forms .Panel();
            this .openFileDialog1 = new System .Windows .Forms .OpenFileDialog();
            this .openFileDialog2 = new System .Windows .Forms .OpenFileDialog();
            this .работаСИсточникомДанныхToolStripMenuItem = new System .Windows .Forms .ToolStripMenuItem();
            this .импортИУдалениеToolStripMenuItem = new System .Windows .Forms .ToolStripMenuItem();
            this .экспортироватьТекущийВариантToolStripMenuItem = new System .Windows .Forms .ToolStripMenuItem();
            this .массовыйЭкспортToolStripMenuItem = new System .Windows .Forms .ToolStripMenuItem();
            this .установитьСоединениеToolStripMenuItem = new System .Windows .Forms .ToolStripMenuItem();
            this .закрытьСоединениеToolStripMenuItem = new System .Windows .Forms .ToolStripMenuItem();
            this .pictureBox1 = new FileTestEditor .ExpansionControllers .PaintPictureBox();
            this .listBoxImg = new FileTestEditor .ExpansionControllers .ScrollingListBox();
            this .listBoxQst = new FileTestEditor .ExpansionControllers .ScrollingListBox();
            this .panelRight .SuspendLayout();
            this .groupBox2 .SuspendLayout();
            this .panelLeft .SuspendLayout();
            this .groupBox1 .SuspendLayout();
            this .panelMiddle .SuspendLayout();
            this .menuStrip1 .SuspendLayout();
            this .panelTop .SuspendLayout();
            ((System .ComponentModel .ISupportInitialize)(this .pictureBox1)) .BeginInit();
            this .SuspendLayout();
            // 
            // panelRight
            // 
            this .panelRight .Controls .Add(this .listBoxQst);
            this .panelRight .Controls .Add(this .groupBox2);
            this .panelRight .Dock = System .Windows .Forms .DockStyle .Right;
            this .panelRight .Location = new System .Drawing .Point(1045 , 37);
            this .panelRight .Name = "panelRight";
            this .panelRight .Size = new System .Drawing .Size(204 , 601);
            this .panelRight .TabIndex = 1;
            // 
            // groupBox2
            // 
            this .groupBox2 .Controls .Add(this .buttonQstEdit);
            this .groupBox2 .Controls .Add(this .buttonQstDel);
            this .groupBox2 .Dock = System .Windows .Forms .DockStyle .Top;
            this .groupBox2 .Location = new System .Drawing .Point(0 , 0);
            this .groupBox2 .Name = "groupBox2";
            this .groupBox2 .Size = new System .Drawing .Size(204 , 85);
            this .groupBox2 .TabIndex = 3;
            this .groupBox2 .TabStop = false;
            this .groupBox2 .Text = "Задания";
            // 
            // buttonQstEdit
            // 
            this .buttonQstEdit .Location = new System .Drawing .Point(3 , 20);
            this .buttonQstEdit .Name = "buttonQstEdit";
            this .buttonQstEdit .Size = new System .Drawing .Size(195 , 23);
            this .buttonQstEdit .TabIndex = 4;
            this .buttonQstEdit .Text = "Редактировать";
            this .buttonQstEdit .UseVisualStyleBackColor = true;
            this .buttonQstEdit .Click += new System .EventHandler(this .buttonQstEdit_Click);
            // 
            // buttonQstDel
            // 
            this .buttonQstDel .Location = new System .Drawing .Point(3 , 55);
            this .buttonQstDel .Name = "buttonQstDel";
            this .buttonQstDel .Size = new System .Drawing .Size(195 , 23);
            this .buttonQstDel .TabIndex = 3;
            this .buttonQstDel .Text = "Удалить";
            this .buttonQstDel .UseVisualStyleBackColor = true;
            this .buttonQstDel .Click += new System .EventHandler(this .buttonQstDel_Click);
            // 
            // panelLeft
            // 
            this .panelLeft .Controls .Add(this .listBoxImg);
            this .panelLeft .Controls .Add(this .groupBox1);
            this .panelLeft .Dock = System .Windows .Forms .DockStyle .Left;
            this .panelLeft .Location = new System .Drawing .Point(0 , 37);
            this .panelLeft .Name = "panelLeft";
            this .panelLeft .Size = new System .Drawing .Size(233 , 601);
            this .panelLeft .TabIndex = 2;
            // 
            // groupBox1
            // 
            this .groupBox1 .Controls .Add(this .buttonOpenImg);
            this .groupBox1 .Controls .Add(this .buttonDelAll);
            this .groupBox1 .Controls .Add(this .buttonScanMulti);
            this .groupBox1 .Controls .Add(this .buttonDelSelected);
            this .groupBox1 .Controls .Add(this .buttonScan);
            this .groupBox1 .Dock = System .Windows .Forms .DockStyle .Top;
            this .groupBox1 .Location = new System .Drawing .Point(0 , 0);
            this .groupBox1 .Name = "groupBox1";
            this .groupBox1 .Size = new System .Drawing .Size(233 , 192);
            this .groupBox1 .TabIndex = 0;
            this .groupBox1 .TabStop = false;
            this .groupBox1 .Text = "Отсканированные изображения";
            // 
            // buttonOpenImg
            // 
            this .buttonOpenImg .Location = new System .Drawing .Point(7 , 78);
            this .buttonOpenImg .Name = "buttonOpenImg";
            this .buttonOpenImg .Size = new System .Drawing .Size(220 , 23);
            this .buttonOpenImg .TabIndex = 4;
            this .buttonOpenImg .Text = "Открыть";
            this .buttonOpenImg .UseVisualStyleBackColor = true;
            this .buttonOpenImg .Click += new System .EventHandler(this .buttonOpenImg_Click);
            // 
            // buttonDelAll
            // 
            this .buttonDelAll .Location = new System .Drawing .Point(7 , 158);
            this .buttonDelAll .Name = "buttonDelAll";
            this .buttonDelAll .Size = new System .Drawing .Size(220 , 23);
            this .buttonDelAll .TabIndex = 3;
            this .buttonDelAll .Text = "Удалить все";
            this .buttonDelAll .UseVisualStyleBackColor = true;
            this .buttonDelAll .Click += new System .EventHandler(this .buttonDelAll_Click);
            // 
            // buttonScanMulti
            // 
            this .buttonScanMulti .Location = new System .Drawing .Point(7 , 20);
            this .buttonScanMulti .Name = "buttonScanMulti";
            this .buttonScanMulti .Size = new System .Drawing .Size(220 , 23);
            this .buttonScanMulti .TabIndex = 2;
            this .buttonScanMulti .Text = "Сканировать один лист";
            this .buttonScanMulti .UseVisualStyleBackColor = true;
            this .buttonScanMulti .Click += new System .EventHandler(this .buttonScanMulti_Click);
            // 
            // buttonDelSelected
            // 
            this .buttonDelSelected .Location = new System .Drawing .Point(6 , 129);
            this .buttonDelSelected .Name = "buttonDelSelected";
            this .buttonDelSelected .Size = new System .Drawing .Size(220 , 23);
            this .buttonDelSelected .TabIndex = 1;
            this .buttonDelSelected .Text = "Удалить";
            this .buttonDelSelected .UseVisualStyleBackColor = true;
            this .buttonDelSelected .Click += new System .EventHandler(this .buttonDelSelected_Click);
            // 
            // buttonScan
            // 
            this .buttonScan .Location = new System .Drawing .Point(7 , 49);
            this .buttonScan .Name = "buttonScan";
            this .buttonScan .Size = new System .Drawing .Size(220 , 23);
            this .buttonScan .TabIndex = 0;
            this .buttonScan .Text = "Сканировать";
            this .buttonScan .UseVisualStyleBackColor = true;
            this .buttonScan .Click += new System .EventHandler(this .buttonScan_Click);
            // 
            // panelMiddle
            // 
            this .panelMiddle .BackColor = System .Drawing .SystemColors .GrayText;
            this .panelMiddle .Controls .Add(this .pictureBox1);
            this .panelMiddle .Dock = System .Windows .Forms .DockStyle .Fill;
            this .panelMiddle .Location = new System .Drawing .Point(233 , 37);
            this .panelMiddle .Name = "panelMiddle";
            this .panelMiddle .Size = new System .Drawing .Size(812 , 601);
            this .panelMiddle .TabIndex = 3;
            // 
            // menuStrip1
            // 
            this .menuStrip1 .Items .AddRange(new System .Windows .Forms .ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.вариантToolStripMenuItem,
            this.сервисToolStripMenuItem,
            this.работаСИсточникомДанныхToolStripMenuItem});
            this .menuStrip1 .Location = new System .Drawing .Point(0 , 0);
            this .menuStrip1 .Name = "menuStrip1";
            this .menuStrip1 .Size = new System .Drawing .Size(1249 , 24);
            this .menuStrip1 .TabIndex = 0;
            this .menuStrip1 .Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this .файлToolStripMenuItem .DropDownItems .AddRange(new System .Windows .Forms .ToolStripItem[] {
            this.выходToolStripMenuItem});
            this .файлToolStripMenuItem .Name = "файлToolStripMenuItem";
            this .файлToolStripMenuItem .Size = new System .Drawing .Size(48 , 20);
            this .файлToolStripMenuItem .Text = "Файл";
            // 
            // выходToolStripMenuItem
            // 
            this .выходToolStripMenuItem .Name = "выходToolStripMenuItem";
            this .выходToolStripMenuItem .Size = new System .Drawing .Size(108 , 22);
            this .выходToolStripMenuItem .Text = "Выход";
            this .выходToolStripMenuItem .Click += new System .EventHandler(this .выходToolStripMenuItem_Click);
            // 
            // вариантToolStripMenuItem
            // 
            this .вариантToolStripMenuItem .DropDownItems .AddRange(new System .Windows .Forms .ToolStripItem[] {
            this.новыйВариантToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.сохранитьToolStripMenuItem1,
            this.закрытьToolStripMenuItem});
            this .вариантToolStripMenuItem .Name = "вариантToolStripMenuItem";
            this .вариантToolStripMenuItem .Size = new System .Drawing .Size(64 , 20);
            this .вариантToolStripMenuItem .Text = "Вариант";
            // 
            // новыйВариантToolStripMenuItem
            // 
            this .новыйВариантToolStripMenuItem .Name = "новыйВариантToolStripMenuItem";
            this .новыйВариантToolStripMenuItem .Size = new System .Drawing .Size(159 , 22);
            this .новыйВариантToolStripMenuItem .Text = "Новый вариант";
            this .новыйВариантToolStripMenuItem .Click += new System .EventHandler(this .новыйВариантToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this .открытьToolStripMenuItem .Name = "открытьToolStripMenuItem";
            this .открытьToolStripMenuItem .Size = new System .Drawing .Size(159 , 22);
            this .открытьToolStripMenuItem .Text = "Открыть";
            this .открытьToolStripMenuItem .Click += new System .EventHandler(this .открытьToolStripMenuItem_Click);
            // 
            // сохранитьToolStripMenuItem1
            // 
            this .сохранитьToolStripMenuItem1 .Name = "сохранитьToolStripMenuItem1";
            this .сохранитьToolStripMenuItem1 .Size = new System .Drawing .Size(159 , 22);
            this .сохранитьToolStripMenuItem1 .Text = "Сохранить";
            this .сохранитьToolStripMenuItem1 .Click += new System .EventHandler(this .сохранитьToolStripMenuItem1_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this .закрытьToolStripMenuItem .Name = "закрытьToolStripMenuItem";
            this .закрытьToolStripMenuItem .Size = new System .Drawing .Size(159 , 22);
            this .закрытьToolStripMenuItem .Text = "Закрыть";
            this .закрытьToolStripMenuItem .Click += new System .EventHandler(this .закрытьToolStripMenuItem_Click);
            // 
            // сервисToolStripMenuItem
            // 
            this .сервисToolStripMenuItem .DropDownItems .AddRange(new System .Windows .Forms .ToolStripItem[] {
            this.настройкиToolStripMenuItem});
            this .сервисToolStripMenuItem .Name = "сервисToolStripMenuItem";
            this .сервисToolStripMenuItem .Size = new System .Drawing .Size(59 , 20);
            this .сервисToolStripMenuItem .Text = "Сервис";
            // 
            // настройкиToolStripMenuItem
            // 
            this .настройкиToolStripMenuItem .Name = "настройкиToolStripMenuItem";
            this .настройкиToolStripMenuItem .Size = new System .Drawing .Size(134 , 22);
            this .настройкиToolStripMenuItem .Text = "Настройки";
            this .настройкиToolStripMenuItem .Click += new System .EventHandler(this .настройкиToolStripMenuItem_Click);
            // 
            // panelTop
            // 
            this .panelTop .Controls .Add(this .menuStrip1);
            this .panelTop .Dock = System .Windows .Forms .DockStyle .Top;
            this .panelTop .Location = new System .Drawing .Point(0 , 0);
            this .panelTop .Name = "panelTop";
            this .panelTop .Size = new System .Drawing .Size(1249 , 37);
            this .panelTop .TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this .openFileDialog1 .FileName = "openFileDialog1";
            this .openFileDialog1 .Filter = "Фалы вариантов|*.variant";
            // 
            // openFileDialog2
            // 
            this .openFileDialog2 .Filter = "Jpeg|*.jp*g|Bitmap|*.bmp|TIFF|*.tif|PNG|*.png";
            this .openFileDialog2 .Multiselect = true;
            // 
            // работаСИсточникомДанныхToolStripMenuItem
            // 
            this .работаСИсточникомДанныхToolStripMenuItem .DropDownItems .AddRange(new System .Windows .Forms .ToolStripItem[] {
            this.установитьСоединениеToolStripMenuItem,
            this.импортИУдалениеToolStripMenuItem,
            this.экспортироватьТекущийВариантToolStripMenuItem,
            this.массовыйЭкспортToolStripMenuItem,
            this.закрытьСоединениеToolStripMenuItem});
            this .работаСИсточникомДанныхToolStripMenuItem .Name = "работаСИсточникомДанныхToolStripMenuItem";
            this .работаСИсточникомДанныхToolStripMenuItem .Size = new System .Drawing .Size(180 , 20);
            this .работаСИсточникомДанныхToolStripMenuItem .Text = "Работа с источником данных";
            // 
            // импортИУдалениеToolStripMenuItem
            // 
            this .импортИУдалениеToolStripMenuItem .Name = "импортИУдалениеToolStripMenuItem";
            this .импортИУдалениеToolStripMenuItem .Size = new System .Drawing .Size(261 , 22);
            this .импортИУдалениеToolStripMenuItem .Text = "Импорт и удаление";
            this .импортИУдалениеToolStripMenuItem .Click += new System .EventHandler(this .импортИУдалениеToolStripMenuItem_Click);
            // 
            // экспортироватьТекущийВариантToolStripMenuItem
            // 
            this .экспортироватьТекущийВариантToolStripMenuItem .Name = "экспортироватьТекущийВариантToolStripMenuItem";
            this .экспортироватьТекущийВариантToolStripMenuItem .Size = new System .Drawing .Size(261 , 22);
            this .экспортироватьТекущийВариантToolStripMenuItem .Text = "Экспортировать текущий вариант";
            this .экспортироватьТекущийВариантToolStripMenuItem .Click += new System .EventHandler(this .экспортироватьТекущийВариантToolStripMenuItem_Click);
            // 
            // массовыйЭкспортToolStripMenuItem
            // 
            this .массовыйЭкспортToolStripMenuItem .Name = "массовыйЭкспортToolStripMenuItem";
            this .массовыйЭкспортToolStripMenuItem .Size = new System .Drawing .Size(261 , 22);
            this .массовыйЭкспортToolStripMenuItem .Text = "Массовый экспорт";
            // 
            // установитьСоединениеToolStripMenuItem
            // 
            this .установитьСоединениеToolStripMenuItem .Name = "установитьСоединениеToolStripMenuItem";
            this .установитьСоединениеToolStripMenuItem .Size = new System .Drawing .Size(261 , 22);
            this .установитьСоединениеToolStripMenuItem .Text = "Установить соединение";
            this .установитьСоединениеToolStripMenuItem .Click += new System .EventHandler(this .установитьСоединениеToolStripMenuItem_Click);
            // 
            // закрытьСоединениеToolStripMenuItem
            // 
            this .закрытьСоединениеToolStripMenuItem .Name = "закрытьСоединениеToolStripMenuItem";
            this .закрытьСоединениеToolStripMenuItem .Size = new System .Drawing .Size(261 , 22);
            this .закрытьСоединениеToolStripMenuItem .Text = "Закрыть соединение";
            this .закрытьСоединениеToolStripMenuItem .Click += new System .EventHandler(this .закрытьСоединениеToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this .pictureBox1 .Dock = System .Windows .Forms .DockStyle .Fill;
            this .pictureBox1 .Location = new System .Drawing .Point(0 , 0);
            this .pictureBox1 .Name = "pictureBox1";
            this .pictureBox1 .Size = new System .Drawing .Size(812 , 601);
            this .pictureBox1 .SizeMode = System .Windows .Forms .PictureBoxSizeMode .Zoom;
            this .pictureBox1 .TabIndex = 0;
            this .pictureBox1 .TabStop = false;
            // 
            // listBoxImg
            // 
            this .listBoxImg .Dock = System .Windows .Forms .DockStyle .Fill;
            this .listBoxImg .FormattingEnabled = true;
            this .listBoxImg .Location = new System .Drawing .Point(0 , 192);
            this .listBoxImg .Name = "listBoxImg";
            this .listBoxImg .Size = new System .Drawing .Size(233 , 409);
            this .listBoxImg .TabIndex = 1;
            this .listBoxImg .SelectedIndexChanged += new System .EventHandler(this .listBoxImg_SelectedIndexChanged);
            // 
            // listBoxQst
            // 
            this .listBoxQst .Dock = System .Windows .Forms .DockStyle .Fill;
            this .listBoxQst .FormattingEnabled = true;
            this .listBoxQst .Location = new System .Drawing .Point(0 , 85);
            this .listBoxQst .Name = "listBoxQst";
            this .listBoxQst .Size = new System .Drawing .Size(204 , 516);
            this .listBoxQst .TabIndex = 4;
            this .listBoxQst .SelectedIndexChanged += new System .EventHandler(this .listBoxQst_SelectedIndexChanged);
            this .listBoxQst .MouseDoubleClick += new System .Windows .Forms .MouseEventHandler(this .listBoxQst_MouseDoubleClick);
            // 
            // FormMain
            // 
            this .AutoScaleDimensions = new System .Drawing .SizeF(6F , 13F);
            this .AutoScaleMode = System .Windows .Forms .AutoScaleMode .Font;
            this .ClientSize = new System .Drawing .Size(1249 , 638);
            this .Controls .Add(this .panelMiddle);
            this .Controls .Add(this .panelLeft);
            this .Controls .Add(this .panelRight);
            this .Controls .Add(this .panelTop);
            this .Icon = ((System .Drawing .Icon)(resources .GetObject("$this.Icon")));
            this .MainMenuStrip = this .menuStrip1;
            this .Name = "FormMain";
            this .Text = "Редактор  вариантов по материалам ФИПИ";
            this .WindowState = System .Windows .Forms .FormWindowState .Maximized;
            this .FormClosing += new System .Windows .Forms .FormClosingEventHandler(this .FormMain_FormClosing);
            this .Load += new System .EventHandler(this .FormMain_Load);
            this .panelRight .ResumeLayout(false);
            this .groupBox2 .ResumeLayout(false);
            this .panelLeft .ResumeLayout(false);
            this .groupBox1 .ResumeLayout(false);
            this .panelMiddle .ResumeLayout(false);
            this .menuStrip1 .ResumeLayout(false);
            this .menuStrip1 .PerformLayout();
            this .panelTop .ResumeLayout(false);
            this .panelTop .PerformLayout();
            ((System .ComponentModel .ISupportInitialize)(this .pictureBox1)) .EndInit();
            this .ResumeLayout(false);

        }

        #endregion

        private System .Windows .Forms .Panel panelRight;
        private System .Windows .Forms .Panel panelLeft;
        private System .Windows .Forms .Panel panelMiddle;
        private ExpansionControllers.ScrollingListBox listBoxImg;
        private System .Windows .Forms .GroupBox groupBox1;
        private System .Windows .Forms .Button buttonScan;
        private System .Windows .Forms .Button buttonDelSelected;
        private System .Windows .Forms .MenuStrip menuStrip1;
        private System .Windows .Forms .ToolStripMenuItem файлToolStripMenuItem;
        private System .Windows .Forms .ToolStripMenuItem выходToolStripMenuItem;
        private System .Windows .Forms .ToolStripMenuItem вариантToolStripMenuItem;
        private System .Windows .Forms .ToolStripMenuItem новыйВариантToolStripMenuItem;
        private System .Windows .Forms .ToolStripMenuItem открытьToolStripMenuItem;
        private System .Windows .Forms .ToolStripMenuItem сервисToolStripMenuItem;
        private System .Windows .Forms .Panel panelTop;
        private System .Windows .Forms .ToolStripMenuItem настройкиToolStripMenuItem;
        private ExpansionControllers .PaintPictureBox pictureBox1;
        private ExpansionControllers .ScrollingListBox listBoxQst;
        private System .Windows .Forms .GroupBox groupBox2;
        private System .Windows .Forms .Button buttonQstDel;
        private System .Windows .Forms .OpenFileDialog openFileDialog1;
        private System .Windows .Forms .Button buttonQstEdit;
        private System .Windows .Forms .Button buttonScanMulti;
        private System .Windows .Forms .Button buttonDelAll;
        private System .Windows .Forms .Button buttonOpenImg;
        private System .Windows .Forms .OpenFileDialog openFileDialog2;
        private System .Windows .Forms .ToolStripMenuItem сохранитьToolStripMenuItem1;
        private System .Windows .Forms .ToolStripMenuItem закрытьToolStripMenuItem;
        private System .Windows .Forms .ToolStripMenuItem работаСИсточникомДанныхToolStripMenuItem;
        private System .Windows .Forms .ToolStripMenuItem установитьСоединениеToolStripMenuItem;
        private System .Windows .Forms .ToolStripMenuItem импортИУдалениеToolStripMenuItem;
        private System .Windows .Forms .ToolStripMenuItem экспортироватьТекущийВариантToolStripMenuItem;
        private System .Windows .Forms .ToolStripMenuItem массовыйЭкспортToolStripMenuItem;
        private System .Windows .Forms .ToolStripMenuItem закрытьСоединениеToolStripMenuItem;
    }
}

