using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagerPro
{
    public partial class FmMain : Form
    {
        public FmMain()
        {
            //show currentUser
            InitializeComponent();
            this.tssl_AdminName.Text = Program.objCurrentAdmin.AdminName;
        }
        private void OpenForm(Form objForm)
        {
            foreach (Control item in this.spContainer.Panel2.Controls)
            {
                if (item is Form)
                {
                    ((Form)item).Close();
                }
            }
            
            objForm.TopLevel = false;
            objForm.FormBorderStyle = FormBorderStyle.None;//move the border
            objForm.Parent = this.spContainer.Panel2;
            objForm.Dock = DockStyle.Fill;
            objForm.Show();
        }
        //Add New Book
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            FmAddBook objFmAddBook = new FmAddBook();
            OpenForm(objFmAddBook);

        }

        private void btnBookNew_Click(object sender, EventArgs e)
        {
            FmNewBook objFmNewBook = new FmNewBook();
            OpenForm(objFmNewBook);
        }

        private void btnBookManage_Click(object sender, EventArgs e)
        {
            FmBookManager objFmBookManager = new FmBookManager();
            OpenForm(objFmBookManager);
        }

        private void btnReaderManager_Click(object sender, EventArgs e)
        {
            FmReaderManager objFmReaderManager = new FmReaderManager();
            OpenForm(objFmReaderManager);

        }

        private void btnBorrowBook_Click(object sender, EventArgs e)
        {
            FmBorrowBook objFmBorrowBook = new FmBorrowBook();
            OpenForm(objFmBorrowBook);
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            FmRuturBook objFmRuturBook = new FmRuturBook();
            OpenForm(objFmRuturBook);
        }

        private void btnModifyPwd_Click(object sender, EventArgs e)
        {

        }

        private void FmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Sure to exit ?", "Exit", MessageBoxButtons.OKCancel);
            if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
