namespace LibraryManagerPro
{
    partial class FmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmMain));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblAdminName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tssl_AdminName = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsmiModifyPwd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.商品管理PToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiAddBook = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBookNew = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBookManage = new System.Windows.Forms.ToolStripMenuItem();
            this.spContainer = new System.Windows.Forms.SplitContainer();
            this.btnReaderManager = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblOperationName = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.btnModifyPwd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.btnBookNew = new System.Windows.Forms.Button();
            this.btnBorrowBook = new System.Windows.Forms.Button();
            this.btnBookManage = new System.Windows.Forms.Button();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.tsmiMemberManage = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReturnBook = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBorrowBook = new System.Windows.Forms.ToolStripMenuItem();
            this.销售管理XToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.系统SToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spContainer)).BeginInit();
            this.spContainer.Panel1.SuspendLayout();
            this.spContainer.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblAdminName,
            this.tssl_AdminName});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1185);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1896, 30);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(204, 25);
            this.toolStripStatusLabel1.Text = "[LibararyManager]  V2.0 ";
            // 
            // lblAdminName
            // 
            this.lblAdminName.Name = "lblAdminName";
            this.lblAdminName.Size = new System.Drawing.Size(122, 25);
            this.lblAdminName.Text = "【Admin】：";
            // 
            // tssl_AdminName
            // 
            this.tssl_AdminName.Name = "tssl_AdminName";
            this.tssl_AdminName.Size = new System.Drawing.Size(43, 25);
            this.tssl_AdminName.Text = "Null";
            // 
            // tsmiModifyPwd
            // 
            this.tsmiModifyPwd.Image = ((System.Drawing.Image)(resources.GetObject("tsmiModifyPwd.Image")));
            this.tsmiModifyPwd.Name = "tsmiModifyPwd";
            this.tsmiModifyPwd.Size = new System.Drawing.Size(207, 30);
            this.tsmiModifyPwd.Text = "ModifyPwd(&P)";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(204, 6);
            // 
            // tsmiExit
            // 
            this.tsmiExit.Image = ((System.Drawing.Image)(resources.GetObject("tsmiExit.Image")));
            this.tsmiExit.Name = "tsmiExit";
            this.tsmiExit.Size = new System.Drawing.Size(207, 30);
            this.tsmiExit.Text = "Exit(&E)";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(224, 6);
            // 
            // 商品管理PToolStripMenuItem
            // 
            this.商品管理PToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiAddBook,
            this.tsmiBookNew,
            this.toolStripSeparator1,
            this.tsmiBookManage});
            this.商品管理PToolStripMenuItem.Name = "商品管理PToolStripMenuItem";
            this.商品管理PToolStripMenuItem.Size = new System.Drawing.Size(144, 29);
            this.商品管理PToolStripMenuItem.Text = "ItemManage(&B)";
            // 
            // tsmiAddBook
            // 
            this.tsmiAddBook.Image = ((System.Drawing.Image)(resources.GetObject("tsmiAddBook.Image")));
            this.tsmiAddBook.Name = "tsmiAddBook";
            this.tsmiAddBook.Size = new System.Drawing.Size(227, 30);
            this.tsmiAddBook.Text = "AddBook(&A)";
            // 
            // tsmiBookNew
            // 
            this.tsmiBookNew.Image = ((System.Drawing.Image)(resources.GetObject("tsmiBookNew.Image")));
            this.tsmiBookNew.Name = "tsmiBookNew";
            this.tsmiBookNew.Size = new System.Drawing.Size(227, 30);
            this.tsmiBookNew.Text = "BookNew(&I)";
            // 
            // tsmiBookManage
            // 
            this.tsmiBookManage.Image = ((System.Drawing.Image)(resources.GetObject("tsmiBookManage.Image")));
            this.tsmiBookManage.Name = "tsmiBookManage";
            this.tsmiBookManage.Size = new System.Drawing.Size(227, 30);
            this.tsmiBookManage.Text = "BookManage(&M)";
            // 
            // spContainer
            // 
            this.spContainer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.spContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.spContainer.Location = new System.Drawing.Point(0, 35);
            this.spContainer.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.spContainer.Name = "spContainer";
            // 
            // spContainer.Panel1
            // 
            this.spContainer.Panel1.Controls.Add(this.btnReaderManager);
            this.spContainer.Panel1.Controls.Add(this.label2);
            this.spContainer.Panel1.Controls.Add(this.label1);
            this.spContainer.Panel1.Controls.Add(this.lblOperationName);
            this.spContainer.Panel1.Controls.Add(this.monthCalendar1);
            this.spContainer.Panel1.Controls.Add(this.btnModifyPwd);
            this.spContainer.Panel1.Controls.Add(this.btnExit);
            this.spContainer.Panel1.Controls.Add(this.btnReturnBook);
            this.spContainer.Panel1.Controls.Add(this.btnBookNew);
            this.spContainer.Panel1.Controls.Add(this.btnBorrowBook);
            this.spContainer.Panel1.Controls.Add(this.btnBookManage);
            this.spContainer.Panel1.Controls.Add(this.btnAddBook);
            // 
            // spContainer.Panel2
            // 
            this.spContainer.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.spContainer.Size = new System.Drawing.Size(1896, 1180);
            this.spContainer.SplitterDistance = 365;
            this.spContainer.SplitterWidth = 6;
            this.spContainer.TabIndex = 16;
            // 
            // btnReaderManager
            // 
            this.btnReaderManager.Image = ((System.Drawing.Image)(resources.GetObject("btnReaderManager.Image")));
            this.btnReaderManager.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReaderManager.Location = new System.Drawing.Point(190, 695);
            this.btnReaderManager.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReaderManager.Name = "btnReaderManager";
            this.btnReaderManager.Size = new System.Drawing.Size(123, 68);
            this.btnReaderManager.TabIndex = 1;
            this.btnReaderManager.Text = "ReaderManager";
            this.btnReaderManager.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReaderManager.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(36, 905);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(276, 5);
            this.label2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(38, 660);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 5);
            this.label1.TabIndex = 0;
            // 
            // lblOperationName
            // 
            this.lblOperationName.Font = new System.Drawing.Font("Microsoft YaHei Light", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOperationName.ForeColor = System.Drawing.Color.Maroon;
            this.lblOperationName.Location = new System.Drawing.Point(15, 27);
            this.lblOperationName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOperationName.Name = "lblOperationName";
            this.lblOperationName.Size = new System.Drawing.Size(330, 82);
            this.lblOperationName.TabIndex = 0;
            this.lblOperationName.Text = "Welcom";
            this.lblOperationName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(15, 147);
            this.monthCalendar1.Margin = new System.Windows.Forms.Padding(14, 15, 14, 15);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // btnModifyPwd
            // 
            this.btnModifyPwd.Image = ((System.Drawing.Image)(resources.GetObject("btnModifyPwd.Image")));
            this.btnModifyPwd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnModifyPwd.Location = new System.Drawing.Point(39, 945);
            this.btnModifyPwd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModifyPwd.Name = "btnModifyPwd";
            this.btnModifyPwd.Size = new System.Drawing.Size(123, 68);
            this.btnModifyPwd.TabIndex = 1;
            this.btnModifyPwd.Text = "ModifyPwd";
            this.btnModifyPwd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnModifyPwd.UseVisualStyleBackColor = true;
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(189, 945);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(123, 68);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.Image = ((System.Drawing.Image)(resources.GetObject("btnReturnBook.Image")));
            this.btnReturnBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReturnBook.Location = new System.Drawing.Point(189, 797);
            this.btnReturnBook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(123, 68);
            this.btnReturnBook.TabIndex = 1;
            this.btnReturnBook.Text = "ReturnBook";
            this.btnReturnBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReturnBook.UseVisualStyleBackColor = true;
            // 
            // btnBookNew
            // 
            this.btnBookNew.Image = ((System.Drawing.Image)(resources.GetObject("btnBookNew.Image")));
            this.btnBookNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookNew.Location = new System.Drawing.Point(189, 555);
            this.btnBookNew.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBookNew.Name = "btnBookNew";
            this.btnBookNew.Size = new System.Drawing.Size(123, 68);
            this.btnBookNew.TabIndex = 1;
            this.btnBookNew.Text = " BookNew";
            this.btnBookNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBookNew.UseVisualStyleBackColor = true;
            // 
            // btnBorrowBook
            // 
            this.btnBorrowBook.Image = ((System.Drawing.Image)(resources.GetObject("btnBorrowBook.Image")));
            this.btnBorrowBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBorrowBook.Location = new System.Drawing.Point(38, 797);
            this.btnBorrowBook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBorrowBook.Name = "btnBorrowBook";
            this.btnBorrowBook.Size = new System.Drawing.Size(123, 68);
            this.btnBorrowBook.TabIndex = 1;
            this.btnBorrowBook.Text = "BorrowBook";
            this.btnBorrowBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBorrowBook.UseVisualStyleBackColor = true;
            // 
            // btnBookManage
            // 
            this.btnBookManage.Image = ((System.Drawing.Image)(resources.GetObject("btnBookManage.Image")));
            this.btnBookManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookManage.Location = new System.Drawing.Point(38, 695);
            this.btnBookManage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBookManage.Name = "btnBookManage";
            this.btnBookManage.Size = new System.Drawing.Size(123, 68);
            this.btnBookManage.TabIndex = 1;
            this.btnBookManage.Text = "BookManage";
            this.btnBookManage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBookManage.UseVisualStyleBackColor = true;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Image = ((System.Drawing.Image)(resources.GetObject("btnAddBook.Image")));
            this.btnAddBook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddBook.Location = new System.Drawing.Point(39, 553);
            this.btnAddBook.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(123, 68);
            this.btnAddBook.TabIndex = 1;
            this.btnAddBook.Text = "AddBook";
            this.btnAddBook.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddBook.UseVisualStyleBackColor = true;
            // 
            // tsmiMemberManage
            // 
            this.tsmiMemberManage.Image = ((System.Drawing.Image)(resources.GetObject("tsmiMemberManage.Image")));
            this.tsmiMemberManage.Name = "tsmiMemberManage";
            this.tsmiMemberManage.Size = new System.Drawing.Size(253, 30);
            this.tsmiMemberManage.Text = "MemberManage(&M)";
            // 
            // tsmiReturnBook
            // 
            this.tsmiReturnBook.Image = ((System.Drawing.Image)(resources.GetObject("tsmiReturnBook.Image")));
            this.tsmiReturnBook.Name = "tsmiReturnBook";
            this.tsmiReturnBook.Size = new System.Drawing.Size(253, 30);
            this.tsmiReturnBook.Text = "ReturnBook(&R)";
            // 
            // tsmiBorrowBook
            // 
            this.tsmiBorrowBook.Image = ((System.Drawing.Image)(resources.GetObject("tsmiBorrowBook.Image")));
            this.tsmiBorrowBook.Name = "tsmiBorrowBook";
            this.tsmiBorrowBook.Size = new System.Drawing.Size(253, 30);
            this.tsmiBorrowBook.Text = "图书出借(&B)";
            // 
            // 销售管理XToolStripMenuItem
            // 
            this.销售管理XToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiBorrowBook,
            this.tsmiReturnBook,
            this.tsmiMemberManage});
            this.销售管理XToolStripMenuItem.Name = "销售管理XToolStripMenuItem";
            this.销售管理XToolStripMenuItem.Size = new System.Drawing.Size(139, 29);
            this.销售管理XToolStripMenuItem.Text = "会员借还书(&B)";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统SToolStripMenuItem,
            this.商品管理PToolStripMenuItem,
            this.销售管理XToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1896, 35);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 系统SToolStripMenuItem
            // 
            this.系统SToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiModifyPwd,
            this.toolStripSeparator3,
            this.tsmiExit});
            this.系统SToolStripMenuItem.Name = "系统SToolStripMenuItem";
            this.系统SToolStripMenuItem.Size = new System.Drawing.Size(82, 29);
            this.系统SToolStripMenuItem.Text = "系统(&S)";
            // 
            // FmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1896, 1215);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.spContainer);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FmMain";
            this.Text = "Form1";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.spContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spContainer)).EndInit();
            this.spContainer.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblAdminName;
        private System.Windows.Forms.ToolStripStatusLabel tssl_AdminName;
        private System.Windows.Forms.ToolStripMenuItem tsmiModifyPwd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 商品管理PToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiAddBook;
        private System.Windows.Forms.ToolStripMenuItem tsmiBookNew;
        private System.Windows.Forms.ToolStripMenuItem tsmiBookManage;
        private System.Windows.Forms.SplitContainer spContainer;
        private System.Windows.Forms.Button btnReaderManager;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblOperationName;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button btnModifyPwd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.Button btnBookNew;
        private System.Windows.Forms.Button btnBorrowBook;
        private System.Windows.Forms.Button btnBookManage;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.ToolStripMenuItem tsmiMemberManage;
        private System.Windows.Forms.ToolStripMenuItem tsmiReturnBook;
        private System.Windows.Forms.ToolStripMenuItem tsmiBorrowBook;
        private System.Windows.Forms.ToolStripMenuItem 销售管理XToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 系统SToolStripMenuItem;
    }
}

