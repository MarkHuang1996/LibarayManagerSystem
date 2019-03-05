namespace LibraryManagerPro
{
    partial class FmBookManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmBookManager));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCloseVideo = new System.Windows.Forms.Button();
            this.btnChoseImage = new System.Windows.Forms.Button();
            this.btnTake = new System.Windows.Forms.Button();
            this.btnStartVideo = new System.Windows.Forms.Button();
            this.pbImage = new System.Windows.Forms.PictureBox();
            this.txt_BookPosition = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbo_BookCategory = new System.Windows.Forms.ComboBox();
            this.lbl_BarCode = new System.Windows.Forms.Label();
            this.lbl_BookCount = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbo_Publisher = new System.Windows.Forms.ComboBox();
            this.txt_UnitPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_Author = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dtp_PublishDate = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.pbCurrentImage = new System.Windows.Forms.PictureBox();
            this.lbl_BookId = new System.Windows.Forms.Label();
            this.gbBook = new System.Windows.Forms.GroupBox();
            this.txt_BookName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.cboCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvBookList = new System.Windows.Forms.DataGridView();
            this.BarCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublisherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Remainder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentImage)).BeginInit();
            this.gbBook.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(381, 127);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Publish：";
            // 
            // btnCloseVideo
            // 
            this.btnCloseVideo.Location = new System.Drawing.Point(163, 1031);
            this.btnCloseVideo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCloseVideo.Name = "btnCloseVideo";
            this.btnCloseVideo.Size = new System.Drawing.Size(116, 65);
            this.btnCloseVideo.TabIndex = 61;
            this.btnCloseVideo.Text = "CloseCam";
            this.btnCloseVideo.UseVisualStyleBackColor = true;
            // 
            // btnChoseImage
            // 
            this.btnChoseImage.Location = new System.Drawing.Point(423, 1031);
            this.btnChoseImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnChoseImage.Name = "btnChoseImage";
            this.btnChoseImage.Size = new System.Drawing.Size(116, 65);
            this.btnChoseImage.TabIndex = 57;
            this.btnChoseImage.Text = "ChoseImage";
            this.btnChoseImage.UseVisualStyleBackColor = true;
            // 
            // btnTake
            // 
            this.btnTake.Location = new System.Drawing.Point(293, 1031);
            this.btnTake.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTake.Name = "btnTake";
            this.btnTake.Size = new System.Drawing.Size(116, 65);
            this.btnTake.TabIndex = 56;
            this.btnTake.Text = "TakePhoto";
            this.btnTake.UseVisualStyleBackColor = true;
            // 
            // btnStartVideo
            // 
            this.btnStartVideo.Location = new System.Drawing.Point(31, 1031);
            this.btnStartVideo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStartVideo.Name = "btnStartVideo";
            this.btnStartVideo.Size = new System.Drawing.Size(116, 65);
            this.btnStartVideo.TabIndex = 55;
            this.btnStartVideo.Text = "StartCam";
            this.btnStartVideo.UseVisualStyleBackColor = true;
            // 
            // pbImage
            // 
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(31, 689);
            this.pbImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(298, 319);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 60;
            this.pbImage.TabStop = false;
            // 
            // txt_BookPosition
            // 
            this.txt_BookPosition.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_BookPosition.Location = new System.Drawing.Point(134, 263);
            this.txt_BookPosition.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_BookPosition.Name = "txt_BookPosition";
            this.txt_BookPosition.Size = new System.Drawing.Size(212, 26);
            this.txt_BookPosition.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(381, 267);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "BookCount：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 272);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Position：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 338);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 20);
            this.label7.TabIndex = 0;
            this.label7.Text = "BarCode：";
            // 
            // cbo_BookCategory
            // 
            this.cbo_BookCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_BookCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_BookCategory.FormattingEnabled = true;
            this.cbo_BookCategory.Location = new System.Drawing.Point(488, 50);
            this.cbo_BookCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbo_BookCategory.Name = "cbo_BookCategory";
            this.cbo_BookCategory.Size = new System.Drawing.Size(211, 28);
            this.cbo_BookCategory.TabIndex = 2;
            // 
            // lbl_BarCode
            // 
            this.lbl_BarCode.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_BarCode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_BarCode.Location = new System.Drawing.Point(134, 328);
            this.lbl_BarCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_BarCode.Name = "lbl_BarCode";
            this.lbl_BarCode.Size = new System.Drawing.Size(213, 40);
            this.lbl_BarCode.TabIndex = 0;
            this.lbl_BarCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_BookCount
            // 
            this.lbl_BookCount.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_BookCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_BookCount.Location = new System.Drawing.Point(488, 257);
            this.lbl_BookCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_BookCount.Name = "lbl_BookCount";
            this.lbl_BookCount.Size = new System.Drawing.Size(213, 40);
            this.lbl_BookCount.TabIndex = 0;
            this.lbl_BookCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(381, 338);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "图书编号：";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // cbo_Publisher
            // 
            this.cbo_Publisher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Publisher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbo_Publisher.FormattingEnabled = true;
            this.cbo_Publisher.Location = new System.Drawing.Point(135, 122);
            this.cbo_Publisher.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbo_Publisher.Name = "cbo_Publisher";
            this.cbo_Publisher.Size = new System.Drawing.Size(211, 28);
            this.cbo_Publisher.TabIndex = 3;
            // 
            // txt_UnitPrice
            // 
            this.txt_UnitPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_UnitPrice.Location = new System.Drawing.Point(488, 188);
            this.txt_UnitPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_UnitPrice.Name = "txt_UnitPrice";
            this.txt_UnitPrice.Size = new System.Drawing.Size(212, 26);
            this.txt_UnitPrice.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(381, 197);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Price：";
            // 
            // txt_Author
            // 
            this.txt_Author.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Author.Location = new System.Drawing.Point(134, 190);
            this.txt_Author.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Author.Name = "txt_Author";
            this.txt_Author.Size = new System.Drawing.Size(214, 26);
            this.txt_Author.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(46, 198);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "Author：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(381, 57);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "Category：";
            // 
            // dtp_PublishDate
            // 
            this.dtp_PublishDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_PublishDate.Location = new System.Drawing.Point(488, 118);
            this.dtp_PublishDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_PublishDate.Name = "dtp_PublishDate";
            this.dtp_PublishDate.Size = new System.Drawing.Size(211, 26);
            this.dtp_PublishDate.TabIndex = 4;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(46, 128);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(90, 20);
            this.label14.TabIndex = 0;
            this.label14.Text = "Publisher：";
            // 
            // pbCurrentImage
            // 
            this.pbCurrentImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbCurrentImage.Location = new System.Drawing.Point(383, 689);
            this.pbCurrentImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbCurrentImage.Name = "pbCurrentImage";
            this.pbCurrentImage.Size = new System.Drawing.Size(293, 319);
            this.pbCurrentImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbCurrentImage.TabIndex = 59;
            this.pbCurrentImage.TabStop = false;
            // 
            // lbl_BookId
            // 
            this.lbl_BookId.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_BookId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_BookId.Location = new System.Drawing.Point(488, 328);
            this.lbl_BookId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_BookId.Name = "lbl_BookId";
            this.lbl_BookId.Size = new System.Drawing.Size(213, 40);
            this.lbl_BookId.TabIndex = 0;
            this.lbl_BookId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbBook
            // 
            this.gbBook.Controls.Add(this.txt_BookName);
            this.gbBook.Controls.Add(this.label4);
            this.gbBook.Controls.Add(this.label5);
            this.gbBook.Controls.Add(this.txt_BookPosition);
            this.gbBook.Controls.Add(this.label6);
            this.gbBook.Controls.Add(this.label9);
            this.gbBook.Controls.Add(this.label7);
            this.gbBook.Controls.Add(this.cbo_BookCategory);
            this.gbBook.Controls.Add(this.lbl_BarCode);
            this.gbBook.Controls.Add(this.lbl_BookCount);
            this.gbBook.Controls.Add(this.lbl_BookId);
            this.gbBook.Controls.Add(this.label10);
            this.gbBook.Controls.Add(this.cbo_Publisher);
            this.gbBook.Controls.Add(this.txt_UnitPrice);
            this.gbBook.Controls.Add(this.label8);
            this.gbBook.Controls.Add(this.txt_Author);
            this.gbBook.Controls.Add(this.label12);
            this.gbBook.Controls.Add(this.label13);
            this.gbBook.Controls.Add(this.dtp_PublishDate);
            this.gbBook.Controls.Add(this.label14);
            this.gbBook.Location = new System.Drawing.Point(727, 689);
            this.gbBook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbBook.Name = "gbBook";
            this.gbBook.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbBook.Size = new System.Drawing.Size(748, 407);
            this.gbBook.TabIndex = 54;
            this.gbBook.TabStop = false;
            this.gbBook.Text = "[Book Info]";
            // 
            // txt_BookName
            // 
            this.txt_BookName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_BookName.Location = new System.Drawing.Point(135, 52);
            this.txt_BookName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_BookName.Name = "txt_BookName";
            this.txt_BookName.Size = new System.Drawing.Size(212, 26);
            this.txt_BookName.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 58);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "Name：";
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(554, 1031);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 65);
            this.btnSave.TabIndex = 58;
            this.btnSave.Text = "Save";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBookName);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtBarCode);
            this.groupBox2.Controls.Add(this.btnQuery);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.cboCategory);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(31, 32);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(1096, 118);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "[Search by Category]";
            // 
            // txtBookName
            // 
            this.txtBookName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBookName.Location = new System.Drawing.Point(705, 48);
            this.txtBookName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(206, 26);
            this.txtBookName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(610, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name：";
            // 
            // txtBarCode
            // 
            this.txtBarCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBarCode.Location = new System.Drawing.Point(405, 48);
            this.txtBarCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(188, 26);
            this.txtBarCode.TabIndex = 1;
            // 
            // btnQuery
            // 
            this.btnQuery.Image = ((System.Drawing.Image)(resources.GetObject("btnQuery.Image")));
            this.btnQuery.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnQuery.Location = new System.Drawing.Point(948, 35);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(126, 62);
            this.btnQuery.TabIndex = 2;
            this.btnQuery.Text = "Query";
            this.btnQuery.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnQuery.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(310, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "BarCode：";
            // 
            // cboCategory
            // 
            this.cboCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboCategory.FormattingEnabled = true;
            this.cboCategory.Location = new System.Drawing.Point(126, 50);
            this.cboCategory.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cboCategory.Name = "cboCategory";
            this.cboCategory.Size = new System.Drawing.Size(174, 28);
            this.cboCategory.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Category：";
            // 
            // dgvBookList
            // 
            this.dgvBookList.AllowUserToAddRows = false;
            this.dgvBookList.AllowUserToDeleteRows = false;
            this.dgvBookList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dgvBookList.ColumnHeadersHeight = 28;
            this.dgvBookList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BarCode,
            this.BookName,
            this.PublisherName,
            this.Author,
            this.BookCount,
            this.Remainder,
            this.BookPosition});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBookList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBookList.Location = new System.Drawing.Point(31, 176);
            this.dgvBookList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvBookList.Name = "dgvBookList";
            this.dgvBookList.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookList.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvBookList.RowTemplate.Height = 23;
            this.dgvBookList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookList.Size = new System.Drawing.Size(1444, 487);
            this.dgvBookList.TabIndex = 51;
            // 
            // BarCode
            // 
            this.BarCode.DataPropertyName = "BarCode";
            this.BarCode.Frozen = true;
            this.BarCode.HeaderText = "BarCode";
            this.BarCode.Name = "BarCode";
            this.BarCode.ReadOnly = true;
            this.BarCode.Width = 150;
            // 
            // BookName
            // 
            this.BookName.DataPropertyName = "BookName";
            this.BookName.HeaderText = "BookName";
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
            this.BookName.Width = 220;
            // 
            // PublisherName
            // 
            this.PublisherName.DataPropertyName = "PublisherName";
            this.PublisherName.HeaderText = "PublisherName";
            this.PublisherName.Name = "PublisherName";
            this.PublisherName.ReadOnly = true;
            this.PublisherName.Width = 150;
            // 
            // Author
            // 
            this.Author.DataPropertyName = "Author";
            this.Author.HeaderText = "Author";
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            // 
            // BookCount
            // 
            this.BookCount.DataPropertyName = "BookCount";
            this.BookCount.HeaderText = "BookCount";
            this.BookCount.Name = "BookCount";
            this.BookCount.ReadOnly = true;
            this.BookCount.Width = 80;
            // 
            // Remainder
            // 
            this.Remainder.DataPropertyName = "Remainder";
            this.Remainder.HeaderText = "Remainder";
            this.Remainder.Name = "Remainder";
            this.Remainder.ReadOnly = true;
            this.Remainder.Width = 80;
            // 
            // BookPosition
            // 
            this.BookPosition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookPosition.DataPropertyName = "BookPosition";
            this.BookPosition.HeaderText = "BookPosition";
            this.BookPosition.Name = "BookPosition";
            this.BookPosition.ReadOnly = true;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1355, 67);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(120, 65);
            this.btnClose.TabIndex = 53;
            this.btnClose.Text = "Close";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnDel
            // 
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.Location = new System.Drawing.Point(1161, 71);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(112, 62);
            this.btnDel.TabIndex = 50;
            this.btnDel.Text = "Delete";
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // FmBookManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1506, 1128);
            this.Controls.Add(this.btnCloseVideo);
            this.Controls.Add(this.btnChoseImage);
            this.Controls.Add(this.btnTake);
            this.Controls.Add(this.btnStartVideo);
            this.Controls.Add(this.pbImage);
            this.Controls.Add(this.pbCurrentImage);
            this.Controls.Add(this.gbBook);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvBookList);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDel);
            this.Name = "FmBookManager";
            this.Text = "FmBookManager";
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCurrentImage)).EndInit();
            this.gbBook.ResumeLayout(false);
            this.gbBook.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCloseVideo;
        private System.Windows.Forms.Button btnChoseImage;
        private System.Windows.Forms.Button btnTake;
        private System.Windows.Forms.Button btnStartVideo;
        private System.Windows.Forms.PictureBox pbImage;
        private System.Windows.Forms.TextBox txt_BookPosition;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbo_BookCategory;
        private System.Windows.Forms.Label lbl_BarCode;
        private System.Windows.Forms.Label lbl_BookCount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbo_Publisher;
        private System.Windows.Forms.TextBox txt_UnitPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_Author;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtp_PublishDate;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox pbCurrentImage;
        private System.Windows.Forms.Label lbl_BookId;
        private System.Windows.Forms.GroupBox gbBook;
        private System.Windows.Forms.TextBox txt_BookName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvBookList;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublisherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Remainder;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookPosition;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnDel;
    }
}