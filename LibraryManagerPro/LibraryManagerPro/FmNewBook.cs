using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using BLL;
namespace LibraryManagerPro
{
    public partial class FmNewBook : Form
    {
        private BookManager objBookManager = new BookManager();
        private List<Books> booklist = new List<Books>();

        public FmNewBook()
        {
            InitializeComponent();
            this.txtAddCount.Enabled = false;
            this.btnSave.Enabled = false;
            this.dgvBookList.AutoGenerateColumns = false;
        }

        private void txtBarCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (this.txtBarCode.Text.Trim().Length != 0)
            {
                if (e.KeyValue == 13)
                {
                    Books objBook = objBookManager.GetBooksByBarCode(this.txtBarCode.Text.Trim());
                    if (objBook != null)
                    {
                        this.lblBookName.Text = objBook.BookName;
                        this.lblCategory.Text = objBook.CategoryName;
                        this.lblBookPosition.Text = objBook.BookPosition;
                        this.lblBookCount.Text = objBook.BookCount.ToString();
                        this.lblBookId.Text = objBook.BookId.ToString();
                        this.pbImage.Image = objBook.BookImage.Length == 0 ? null : (Image)new Common.SerializeObjectToString().DeserializeObject(objBook.BookImage);
                        this.txtAddCount.Enabled = true;
                        this.txtAddCount.Focus();
                        this.btnSave.Enabled = true;
                        //show on dblist
                        int count = (from b in booklist where b.BookId == objBook.BookId select b).Count();
                        if (count == 0)
                        {
                            this.booklist.Add(objBook);
                            this.dgvBookList.DataSource = null;
                            this.dgvBookList.DataSource = booklist;
                        }


                    }
                    else
                    {
                        MessageBox.Show("This book is not exists in database");
                    }


                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //data validate
            if (this.txtAddCount.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please entry  a  number ");
                return;
            }
            if (!Common.DataValidate.IsInteger(this.txtAddCount.Text.Trim()))
            {

            }

            try
            {
                int result = objBookManager.AddBookCount(this.txtBarCode.Text.Trim(), Convert.ToInt32(this.txtAddCount.Text.Trim()));
                if (result == 1)
                {
                    Books objBook = (from b in booklist
                                     where b.BarCode == this.txtBarCode.Text.Trim()
                                     select b).First<Books>();

                    objBook.BookCount = objBook.BookCount + Convert.ToInt32(this.txtAddCount.Text.Trim());
                    this.dgvBookList.Refresh();

                    // clean contrlls text 
                    this.lblBookCount.Text= "";
                    this.lblBookName.Text = "";
                    this.lblBookPosition.Text = "";
                    this.lblBookCount.Text = "";
                    this.lblBookId.Text = "";
                    this.pbImage.Image = null;
                    this.lblCategory.Text = "";
                    this.txtBarCode.Clear();
                    this.txtAddCount.Clear();
                    this.txtBarCode.Focus();
                    this.txtAddCount.Enabled = false;
                    this.btnSave.Enabled = false;

                }


            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
