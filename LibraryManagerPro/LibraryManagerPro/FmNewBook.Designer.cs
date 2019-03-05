﻿namespace LibraryManagerPro
{
    partial class FmNewBook
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmNewBook));
            this.BookPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PublisherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBookList = new System.Windows.Forms.DataGridView();
            this.BookCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblBookCount = new System.Windows.Forms.Label();
            this.lblBookName = new System.Windows.Forms.Label();
            this.lblBookId = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtAddCount = new System.Windows.Forms.TextBox();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblBookPosition = new System.Windows.Forms.Label();
            this.gbinfo = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pbImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).BeginInit();
            this.gbinfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).BeginInit();
            this.SuspendLayout();
            // 
            // BookPosition
            // 
            this.BookPosition.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookPosition.DataPropertyName = "BookPosition";
            this.BookPosition.HeaderText = "BookPosition";
            this.BookPosition.Name = "BookPosition";
            this.BookPosition.ReadOnly = true;
            // 
            // Author
            // 
            this.Author.DataPropertyName = "Author";
            this.Author.HeaderText = "Author";
            this.Author.Name = "Author";
            this.Author.ReadOnly = true;
            this.Author.Width = 150;
            // 
            // PublisherName
            // 
            this.PublisherName.DataPropertyName = "PublisherName";
            this.PublisherName.HeaderText = "PublisherName";
            this.PublisherName.Name = "PublisherName";
            this.PublisherName.ReadOnly = true;
            this.PublisherName.Width = 150;
            // 
            // BookName
            // 
            this.BookName.DataPropertyName = "BookName";
            this.BookName.HeaderText = "BookName";
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
            this.BookName.Width = 200;
            // 
            // BarCode
            // 
            this.BarCode.DataPropertyName = "BarCode";
            this.BarCode.Frozen = true;
            this.BarCode.HeaderText = "BarCode";
            this.BarCode.Name = "BarCode";
            this.BarCode.ReadOnly = true;
            this.BarCode.Width = 120;
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
            this.BookPosition});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBookList.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvBookList.Location = new System.Drawing.Point(33, 544);
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
            this.dgvBookList.Size = new System.Drawing.Size(1436, 548);
            this.dgvBookList.TabIndex = 47;
            // 
            // BookCount
            // 
            this.BookCount.DataPropertyName = "BookCount";
            this.BookCount.HeaderText = "BookCount";
            this.BookCount.Name = "BookCount";
            this.BookCount.ReadOnly = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(30, 220);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "BookId：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(382, 58);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Category：";
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(1333, 51);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(136, 65);
            this.btnClose.TabIndex = 42;
            this.btnClose.Text = "Close ";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // lblBookCount
            // 
            this.lblBookCount.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBookCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBookCount.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBookCount.Location = new System.Drawing.Point(136, 122);
            this.lblBookCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookCount.Name = "lblBookCount";
            this.lblBookCount.Size = new System.Drawing.Size(213, 40);
            this.lblBookCount.TabIndex = 0;
            this.lblBookCount.Text = "0";
            this.lblBookCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBookName
            // 
            this.lblBookName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBookName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBookName.Location = new System.Drawing.Point(136, 52);
            this.lblBookName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(213, 40);
            this.lblBookName.TabIndex = 0;
            this.lblBookName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBookId
            // 
            this.lblBookId.BackColor = System.Drawing.SystemColors.Control;
            this.lblBookId.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBookId.Location = new System.Drawing.Point(136, 210);
            this.lblBookId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(213, 40);
            this.lblBookId.TabIndex = 0;
            this.lblBookId.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(1303, 406);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(166, 62);
            this.btnSave.TabIndex = 41;
            this.btnSave.Text = "Save  ";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(939, 414);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 39);
            this.label4.TabIndex = 45;
            this.label4.Text = "[AddCount]：";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label13.Location = new System.Drawing.Point(422, 414);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(189, 39);
            this.label13.TabIndex = 46;
            this.label13.Text = "[BarCode]：";
            // 
            // txtAddCount
            // 
            this.txtAddCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAddCount.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtAddCount.Location = new System.Drawing.Point(1159, 409);
            this.txtAddCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddCount.Name = "txtAddCount";
            this.txtAddCount.Size = new System.Drawing.Size(104, 49);
            this.txtAddCount.TabIndex = 40;
            // 
            // txtBarCode
            // 
            this.txtBarCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBarCode.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBarCode.Location = new System.Drawing.Point(614, 409);
            this.txtBarCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(298, 49);
            this.txtBarCode.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 60);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Name：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 132);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Total：";
            // 
            // lblCategory
            // 
            this.lblCategory.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblCategory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblCategory.Location = new System.Drawing.Point(489, 48);
            this.lblCategory.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(213, 40);
            this.lblCategory.TabIndex = 0;
            this.lblCategory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblBookPosition
            // 
            this.lblBookPosition.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblBookPosition.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBookPosition.Location = new System.Drawing.Point(489, 122);
            this.lblBookPosition.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBookPosition.Name = "lblBookPosition";
            this.lblBookPosition.Size = new System.Drawing.Size(213, 40);
            this.lblBookPosition.TabIndex = 0;
            this.lblBookPosition.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbinfo
            // 
            this.gbinfo.Controls.Add(this.label1);
            this.gbinfo.Controls.Add(this.label6);
            this.gbinfo.Controls.Add(this.lblCategory);
            this.gbinfo.Controls.Add(this.lblBookPosition);
            this.gbinfo.Controls.Add(this.lblBookCount);
            this.gbinfo.Controls.Add(this.lblBookName);
            this.gbinfo.Controls.Add(this.lblBookId);
            this.gbinfo.Controls.Add(this.label9);
            this.gbinfo.Controls.Add(this.label10);
            this.gbinfo.Controls.Add(this.label2);
            this.gbinfo.Location = new System.Drawing.Point(493, 37);
            this.gbinfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbinfo.Name = "gbinfo";
            this.gbinfo.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gbinfo.Size = new System.Drawing.Size(771, 287);
            this.gbinfo.TabIndex = 43;
            this.gbinfo.TabStop = false;
            this.gbinfo.Text = "[BookInfo]";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(382, 132);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 20);
            this.label9.TabIndex = 0;
            this.label9.Text = "Position：";
            // 
            // pbImage
            // 
            this.pbImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbImage.Location = new System.Drawing.Point(33, 37);
            this.pbImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbImage.Name = "pbImage";
            this.pbImage.Size = new System.Drawing.Size(372, 429);
            this.pbImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImage.TabIndex = 44;
            this.pbImage.TabStop = false;
            // 
            // FmNewBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1502, 1128);
            this.Controls.Add(this.dgvBookList);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtAddCount);
            this.Controls.Add(this.txtBarCode);
            this.Controls.Add(this.gbinfo);
            this.Controls.Add(this.pbImage);
            this.Name = "FmNewBook";
            this.Text = "FmNewBook";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).EndInit();
            this.gbinfo.ResumeLayout(false);
            this.gbinfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn BookPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn Author;
        private System.Windows.Forms.DataGridViewTextBoxColumn PublisherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarCode;
        private System.Windows.Forms.DataGridView dgvBookList;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookCount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblBookCount;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtAddCount;
        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblBookPosition;
        private System.Windows.Forms.GroupBox gbinfo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pbImage;
    }
}