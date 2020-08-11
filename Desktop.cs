using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserDatabase
{
    public partial class Desktop : Form
    {
        public Desktop()
        {
            InitializeComponent();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\GUIDesktop\Softwares");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\GUIDesktop\Games");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\GUIDesktop\Programming");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\GUIDesktop\Search Engines");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\GUIDesktop\Editors");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\GUIDesktop\Launchers");
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            Database mn = new Database();
            this.Hide();
            mn.Show();
        }
    }
}
