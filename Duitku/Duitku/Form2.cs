using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Duitku
{
    
    partial class Form2 : Form
    {
        public User Pengguna;
        private string lblrekom6;
        
        public Form2(User pengguna)
        {
            InitializeComponent();
            Pengguna = pengguna;
            string id_user = Pengguna.ID_user;
            string name = Pengguna.userName;
            lblUser.Text = "Hi " + name + "!";
        }
        private NpgsqlConnection conn;
        string connstring = "Host=localhost;Port=5432;username=postgres;Password=widhi191;Database=duitkudb";
        public DataTable dt;
        public static NpgsqlCommand cmd;
        private string sql = null;
        public Form2(string lblrekom6)
        {
            InitializeComponent();
            lblRekom.Text = Form6.lblrekom6;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5(Pengguna);
            f5.ShowDialog();
        }

        private void llFinance_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form7 f7 = new Form7(Pengguna);
            f7.ShowDialog();
        }

        private void llCalendar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form6 f6 = new Form6(Pengguna);
            f6.ShowDialog();
        }

        private void lblProfilH_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }
        private string uname;
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void lblRekom_Click(object sender, EventArgs e)
        {
            
        }

        private void lblSisaUang_Click(object sender, EventArgs e)
        {

        }

        private void lblKeluar_Click(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            conn.Open();
            int outcome = 0;
            int income = 0;
            NpgsqlCommand cmd_outcome = new NpgsqlCommand("Select sum (uang_keluar) as total from tb_outcome where id = '" + Pengguna.ID_user + "'", conn);
            NpgsqlDataReader out_reader = cmd_outcome.ExecuteReader();
            NpgsqlCommand cmd_income = new NpgsqlCommand("Select sum (uang_masuk) as total from tb_income where id = '" + Pengguna.ID_user + "'", conn);
            NpgsqlDataReader in_reader = cmd_income.ExecuteReader();
            while (out_reader.Read())
            {
                try
                {
                    outcome = out_reader.GetInt32(0);
                    income = in_reader.GetInt32(1);
                }
                catch
                {
                    outcome = 0;
                    income = 0;
                }
            }
            lblKeluar.Text = outcome.ToString();
            lblRekom.Text = Form6.lblrekom6;
            lblSisa.Text = income.ToString();
            conn.Close();
            Form6 uangawal = new Form6(Pengguna);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(connstring);
            conn.Open();
            int outcome = 0;

            NpgsqlCommand cmd_outcome = new NpgsqlCommand("Select sum (uang_keluar) as total from tb_outcome where id = '" + Pengguna.ID_user + "'", conn);
            NpgsqlDataReader out_reader = cmd_outcome.ExecuteReader();
            while (out_reader.Read())
            {
                try
                {
                    outcome = out_reader.GetInt32(0);
                }
                catch
                {
                    outcome = 0;
                }
            }
            lblKeluar.Text = outcome.ToString();
            lblRekom.Text = Form6.lblrekom6;
            conn.Close();

            //int balance = income - outcome;
            //lblKeluar.Text = balance.ToString();
        }
    }
 }

