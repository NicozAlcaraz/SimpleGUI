using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace UserDatabase
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
            textBox2.MaxLength = 50;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            SqlConnection sl = new SqlConnection
                (@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = 
                 C:\Users\Nicoz\Documents\CarazDatabase.mdf; 
                 Integrated Security = True; Connect Timeout = 30");

            SqlDataAdapter sa = new SqlDataAdapter("Select Count(*) From [Table] Where USERNAME='" + textBox1.Text + "' and PASSWORD = '" + textBox2.Text + "'", sl);
                 

            DataTable dt = new DataTable();
            sa.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                Database mn = new Database();
                mn.Show();

            }

            else
            {
                MessageBox.Show("Username or Password may be incorrect" + "\n" + "Please try again");
            }

        }

       
    }
}
