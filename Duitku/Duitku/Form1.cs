using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Npgsql;

namespace Duitku
{
    public partial class formLogin : Form
    {
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;username=postgres;Password=widhi191;Database=duitkudb";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        public formLogin()
        {
            InitializeComponent();
        }
       
        private void formLogin_Load(object sender, EventArgs e)
        {
            cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\Website\RegistrationAndLogin\Database.mdf;Integrated Security=True");
            cn.Open();
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
            if (tbPassword.Text != string.Empty || tbEmail.Text != string.Empty)
            {

                cmd = new SqlCommand("select * from tblLogin where username='" + tbEmail.Text + "' and password='" + tbPassword.Text + "'", cn);
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    this.Hide();
                    Form2 f2 = new Form2();
                    f2.ShowDialog();
                }
                else
                {
                    dr.Close();
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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