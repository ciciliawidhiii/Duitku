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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvRekomendasiH = new System.Windows.Forms.DataGridView();
            this.lbRekomendasi = new System.Windows.Forms.Label();
            this.lbPengeluaran = new System.Windows.Forms.Label();
            this.dgvPengeluaranH = new System.Windows.Forms.DataGridView();
            this.lblSisa = new System.Windows.Forms.Label();
            this.dgvSisaH = new System.Windows.Forms.DataGridView();
            this.lblProfilH = new System.Windows.Forms.Label();
            this.llHome = new System.Windows.Forms.LinkLabel();
            this.llCalendar = new System.Windows.Forms.LinkLabel();
            this.llFinance = new System.Windows.Forms.LinkLabel();
            this.btnLogout = new Guna.UI2.WinForms.Guna2CircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRekomendasiH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPengeluaranH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSisaH)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(104, 114);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hello, Abi!";
            // 
            // dgvRekomendasiH
            // 
            this.dgvRekomendasiH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRekomendasiH.Location = new System.Drawing.Point(114, 280);
            this.dgvRekomendasiH.Margin = new System.Windows.Forms.Padding(2);
            this.dgvRekomendasiH.Name = "dgvRekomendasiH";
            this.dgvRekomendasiH.RowHeadersWidth = 62;
            this.dgvRekomendasiH.RowTemplate.Height = 33;
            this.dgvRekomendasiH.Size = new System.Drawing.Size(288, 66);
            this.dgvRekomendasiH.TabIndex = 1;
            this.dgvRekomendasiH.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lbRekomendasi
            // 
            this.lbRekomendasi.AutoSize = true;
            this.lbRekomendasi.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbRekomendasi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbRekomendasi.Location = new System.Drawing.Point(114, 238);
            this.lbRekomendasi.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRekomendasi.Name = "lbRekomendasi";
            this.lbRekomendasi.Size = new System.Drawing.Size(363, 40);
            this.lbRekomendasi.TabIndex = 2;
            this.lbRekomendasi.Text = "Rekomendasi Hari ini ";
            // 
            // lbPengeluaran
            // 
            this.lbPengeluaran.AutoSize = true;
            this.lbPengeluaran.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbPengeluaran.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbPengeluaran.Location = new System.Drawing.Point(114, 396);
            this.lbPengeluaran.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbPengeluaran.Name = "lbPengeluaran";
            this.lbPengeluaran.Size = new System.Drawing.Size(238, 40);
            this.lbPengeluaran.TabIndex = 3;
            this.lbPengeluaran.Text = "Pengeluaran ";
            this.lbPengeluaran.Click += new System.EventHandler(this.label2_Click);
            // 
            // dgvPengeluaranH
            // 
            this.dgvPengeluaranH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPengeluaranH.Location = new System.Drawing.Point(114, 438);
            this.dgvPengeluaranH.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPengeluaranH.Name = "dgvPengeluaranH";
            this.dgvPengeluaranH.RowHeadersWidth = 62;
            this.dgvPengeluaranH.RowTemplate.Height = 33;
            this.dgvPengeluaranH.Size = new System.Drawing.Size(288, 66);
            this.dgvPengeluaranH.TabIndex = 4;
            // 
            // lblSisa
            // 
            this.lblSisa.AutoSize = true;
            this.lblSisa.Font = new System.Drawing.Font("Century Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSisa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lblSisa.Location = new System.Drawing.Point(114, 558);
            this.lblSisa.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSisa.Name = "lblSisa";
            this.lblSisa.Size = new System.Drawing.Size(174, 40);
            this.lblSisa.TabIndex = 5;
            this.lblSisa.Text = "Sisa Uang";
            // 
            // dgvSisaH
            // 
            this.dgvSisaH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSisaH.Location = new System.Drawing.Point(114, 606);
            this.dgvSisaH.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSisaH.Name = "dgvSisaH";
            this.dgvSisaH.RowHeadersWidth = 62;
            this.dgvSisaH.RowTemplate.Height = 33;
            this.dgvSisaH.Size = new System.Drawing.Size(288, 66);
            this.dgvSisaH.TabIndex = 6;
            // 
            // lblProfilH
            // 
            this.lblProfilH.AutoSize = true;
            this.lblProfilH.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblProfilH.Location = new System.Drawing.Point(964, 90);
            this.lblProfilH.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblProfilH.Name = "lblProfilH";
            this.lblProfilH.Size = new System.Drawing.Size(81, 20);
            this.lblProfilH.TabIndex = 7;
            this.lblProfilH.Text = "Abi Mana";
            // 
            // llHome
            // 
            this.llHome.AutoSize = true;
            this.llHome.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.llHome.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.llHome.Location = new System.Drawing.Point(367, 30);
            this.llHome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llHome.Name = "llHome";
            this.llHome.Size = new System.Drawing.Size(59, 21);
            this.llHome.TabIndex = 8;
            this.llHome.TabStop = true;
            this.llHome.Text = "Home";
            // 
            // llCalendar
            // 
            this.llCalendar.AutoSize = true;
            this.llCalendar.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.llCalendar.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.llCalendar.Location = new System.Drawing.Point(541, 30);
            this.llCalendar.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llCalendar.Name = "llCalendar";
            this.llCalendar.Size = new System.Drawing.Size(73, 21);
            this.llCalendar.TabIndex = 9;
            this.llCalendar.TabStop = true;
            this.llCalendar.Text = "Income";
            this.llCalendar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llCalendar_LinkClicked);
            // 
            // llFinance
            // 
            this.llFinance.AutoSize = true;
            this.llFinance.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.llFinance.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.llFinance.Location = new System.Drawing.Point(730, 30);
            this.llFinance.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llFinance.Name = "llFinance";
            this.llFinance.Size = new System.Drawing.Size(90, 21);
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
            this.btnLogout.Location = new System.Drawing.Point(1016, 661);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnLogout.Size = new System.Drawing.Size(98, 104);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Logout";
            this.btnLogout.Click += new System.EventHandler(this.guna2CircleButton1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1134, 774);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.llFinance);
            this.Controls.Add(this.llCalendar);
            this.Controls.Add(this.llHome);
            this.Controls.Add(this.lblProfilH);
            this.Controls.Add(this.dgvSisaH);
            this.Controls.Add(this.lblSisa);
            this.Controls.Add(this.dgvPengeluaranH);
            this.Controls.Add(this.lbPengeluaran);
            this.Controls.Add(this.lbRekomendasi);
            this.Controls.Add(this.dgvRekomendasiH);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form2";
            this.Text = "Homepage";
            ((System.ComponentModel.ISupportInitialize)(this.dgvRekomendasiH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPengeluaranH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSisaH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private DataGridView dgvRekomendasiH;
        private Label lbRekomendasi;
        private Label lbPengeluaran;
        private DataGridView dgvPengeluaranH;
        private Label lblSisa;
        private DataGridView dgvSisaH;
        private Label lblProfilH;
        private LinkLabel llHome;
        private LinkLabel llCalendar;
        private LinkLabel llFinance;
        private Guna.UI2.WinForms.Guna2CircleButton btnLogout;
    }
}