using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryUI.Forms.BaseInformation.Karbar
{
    public partial class NewKarbar : Form
    {
        public NewKarbar()
        {
            InitializeComponent();
        }

        private void NewKarbar_Load(object sender, EventArgs e)
        {

        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            var validationResult = Validation();

            if (validationResult == false)
                return;

           BuisnesLibrary.Entities.Karbar karbar = new BuisnesLibrary.Entities.Karbar();

            karbar.Name = txtFirstName.Text;
            karbar.SurName = txtLastName.Text;
            karbar.Username = txtUsername.Text;
            karbar.Password = txtPassword.Text;

            var insertResult = karbar.Insert();
            if (insertResult == true)
                MessageBox.Show("عملیات موفقیت آمیز بود");
            else
                MessageBox.Show("خطا در عملیات");
        }
        public bool Validation()
        {
            if (txtFirstName.Text == "")
            {
                MessageBox.Show("لطفا نام را وارد کنید");
                return false;
            }

            if (txtLastName.Text == "")
            {
                MessageBox.Show("لطفا نام خانوادگی را وارد کنید");
                return false;
            }

            return true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
