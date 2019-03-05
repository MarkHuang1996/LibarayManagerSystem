﻿namespace LibraryManagerPro
{
    partial class FmBorrowBook
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmBorrowBook));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBarCode = new System.Windows.Forms.TextBox();
            this.Expire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRoleName = new System.Windows.Forms.Label();
            this.BorrowCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BarCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvBookList = new System.Windows.Forms.DataGridView();
            this.lbl_Remainder = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBorrowCount = new System.Windows.Forms.Label();
            this.txtReadingCard = new System.Windows.Forms.TextBox();
            this.lblAllowCounts = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblReaderName = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbReaderImage = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReaderImage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDel
            // 
            this.btnDel.Image = ((System.Drawing.Image)(resources.GetObject("btnDel.Image")));
            this.btnDel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDel.Location = new System.Drawing.Point(814, 269);
            this.btnDel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(108, 65);
            this.btnDel.TabIndex = 32;
            this.btnDel.Text = "Delete";
            this.btnDel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDel.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(942, 269);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(134, 65);
            this.btnClose.TabIndex = 33;
            this.btnClose.Text = "Close ";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(616, 270);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(177, 62);
            this.btnSave.TabIndex = 30;
            this.btnSave.Text = "Save ";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft YaHei", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label12.Location = new System.Drawing.Point(36, 279);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(189, 39);
            this.label12.TabIndex = 31;
            this.label12.Text = "[BarCode]：";
            // 
            // txtBarCode
            // 
            this.txtBarCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBarCode.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtBarCode.Location = new System.Drawing.Point(234, 272);
            this.txtBarCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtBarCode.Name = "txtBarCode";
            this.txtBarCode.Size = new System.Drawing.Size(372, 49);
            this.txtBarCode.TabIndex = 29;
            // 
            // Expire
            // 
            this.Expire.DataPropertyName = "Expire";
            this.Expire.HeaderText = "Expire";
            this.Expire.Name = "Expire";
            this.Expire.ReadOnly = true;
            this.Expire.Width = 180;
            // 
            // lblRoleName
            // 
            this.lblRoleName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblRoleName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblRoleName.Location = new System.Drawing.Point(819, 43);
            this.lblRoleName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoleName.Name = "lblRoleName";
            this.lblRoleName.Size = new System.Drawing.Size(164, 40);
            this.lblRoleName.TabIndex = 4;
            this.lblRoleName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BorrowCount
            // 
            this.BorrowCount.DataPropertyName = "BorrowCount";
            this.BorrowCount.HeaderText = "BorrowCount";
            this.BorrowCount.Name = "BorrowCount";
            this.BorrowCount.ReadOnly = true;
            this.BorrowCount.Width = 120;
            // 
            // BookName
            // 
            this.BookName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookName.DataPropertyName = "BookName";
            this.BookName.HeaderText = "BookName";
            this.BookName.Name = "BookName";
            this.BookName.ReadOnly = true;
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
            // dgvBookList
            // 
            this.dgvBookList.AllowUserToAddRows = false;
            this.dgvBookList.AllowUserToDeleteRows = false;
            this.dgvBookList.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvBookList.ColumnHeadersHeight = 35;
            this.dgvBookList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BarCode,
            this.BookName,
            this.BorrowCount,
            this.Expire});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft YaHei", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvBookList.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvBookList.Location = new System.Drawing.Point(43, 389);
            this.dgvBookList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvBookList.Name = "dgvBookList";
            this.dgvBookList.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.Yellow;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Red;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvBookList.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvBookList.RowTemplate.Height = 30;
            this.dgvBookList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBookList.Size = new System.Drawing.Size(1418, 698);
            this.dgvBookList.TabIndex = 34;
            // 
            // lbl_Remainder
            // 
            this.lbl_Remainder.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl_Remainder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Remainder.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Remainder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_Remainder.Location = new System.Drawing.Point(819, 112);
            this.lbl_Remainder.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Remainder.Name = "lbl_Remainder";
            this.lbl_Remainder.Size = new System.Drawing.Size(164, 40);
            this.lbl_Remainder.TabIndex = 4;
            this.lbl_Remainder.Text = "0";
            this.lbl_Remainder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 53);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "ReadingCard：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(726, 122);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 20);
            this.label9.TabIndex = 2;
            this.label9.Text = "Allow：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(396, 53);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reader Name：";
            // 
            // lblBorrowCount
            // 
            this.lblBorrowCount.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblBorrowCount.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBorrowCount.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblBorrowCount.Location = new System.Drawing.Point(528, 112);
            this.lblBorrowCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBorrowCount.Name = "lblBorrowCount";
            this.lblBorrowCount.Size = new System.Drawing.Size(172, 40);
            this.lblBorrowCount.TabIndex = 4;
            this.lblBorrowCount.Text = "0";
            this.lblBorrowCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtReadingCard
            // 
            this.txtReadingCard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtReadingCard.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtReadingCard.Location = new System.Drawing.Point(158, 49);
            this.txtReadingCard.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtReadingCard.Name = "txtReadingCard";
            this.txtReadingCard.Size = new System.Drawing.Size(212, 31);
            this.txtReadingCard.TabIndex = 0;
            // 
            // lblAllowCounts
            // 
            this.lblAllowCounts.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblAllowCounts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAllowCounts.Font = new System.Drawing.Font("SimSun", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAllowCounts.Location = new System.Drawing.Point(157, 112);
            this.lblAllowCounts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAllowCounts.Name = "lblAllowCounts";
            this.lblAllowCounts.Size = new System.Drawing.Size(213, 40);
            this.lblAllowCounts.TabIndex = 4;
            this.lblAllowCounts.Text = "0";
            this.lblAllowCounts.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(726, 53);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Role：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(396, 122);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Borrowed：";
            // 
            // lblReaderName
            // 
            this.lblReaderName.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lblReaderName.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblReaderName.Location = new System.Drawing.Point(528, 43);
            this.lblReaderName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblReaderName.Name = "lblReaderName";
            this.lblReaderName.Size = new System.Drawing.Size(172, 40);
            this.lblReaderName.TabIndex = 4;
            this.lblReaderName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 122);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(113, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "AllowCounts：";
            // 
            // pbReaderImage
            // 
            this.pbReaderImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbReaderImage.Location = new System.Drawing.Point(1190, 27);
            this.pbReaderImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbReaderImage.Name = "pbReaderImage";
            this.pbReaderImage.Size = new System.Drawing.Size(269, 305);
            this.pbReaderImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbReaderImage.TabIndex = 35;
            this.pbReaderImage.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblRoleName);
            this.groupBox1.Controls.Add(this.lbl_Remainder);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblBorrowCount);
            this.groupBox1.Controls.Add(this.txtReadingCard);
            this.groupBox1.Controls.Add(this.lblAllowCounts);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.lblReaderName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(43, 27);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(1032, 188);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "[Reader Info]";
            // 
            // FmBorrowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1497, 1115);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtBarCode);
            this.Controls.Add(this.dgvBookList);
            this.Controls.Add(this.pbReaderImage);
            this.Controls.Add(this.groupBox1);
            this.Name = "FmBorrowBook";
            this.Text = "FmBorrowBook";
            ((System.ComponentModel.ISupportInitialize)(this.dgvBookList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbReaderImage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBarCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Expire;
        private System.Windows.Forms.Label lblRoleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BorrowCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BarCode;
        private System.Windows.Forms.DataGridView dgvBookList;
        private System.Windows.Forms.Label lbl_Remainder;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBorrowCount;
        private System.Windows.Forms.TextBox txtReadingCard;
        private System.Windows.Forms.Label lblAllowCounts;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblReaderName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbReaderImage;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}