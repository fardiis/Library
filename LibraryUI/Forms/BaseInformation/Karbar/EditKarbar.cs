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
    public partial class EditKarbar : Form
    {
        public BuisnesLibrary.Entities.Karbar Karbar{ get; set; }

        public EditKarbar(BuisnesLibrary.Entities.Karbar karbar)
        {
            InitializeComponent();
            this.Karbar = Karbar;
        }

        private void BtnInsert_Click(object sender, EventArgs e)
        {
            this.Karbar.Name = txtFirstName.Text;
            this.Karbar.SurName = txtLastName.Text;
            this.Karbar.Username = txtUsername.Text;
            this.Karbar.Password = txtPassword.Text;
            this.Karbar.Update();
            this.Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditKarbar_Load(object sender, EventArgs e)
        {
            txtFirstName.Text = this.Karbar.Name;
            txtLastName.Text = this.Karbar.SurName;
            txtUsername.Text = this.Karbar.Username;
            txtPassword.Text = this.Karbar.Password;
        }
    }
}
