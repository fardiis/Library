using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryUI.Forms.BaseInformation.BookType
{
    public partial class NewBookType : Form
    {
        public NewBookType()
        {
            InitializeComponent();
        }

        private void NewBookType_Load(object sender, EventArgs e)
        {

        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            //Validation
            if (string.IsNullOrEmpty(txtName.Text))
            {
                MessageBox.Show("لطفا نام را وارد کنید");
                txtName.Focus();
                return;
            }

          BuisnesLibrary.Entities.BookType bookType = new BuisnesLibrary.Entities.BookType();
            bookType.BookName = txtName.Text;

            if (bookType.GetCount() > 0)//اگر تکراری بود
            {
                MessageBox.Show("تکراری");
                return;
            }

            var result = bookType.Insert();

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
