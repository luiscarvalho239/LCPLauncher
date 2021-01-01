using System;
using System.Collections.Generic;
using System.Windows.Forms;
using static LCPLauncher.Functions;

namespace LCPLauncher
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadCMDSListToCB();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            Application.Exit();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            this.Hide();
            CMDForm cmdf = new CMDForm(cbCmdsList);
            cmdf.Show();
        }

        void LoadCMDSListToCB()
        {
            var pathproj = @"C:\Users\%username%\Documents\angular\lcp";
            var listcmds = GetListCMDS(pathproj);

            cbCmdsList.DataSource = new BindingSource(listcmds, null);
            cbCmdsList.DisplayMember = "Key";
            cbCmdsList.ValueMember = "Value";
        }
    }
}
