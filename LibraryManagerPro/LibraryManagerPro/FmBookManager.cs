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

namespace LibraryManagerPro
{
    public partial class FmBookManager : Form
    {
        private BookManager  objBookManager= new BookManager();
        public FmBookManager()
        {
            InitializeComponent();
            this.cboCategory.DataSource = objBookManager.GetCategory();
            this.cboCategory.DisplayMember = "CategoryName";
            this.cboCategory.ValueMember = "CategoryId";
            this.cboCategory.SelectedIndex = -1;

        }

 
    }
}
