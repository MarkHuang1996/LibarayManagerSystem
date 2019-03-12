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
    public partial class FmAddBook : Form
    {

        private BookManager objBookManager = new BookManager();
        private Video objVideo = null;
        private List<Books> booklist = new List<Books>();

        public FmAddBook()
        {
            InitializeComponent();
            //初始化Drop box
            this.cboBookCategory.DataSource = objBookManager.GetCategory();
            this.cboBookCategory.DisplayMember = "CategoryName";
            this.cboBookCategory.ValueMember = "CategoryId";
            this.cboBookCategory.SelectedIndex = -1;
            this.cboPublisher.DataSource = objBookManager.GetPublisher();
            this.cboPublisher.DisplayMember = "PublisherName";
            this.cboPublisher.ValueMember = "PublisherId";
            this.cboPublisher.SelectedIndex = -1;

            btnTake.Enabled = false;
            btnCloseVideo.Enabled = false;

            //
            this.dgvBookList.AutoGenerateColumns = false;
            new Common.DataGridViewStyle().DgvStyle1(this.dgvBookList);

        }

        private void btnChoseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog objFileDialog = new OpenFileDialog();
            DialogResult result = objFileDialog.ShowDialog();
            /////dddoooooooooooooooooooooooooooooooooooo     itttttttttttttttttttttttt判断是否为jpg文件
            if (result == DialogResult.OK)
            {


                this.pbCurrentImage.Image = Image.FromFile(objFileDialog.FileName);

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.pbCurrentImage.Image = null;
        }

        private void btnStartVideo_Click(object sender, EventArgs e)
        {
            try
            {
                this.objVideo = new Video(this.pbImage.Handle, this.pbImage.Left, this.pbImage.Top, this.pbImage.Width, (short)this.pbImage.Height);
                //open cam
                objVideo.OpenVideo();
                //open btn unable;
                btnStartVideo.Enabled = false;
                btnTake.Enabled = true;
                btnCloseVideo.Enabled = true;
                this.btnCloseVideo.BackColor = Color.Red;
                this.btnTake.BackColor = Color.Green;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Camar start error!" + ex.Message);
            }
        }

        private void btnCloseVideo_Click(object sender, EventArgs e)
        {
            objVideo.CloseVideo();
            //open btn unable;
            btnStartVideo.Enabled = true;
            btnTake.Enabled = false;
            btnCloseVideo.Enabled = false;
            this.btnCloseVideo.BackColor = Color.Gray;
            this.btnCloseVideo.ForeColor = Color.White;
            this.btnTake.BackColor = Color.Gray;
            this.btnTake.ForeColor = Color.White;
        }

        private void btnTake_Click(object sender, EventArgs e)
        {
            this.pbCurrentImage.Image = objVideo.CatchVideo();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            #region Data validation
            //data validation
            if (this.txtBookName.Text.Trim().Length == 0)
            {
                MessageBox.Show("Must have the BookName");
                this.txtBookName.Focus();
                return;
                
            }
          
            if (this.cboBookCategory.SelectedIndex == -1)
            {
                MessageBox.Show("Select the Book Category");
                return;
            }
            if(this.pbCurrentImage.Image == null)
            {
                MessageBox.Show("Select an image for book");
                return;
            }
            if(this.cboPublisher.SelectedIndex == -1)
            {
                MessageBox.Show("Select the Publisher for the book");
                return;

            }
            if(this.txtAuthor.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please input the Author for the book");
                this.txtAuthor.Focus();
                return;
            }
            if (this.txtUnitPrice.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please input the Book price");
                this.txtUnitPrice.Focus();
                return;
            }
  
            if (this.txtBarCode.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please entry the number which is under the Barcode");
                this.txtBarCode.Focus();
                return;
            }
      
            

            #endregion

            //instance of object
            Books objBook = new Books()
            {
                BookName = this.txtBookName.Text.Trim(),
                BookCategoryId = Convert.ToInt32(this.cboBookCategory.SelectedValue),
                PublisherId = Convert.ToInt32(this.cboPublisher.SelectedValue),
                PublisherDate = Convert.ToDateTime(this.dtpPublishDate.Text),
                Author = this.txtAuthor.Text.Trim(),
                UnitPrice = Convert.ToInt32(this.txtUnitPrice.Text.Trim()),
                BarCode = this.txtBarCode.Text.Trim(),
                BookCount = Convert.ToInt32(this.txtBookCount.Text.Trim()),
                Remainder = Convert.ToInt32(this.txtBookCount.Text.Trim()),
                BookPosition = this.txtBookPosition.Text.Trim(),
                BookImage = new Common.SerializeObjectToString().SerializeObject(this.pbCurrentImage.Image),
                PublisherName = this.cboPublisher.Text
                
            };


            //call B-E
            try
            {
                objBookManager.AddBookk(objBook);
                this.booklist.Add(objBook);
                this.dgvBookList.DataSource = null;
                this.dgvBookList.DataSource = this.booklist;
                //clearn the book infomation
                foreach (Control item in this.gbBook.Controls)
                {
                    if (item is TextBox) item.Text = "";
                    else if(item is ComboBox)
                    {
                        ((ComboBox)item).SelectedIndex = -1;
                    }
                }
                this.pbCurrentImage.Image = null;
                this.txtBookName.Focus();

            }
            catch (Exception ex)
            {

                throw;
            }

        }

        private void txtBarCode_KeyDown(object sender, KeyEventArgs e)
        {
            //if (this.txtBarCode.Text.Trim().Length > 0 && e.KeyValue == 13)//keyvalue 13 is enter key
            //{
            //    if (objBookManager.BarCodeExistsed(this.txtBarCode.Text.Trim()))
            //    {
            //        MessageBox.Show("this book exists in database");
            //        this.txtBarCode.SelectAll();
            //        this.txtBarCode.Focus();
            //    }
            //}
            if (e.KeyValue == 13)
            {
                txtBarCode_Leave(null, null);
            }
        }

        private void txtBarCode_Leave(object sender, EventArgs e)
        {
            if (this.txtBarCode.Text.Trim().Length > 0)
            {
                if (objBookManager.BarCodeExistsed(this.txtBarCode.Text.Trim()))
                {
                    MessageBox.Show("this book exists in database");
                    this.txtBarCode.SelectAll();
                    this.txtBarCode.Focus();
                }
            }
        }
    }
}
