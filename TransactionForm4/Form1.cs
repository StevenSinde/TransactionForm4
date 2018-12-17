using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace TransactionForm4
{
    public partial class Form1 : Form
    {
        List<Names> Names = new List<Names>();
        List<Cities> City = new List<Cities>();
        public Form1()
        {
            InitializeComponent();
        }
        private void CityButton_Click(object sender, EventArgs e)
        {
            CityDataAccess db2 = new CityDataAccess();
            City = db2.GetCity(TextBox.Text);
            UpdateInfo2();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            NamesDataAccess db = new NamesDataAccess();
            Names = db.GetNames(TextBox.Text);
            UpdateInfo1();
        }



        public void UpdateInfo1()
        {
            ListBox.DataSource = Names;
            ListBox.DisplayMember = "FullName";
        }

        public void UpdateInfo2()
        {
            ListBox.DataSource = City;
            ListBox.DisplayMember = "DisplayCity";
        }

        private void ClearCache_Click(object sender, EventArgs e)
        {

            UpdateInfo2();
        }
    }
}
