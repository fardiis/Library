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
    public partial class BookTypeList : Form
    {
        private void DataRefreshBookType()
        {
            dataGridView1.AutoGenerateColumns = false;
            BuisnesLibrary.Entities.BookType bookType = new BuisnesLibrary.Entities.BookType();
            bindingSource1.DataSource = bookType.Read();
        }
        public BookTypeList()
        {
            InitializeComponent();
        }

        private void BookTypeList_Load(object sender, EventArgs e)
        {
            DataRefreshBookType();
        }

        private void Btndelete_Click(object sender, EventArgs e)
        {
            if (bindingSource1.List.Count > 0)//اگر آیتمی برای حذف وجود داشت
            {
                var result = MessageBox.Show("آیای مایل به حذف هستید؟", "هشدار", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    BuisnesLibrary.Entities.BookType carType = bindingSource1.Current as BuisnesLibrary.Entities.BookType;
                    var deleteResult = carType.Delete();
                    if (deleteResult)
                    {
                        DataRefreshBookType();
                    }
                    else
                    {
                        MessageBox.Show("عملیات با خطا همراه بود");
                    }
                }
            }
        }

        private void Btnedit_Click(object sender, EventArgs e)
        {
            Forms.BaseInformation.BookType.EditBookType editBookType = new EditBookType(bindingSource1.Current as BuisnesLibrary.Entities.BookType);
            editBookType.ShowDialog();
            DataRefreshBookType();
        }

        private void Btnnew_Click(object sender, EventArgs e)
        {
            Forms.BaseInformation.BookType.NewBookType newBookType= new BookType.NewBookType();
            newBookType.ShowDialog();

            DataRefreshBookType();
        }
    }
}

