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
    public partial class JumboLoy : Form
    {
        public JumboLoy()
        {
            InitializeComponent();
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start(@"C:\Users\Nicoz\Documents\Jumbo Loy");
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Database mn = new Database();
            this.Hide();
            mn.Show();

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/JumboLoy.Kitchen");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.instagram.com/jumboloy/");
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
