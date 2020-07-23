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
    public partial class Registry : Form
    {
        public Registry()
        {
            InitializeComponent();
        }

        private void Btnsave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text ))
            {
                MessageBox.Show("لطفا نام را وارد کنید");
               textBox1.Focus();
                return;
            }

            BuisnesLibrary.Entities.Karbar karbar = new BuisnesLibrary.Entities.Karbar();
            karbar.Username = textBox1.Text;
            karbar.Password = textBox2.Text;

            if (karbar.GetCount() > 0)//اگر تکراری بود
            {
                MessageBox.Show("تکراری");
                return;
            }

            var result = karbar.Insert();

            if (result)
            {
                this.Close();
            }
            else
            {
                MessageBox.Show("عملیات با خطا همراه بود");
            }
        }
    }
}
