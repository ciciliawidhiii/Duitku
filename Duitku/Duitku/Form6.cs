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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void llHome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
        }

        private void llOutcome_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form7 f7 = new Form7();
            f7.ShowDialog();
        }
    }
}
