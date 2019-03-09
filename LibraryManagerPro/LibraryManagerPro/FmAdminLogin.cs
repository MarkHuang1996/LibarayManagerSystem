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
using Common;

namespace LibraryManagerPro
{

    public partial class FmAdminLogin : Form
    {
        //craete bll objcet 
        private SysAdminManager objSysAdminManager = new SysAdminManager();
        public FmAdminLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            #region Data Validate
            if (this.txtLoginId.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please Type the Admin ID", "SIGN IN Tipe");
                this.txtLoginId.Focus();
                return;
            }
            if (!DataValidate.isInteger(txtLoginId.Text.Trim()))
            {
                MessageBox.Show("Admin ID Should be numbers ", "SIGN IN Tipe");
                this.txtLoginId.Focus();
                return;
            }
            if (this.txtLoginPwd.Text.Trim().Length == 0)
            {
                MessageBox.Show("Please entry the Password", "SIGN IN Tipe");
                this.txtLoginPwd.Focus();
                return;
            }
            #endregion

            //package the object 
            SysAdmin objAdmin = new SysAdmin()
            {
                AdminId = Convert.ToInt32(this.txtLoginId.Text.Trim()),
                LoginPwd = this.txtLoginPwd.Text.Trim(),
            };
            try
            {
                //call BLL to compare
                objAdmin = objSysAdminManager.AdminLogin(objAdmin);

                //judge login 
                if(objAdmin!= null)//successful
                {
                    if(objAdmin.StatusId == 1)// Status is good 
                    {
                        Program.objCurrentAdmin = objAdmin;// save currentUser
                        this.DialogResult = DialogResult.OK;
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("This User account has been banned ! Can't log in , Please contact with System Admin", "Sign in Tip");
                    }
                }
                else
                {
                    MessageBox.Show("Incorrect ID or Password", "SIGN IN Tip");
                }

            }
            catch (Exception)
            {

                throw;
            }
        

        }
    }
}
