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
    public partial class ONLINETUTORIAL : Form
    {
        public ONLINETUTORIAL()
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

        private void ONLINETUTORIAL_Load(object sender, EventArgs e)
        {

        }

        private void Button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCEWpbFLzoYGPfuWUMFPSaoA");
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/user/khanacademy");
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            ONLINECLASS oc = new ONLINECLASS();
            this.Hide();
            oc.Show();
        }
    }
}
