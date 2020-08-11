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
    public partial class Database : Form
    {
        public Database()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            JumboLoy jl = new JumboLoy();
            jl.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            PersonalData pd = new PersonalData();
            pd.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            Desktop dt = new Desktop();
            this.Hide();
            dt.Show();
        }
    }
}
