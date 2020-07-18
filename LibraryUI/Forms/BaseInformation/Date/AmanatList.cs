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
    public partial class AmanatList : Form
    {
        private void DataRefreshEntrances()
        {
            dataGridView1.AutoGenerateColumns = false;
            bindingSource1.DataSource = new BuisnesLibrary.Entities.Date().Read();
        }
        public AmanatList()
        {
            InitializeComponent();
        }

        private void AmanatList_Load(object sender, EventArgs e)
        {
            DataRefreshEntrances();
        }

       

        private void BtnNew_Click(object sender, EventArgs e)
        {
            new SabtAmanat().ShowDialog();
            DataRefreshEntrances();
        }

       

       
    }
}
