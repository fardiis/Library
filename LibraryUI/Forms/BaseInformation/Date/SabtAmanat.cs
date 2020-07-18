using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryUI.Forms.BaseInformation.Date
{
    public partial class SabtAmanat : Form
    {
        public void DataRefreshUsers()
        {
            bindingSourceKarbar.DataSource = new BuisnesLibrary.Entities.Karbar().Read();
            cmbUser.DisplayMember = "FullName";
            cmbUser.DataSource = bindingSourceKarbar;
        }

        public void DataRefreshCarTypes()
        {
            bindingSourceBookType.DataSource = new BuisnesLibrary.Entities.BookType().Read();
            cmbBook.DisplayMember = "Name";
          cmbBook.DataSource = bindingSourceBookType;
        }
        public SabtAmanat()
        {
            InitializeComponent();
        }

        private void Btnsabt_Click(object sender, EventArgs e)
        {
            BuisnesLibrary.Entities.Date date = new BuisnesLibrary.Entities.Date()
            {

                EntranceDate = DateTime.Now,
                BookType = bindingSourceBookType.Current as BuisnesLibrary.Entities.BookType,
                Karbar = bindingSourceKarbar.Current as BuisnesLibrary.Entities.Karbar,
            };

            var result = date.Insert();

            if (result)
            {
                this.Close();
            }
        }

        private void SabtAmanat_Load(object sender, EventArgs e)
        {
            DataRefreshUsers();
            DataRefreshCarTypes();
        }
    }
}
