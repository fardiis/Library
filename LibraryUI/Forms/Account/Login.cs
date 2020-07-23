using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryUI.Forms.Account
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
           
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
                return;

            if (txtPassword.Text == "")
                return;

            BuisnesLibrary.Entities.Karbar karbar = new BuisnesLibrary.Entities.Karbar();
            karbar.Username = txtUsername.Text;
            karbar.Password = txtPassword.Text;
            var result = karbar.CheckLoginInfo();

            if (result == true)
                this.Close();
            else
                MessageBox.Show("اطلاعات غلط است");
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Forms.BaseInformation.Karbar.Registry registry = new BaseInformation.Karbar.Registry();
            registry.ShowDialog();
        }
    }
    }

