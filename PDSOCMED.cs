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
    public partial class PDSOCMED : Form
    {
        public PDSOCMED()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UC-Aj63-s73YaFJb0wWzXBNQ");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/voyagernicoz");
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            this.Hide();
            db.Show();
        }
    }
}
