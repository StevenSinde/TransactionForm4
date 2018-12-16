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
        List<Names> Info = new List<Names>();
        public Form1()
        {
            InitializeComponent();
            UpdateInfo();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            NamesDataAccess db = new NamesDataAccess();
            Info = db.GetNames(TextBox.Text);
            UpdateInfo();
        }

        public void UpdateInfo()
        {
            ListBox.DataSource = Info;
            ListBox.DisplayMember = "FullName";
        }
    }
}
