﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Duitku
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void dtpDanaKeluar_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAddOut_Click(object sender, EventArgs e)
        {

        }

        private void llIncome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form6 f6 = new Form6();
            f6.ShowDialog();
        }

        private void llHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void llHome_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void llIncome_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form6 f6 = new Form6();
            f6.ShowDialog();
        }

        private void llOutcome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void tbPengeluaran_TextChanged(object sender, EventArgs e)
        {
            pengeluaran keluar = new pengeluaran();
            keluar.duitKeluar = Convert.ToInt32(tbPengeluaran.Text);
        }
    }
}
