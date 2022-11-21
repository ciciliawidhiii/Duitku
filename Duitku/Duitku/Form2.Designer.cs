namespace Duitku
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.lblUser = new System.Windows.Forms.Label();
            this.lbRekomendasi = new System.Windows.Forms.Label();
            this.lbPengeluaran = new System.Windows.Forms.Label();
            this.lblSisa = new System.Windows.Forms.Label();
            this.lblProfilH = new System.Windows.Forms.Label();
            this.llHome = new System.Windows.Forms.LinkLabel();
            this.llCalendar = new System.Windows.Forms.LinkLabel();
            this.llFinance = new System.Windows.Forms.LinkLabel();
            this.btnLogout = new Guna.UI2.WinForms.Guna2CircleButton();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblRekom = new System.Windows.Forms.Label();
            this.lblKeluar = new System.Windows.Forms.Label();
            this.lblSisaUang = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblUser.Location = new System.Drawing.Point(130, 142);
            this.lblUser.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(249, 87);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Hello, ";
            this.lblUser.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbRekomendasi
            // 
            this.lbRekomendasi.AutoSize = true;
            this.lbRekomendasi.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbRekomendasi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbRekomendasi.Location = new System.Drawing.Point(142, 298);
            this.lbRekomendasi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRekomendasi.Name = "lbRekomendasi";
            this.lbRekomendasi.Size = new System.Drawing.Size(436, 49);
            this.lbRekomendasi.TabIndex = 2;
            this.lbRekomendasi.Text = "Rekomendasi Hari ini ";
            // 
            // lbPengeluaran
            // 
            this.lbPengeluaran.AutoSize = true;
            this.lbPengeluaran.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPengeluaran.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbPengeluaran.Location = new System.Drawing.Point(142, 495);
            this.lbPengeluaran.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPengeluaran.Name = "lbPengeluaran";
            this.lbPengeluaran.Size = new System.Drawing.Size(283, 49);
            this.lbPengeluaran.TabIndex = 3;
            this.lbPengeluaran.Text = "Pengeluaran ";
            this.lbPengeluaran.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblSisa
            // 
            this.lblSisa.AutoSize = true;
            this.lblSisa.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSisa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblSisa.Location = new System.Drawing.Point(142, 698);
            this.lblSisa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSisa.Name = "lblSisa";
            this.lblSisa.Size = new System.Drawing.Size(210, 49);
            this.lblSisa.TabIndex = 5;
            this.lblSisa.Text = "Sisa Uang";
            // 
            // lblProfilH
            // 
            this.lblProfilH.AutoSize = true;
            this.lblProfilH.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProfilH.Location = new System.Drawing.Point(1205, 112);
            this.lblProfilH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProfilH.Name = "lblProfilH";
            this.lblProfilH.Size = new System.Drawing.Size(97, 21);
            this.lblProfilH.TabIndex = 7;
            this.lblProfilH.Text = "Abi Mana";
            this.lblProfilH.Click += new System.EventHandler(this.lblProfilH_Click);
            // 
            // llHome
            // 
            this.llHome.AutoSize = true;
            this.llHome.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.llHome.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.llHome.Location = new System.Drawing.Point(458, 39);
            this.llHome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llHome.Name = "llHome";
            this.llHome.Size = new System.Drawing.Size(96, 34);
            this.llHome.TabIndex = 8;
            this.llHome.TabStop = true;
            this.llHome.Text = "Home";
            // 
            // llCalendar
            // 
            this.llCalendar.AutoSize = true;
            this.llCalendar.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.llCalendar.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.llCalendar.Location = new System.Drawing.Point(674, 39);
            this.llCalendar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llCalendar.Name = "llCalendar";
            this.llCalendar.Size = new System.Drawing.Size(120, 34);
            this.llCalendar.TabIndex = 9;
            this.llCalendar.TabStop = true;
            this.llCalendar.Text = "Income";
            this.llCalendar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llCalendar_LinkClicked);
            // 
            // llFinance
            // 
            this.llFinance.AutoSize = true;
            this.llFinance.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.llFinance.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.llFinance.Location = new System.Drawing.Point(910, 39);
            this.llFinance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llFinance.Name = "llFinance";
            this.llFinance.Size = new System.Drawing.Size(144, 34);
            this.llFinance.TabIndex = 10;
            this.llFinance.TabStop = true;
            this.llFinance.Text = "Outcome";
            this.llFinance.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llFinance_LinkClicked);
            // 
            // btnLogout
            // 
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnLogout.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(1270, 826);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnLogout.Size = new System.Drawing.Size(122, 130);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.IndianRed;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(125, 39);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(2);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(124, 49);
            this.guna2HtmlLabel1.TabIndex = 46;
            this.guna2HtmlLabel1.Text = "Duitku";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Duitku.Properties.Resources.pigpng;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 98);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(161, 381);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(0, 0);
            this.guna2HtmlLabel2.TabIndex = 48;
            this.guna2HtmlLabel2.Text = null;
            // 
            // lblRekom
            // 
            this.lblRekom.AutoSize = true;
            this.lblRekom.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRekom.ForeColor = System.Drawing.Color.Brown;
            this.lblRekom.Location = new System.Drawing.Point(151, 365);
            this.lblRekom.Name = "lblRekom";
            this.lblRekom.Size = new System.Drawing.Size(277, 49);
            this.lblRekom.TabIndex = 49;
            this.lblRekom.Text = "RpXXX.000,00";
            this.lblRekom.Click += new System.EventHandler(this.lblRekom_Click);
            // 
            // lblKeluar
            // 
            this.lblKeluar.AutoSize = true;
            this.lblKeluar.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblKeluar.ForeColor = System.Drawing.Color.Brown;
            this.lblKeluar.Location = new System.Drawing.Point(148, 565);
            this.lblKeluar.Name = "lblKeluar";
            this.lblKeluar.Size = new System.Drawing.Size(277, 49);
            this.lblKeluar.TabIndex = 50;
            this.lblKeluar.Text = "RpXXX.000,00";
            // 
            // lblSisaUang
            // 
            this.lblSisaUang.AutoSize = true;
            this.lblSisaUang.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSisaUang.ForeColor = System.Drawing.Color.Brown;
            this.lblSisaUang.Location = new System.Drawing.Point(151, 760);
            this.lblSisaUang.Name = "lblSisaUang";
            this.lblSisaUang.Size = new System.Drawing.Size(277, 49);
            this.lblSisaUang.TabIndex = 51;
            this.lblSisaUang.Text = "RpXXX.000,00";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1418, 968);
            this.Controls.Add(this.lblSisaUang);
            this.Controls.Add(this.lblKeluar);
            this.Controls.Add(this.lblRekom);
            this.Controls.Add(this.guna2HtmlLabel2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.llFinance);
            this.Controls.Add(this.llCalendar);
            this.Controls.Add(this.llHome);
            this.Controls.Add(this.lblProfilH);
            this.Controls.Add(this.lblSisa);
            this.Controls.Add(this.lbPengeluaran);
            this.Controls.Add(this.lbRekomendasi);
            this.Controls.Add(this.lblUser);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Homepage";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblUser;
        private Label lbRekomendasi;
        private Label lbPengeluaran;
        private Label lblSisa;
        private Label lblProfilH;
        private LinkLabel llHome;
        private LinkLabel llCalendar;
        private LinkLabel llFinance;
        private Guna.UI2.WinForms.Guna2CircleButton btnLogout;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Label lblRekom;
        private Label lblKeluar;
        private Label lblSisaUang;
    }
}