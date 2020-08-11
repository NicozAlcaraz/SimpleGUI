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
    public partial class PersonalData : Form
    {
        public PersonalData()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Button5_Click(object sender, EventArgs e)
        {
            Database mn = new Database();
            this.Hide();
            mn.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            PDSOCMED pdsm = new PDSOCMED();
            this.Hide();
            pdsm.Show();
        }

        private void PersonalData_Load(object sender, EventArgs e)
        {

        }

        private void Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button4_Click(object sender, EventArgs e)
        {
            SCHOOL sc = new SCHOOL();
            this.Hide();
            sc.Show();
            
            //(@"C:\Users\Nicoz\Documents\Nicolz School Folder");
        }
    }
}

