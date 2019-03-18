using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Models;
using MyVideo;

namespace LibraryManagerPro
{
    public partial class FmBookManager : Form
    {
        private BookManager  objBookManager= new BookManager();
        private List<Books> listBook = null; //save data 
        private Video objVideo = null;
        public FmBookManager()
        {
            InitializeComponent();
            // cbo box  list
            List<Category> list = objBookManager.GetCategory();
            list.Insert(0,new Category { CategoryId = -1,CategoryName = ""});
            this.cboCategory.DataSource = list;
            this.cboCategory.DisplayMember = "CategoryName";
            this.cboCategory.ValueMember = "CategoryId";
          
            // btn 
            this.btnDel.Enabled = false;
            this.btnSave.Enabled = false;
            //dgv
            this.dgvBookList.AutoGenerateColumns = false;
            //book info group-cbo_BookCategory
            this.cbo_BookCategory.DataSource= objBookManager.GetCategory();
            this.cbo_BookCategory.DisplayMember = "CategoryName";
            this.cbo_BookCategory.ValueMember = "CategoryId";
            this.cbo_BookCategory.SelectedIndex = -1;
            //book info group -- publisher
            this.cbo_Publisher.DataSource = objBookManager.GetPublisher();
            this.cbo_Publisher.DisplayMember = "PublisherName";
            this.cbo_Publisher.ValueMember = "PublisherId";



        }

        #region zuhe query
        private void btnQuery_Click(object sender, EventArgs e)
        {

            this.dgvBookList.SelectionChanged -= new EventHandler(dgvBookList_SelectionChanged);

              //judge
              if(this.cboCategory.SelectedValue.ToString()== "-1" && this.txtBarCode.Text.Trim().Length == 0 && this.txtBookName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Select at least one query condition!");
    
            }
            else
            {
                listBook = objBookManager.GetBook(Convert.ToInt32(this.cboCategory.SelectedValue), this.txtBarCode.Text.Trim(), this.txtBookName.Text.Trim());
                //show the result
                this.dgvBookList.DataSource = listBook;
                //Determine whether to open the button according to the query result
                if(listBook.Count ==0)
                {
                    MessageBox.Show("No book metched");
                }
                else
                {
                    this.btnDel.Enabled = true;
                    this.btnSave.Enabled = true;
                }
            }
            this.dgvBookList.SelectionChanged += new EventHandler(dgvBookList_SelectionChanged);
            dgvBookList_SelectionChanged(null, null);
        }
        #endregion

        #region sync the infomation
        private void dgvBookList_SelectionChanged(object sender, EventArgs e)
        {
            if (this.dgvBookList.RowCount == 0) return;
            string barcode = dgvBookList.CurrentRow.Cells["BarCode"].Value.ToString();
            Books objBook = (from b in listBook where b.BarCode.Equals(barcode) select b).First<Books>();
            //show current book object information
            this.lbl_BarCode.Text = objBook.BarCode;
            this.lbl_BookCount.Text = objBook.BookCount.ToString();
            this.lbl_BookId.Text = objBook.BookId.ToString();
            this.txt_Author.Text = objBook.Author;
            this.txt_BookName.Text =objBook.BookName;
            this.txt_BookPosition.Text =objBook.BookPosition;
            this.txt_UnitPrice.Text = objBook.UnitPrice.ToString();
            this.cbo_BookCategory.SelectedValue = objBook.BookCategoryId;
            this.cbo_Publisher.SelectedValue = objBook.PublisherId;
            if(objBook.BookImage.Length != 0)
            {
                this.pbCurrentImage.Image = (Image)new Common.SerializeObjectToString().DeserializeObject(objBook.BookImage);
            }
            else
            {
                this.pbCurrentImage.Image = null;
            }
          
        

        }
        #endregion

        private void btnStartVideo_Click(object sender, EventArgs e)
        {

        }

        private void btnCloseVideo_Click(object sender, EventArgs e)
        {

        }

        private void btnTake_Click(object sender, EventArgs e)
        {

        }

        private void btnChoseImage_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //data validate

            //instance object 
            Books book = new Books()
            {
                BookName = this.txt_BookName.Text.Trim(),
                BookCategoryId = Convert.ToInt32(this.cbo_BookCategory.SelectedValue),
                PublisherId = Convert.ToInt32(this.cbo_Publisher.SelectedValue),
                PublisherDate = Convert.ToDateTime(this.dtp_PublishDate.Text),
                Author = this.txt_Author.Text.Trim(),
                UnitPrice = Convert.ToDouble(this.txt_UnitPrice.Text.Trim()),
                BookPosition = this.txt_BookPosition.Text.Trim(),
                BarCode = this.lbl_BarCode.Text.Trim(),
                BookCount = Convert.ToInt32(this.lbl_BookCount.Text.Trim()),
                BookImage = new Common.SerializeObjectToString().SerializeObject(this.pbCurrentImage.Image),
                BookId = Convert.ToInt32(this.lbl_BookId.Text.Trim())
            };

            //call bookmanager
            try
            {
                objBookManager.EditBook(book);
                MessageBox.Show("Edit book information successful");
                //renew the listbook
                Books editedBook = (from b in this.listBook where b.BookId.Equals(Convert.ToInt32(this.lbl_BookId.Text.Trim())) select b).First<Books>();
                editedBook.BookName = book.BookName;
                editedBook.BookCategoryId = book.BookCategoryId;
                editedBook.PublisherName = this.cbo_Publisher.Text;
                editedBook.PublisherDate = book.PublisherDate;
                editedBook.Author = book.Author;
                editedBook.UnitPrice = book.UnitPrice;
                editedBook.BookPosition = book.BookPosition;
                editedBook.BarCode = book.BarCode;
                editedBook.BookCount = book.BookCount;
                editedBook.BookId = book.BookId;
                editedBook.BookImage = book.BookImage;
                editedBook.PublisherId = book.PublisherId;
                this.dgvBookList.Refresh();

            }
            catch (Exception ex)
            {
                MessageBox.Show("error :" + ex.Message);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            // delete confim 
            DialogResult result = MessageBox.Show("sure to delete the book ?","important!!!!",MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel) return;
            else
            {
                try
                {
                    this.dgvBookList.SelectionChanged -= new EventHandler(dgvBookList_SelectionChanged);
                    if ( objBookManager.DeleteBook(this.lbl_BookId.Text.Trim())== 1)
                    {
                        Books deletedBook = (from b in this.listBook where b.BookId.Equals(Convert.ToInt32(this.lbl_BookId.Text.Trim())) select b).First<Books>();
                        this.listBook.Remove(deletedBook);
                        this.dgvBookList.DataSource = null;
                        this.dgvBookList.DataSource = listBook;

                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
                this.dgvBookList.SelectionChanged += new EventHandler(dgvBookList_SelectionChanged);
                dgvBookList_SelectionChanged(null, null);

            }
        }
    }
}
