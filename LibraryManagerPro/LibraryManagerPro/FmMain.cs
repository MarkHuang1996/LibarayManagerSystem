﻿using System;
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
    }
}
