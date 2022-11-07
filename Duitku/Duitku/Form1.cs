using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Duitku
{
    public partial class formLogin : Form
    {
        public formLogin()
        {
            InitializeComponent();
        }
       
        private void formLogin_Load(object sender, EventArgs e)
        {

        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            User emil = new User();
            emil.Email = tbEmail.Text;
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }
        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            User pw = new User();
            pw.Password = tbPassword.Text;
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
        }
    }
}