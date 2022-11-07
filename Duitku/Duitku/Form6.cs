using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Duitku
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
        private void llHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void llOutcome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form7 f7 = new Form7();
            f7.ShowDialog();
        }

        private void tbUangAwal_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbJangkaWaktu_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbTabungan_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpDanaMasuk_ValueChanged(object sender, EventArgs e)
        {

        }
        private void lblRekomendasi_Click(object sender, EventArgs e)
        {

        }

        private void btnAddFinance_Click_1(object sender, EventArgs e)
        {
            rekomendasipengeluaran uangRek = new rekomendasipengeluaran();
            int reklagi = uangRek.reccomendation(Convert.ToInt32(tbUangAwal.Text), Convert.ToInt32(tbTabungan.Text), Convert.ToInt32(tbJangkaWaktu.Text));
            string msgrek = "Rp" + Convert.ToString(reklagi) + ",00/hari";
            lblRekomendasi.Text = msgrek;
        }
    }
}