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
    public partial class KarbarList : Form
    {
        public void DataRefreshUsers()
        {
            BuisnesLibrary.Entities.Karbar karbar = new BuisnesLibrary.Entities.Karbar();
            bindingSource1.DataSource = karbar.Read();
        }
        public KarbarList()
        {
            InitializeComponent();
        }

        private void KarbarList_Load(object sender, EventArgs e)
        {
            DataRefreshUsers();
        }

        private void Btnnew_Click(object sender, EventArgs e)
        {
            NewKarbar newKarbar = new Karbar.NewKarbar();
            newKarbar.ShowDialog();
            DataRefreshUsers();
        }

        private void Btndelete_Click(object sender, EventArgs e)
        {

            if (bindingSource1.List.Count > 0)
            {
                var karbar = bindingSource1.Current as BuisnesLibrary.Entities.Karbar;
                karbar.Delete();
                DataRefreshUsers();
            }
        }

        private void Btnedit_Click(object sender, EventArgs e)
        {
            var karbar = bindingSource1.Current as BuisnesLibrary.Entities.Karbar;
            EditKarbar editKarbar = new EditKarbar(karbar);
            editKarbar.ShowDialog();
            DataRefreshUsers();
        }
    }
}
