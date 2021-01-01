using System;
using System.Windows.Forms;
using static LCPLauncher.Functions;

namespace LCPLauncher
{
    public partial class CMDForm : Form
    {
        private readonly ComboBox _cb;
        public CMDForm(ComboBox cb)
        {
            InitializeComponent();
            _cb = cb;
        }

        private void CMDForm_Load(object sender, EventArgs e)
        {
            LoadCMD(_cb, tbCMDProcess);
        }

        private void CMDForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Main m = new Main();
            m.Show();
        }
    }
}
