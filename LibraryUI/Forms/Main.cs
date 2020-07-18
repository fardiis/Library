using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryUI.Forms
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void MnuBookType_Click(object sender, EventArgs e)
        {

            Forms.BaseInformation.BookType.BookTypeList bookTypeList = new BaseInformation.BookType.BookTypeList();
            bookTypeList.ShowDialog();
        }

        private void ثبتکتابToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Forms.BaseInformation.BookType.NewBookType newBookType = new BaseInformation.BookType.NewBookType();
            newBookType.ShowDialog();
        }
    }
}
