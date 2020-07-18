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
    public partial class EditBookType : Form
    {
        public BuisnesLibrary.Entities.BookType BookType { get; set; }
        public EditBookType(BuisnesLibrary.Entities.BookType carTypeToEdit)
        
        {
            InitializeComponent();
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            this.BookType.BookName = txtName.Text;
            this.BookType.Update();
            this.Close();
        }

        private void EditBookType_Load(object sender, EventArgs e)
        {
            txtName.Text = this.BookType.BookName;
        }
    }
}
