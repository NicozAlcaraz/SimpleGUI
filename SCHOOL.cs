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
    public partial class SCHOOL : Form
    {
        public SCHOOL()
        {
            InitializeComponent();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Database mn = new Database();
            this.Hide();
            mn.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            PersonalData pd = new PersonalData();
            this.Hide();
            pd.Show();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ONLINECLASS oc = new ONLINECLASS();
            this.Hide();
            oc.Show();
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\Nicoz\Documents\Nicolz School Folder\Activities");
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\Nicoz\Documents\Nicolz School Folder\Exams");
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\Nicoz\Documents\Nicolz School Folder\Lessons");
            
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ONLINETUTORIAL ot = new ONLINETUTORIAL();
            this.Hide();
            ot.Show();
        }
    }
}
