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
            pemasukan n = new pemasukan();
            n.duitAwal = Convert.ToInt32(tbUangAwal.Text);
        }

        private void tbJangkaWaktu_TextChanged(object sender, EventArgs e)
        {
            jangkawaktu k = new jangkawaktu();
            k.waktuDuit = Convert.ToInt32(tbJangkaWaktu.Text);
        }

        private void tbTabungan_TextChanged(object sender, EventArgs e)
        {
            tabungan m = new tabungan();
            m.duitTabung = Convert.ToInt32(tbTabungan.Text);
        }

        private void dtpDanaMasuk_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
