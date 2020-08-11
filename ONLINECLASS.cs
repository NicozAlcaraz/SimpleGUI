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
    public partial class ONLINECLASS : Form
    {
        public ONLINECLASS()
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

        private void Button4_Click(object sender, EventArgs e)
        {
            SCHOOL sc = new SCHOOL();
            this.Hide();
            sc.Show();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            ONLINETUTORIAL ot = new ONLINETUTORIAL();
            this.Hide();
            ot.Show();
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://webqc2.tip.edu.ph/portal/student/new/public/home.php?s=f09564c9ca56850d4cd6b3319e541aee");
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://mail.google.com/mail/u/1/#inbox");
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://tip.instructure.com/");
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://hangouts.google.com/?authuser=1");


                
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://drive.google.com/drive/u/1/my-drive");
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://classroom.google.com/u/1/h");
        }
    }
}
