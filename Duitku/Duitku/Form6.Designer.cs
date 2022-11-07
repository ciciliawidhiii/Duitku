namespace Duitku
{
    partial class Form6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form6));
            this.tbUangAwal = new System.Windows.Forms.TextBox();
            this.llIncome = new System.Windows.Forms.LinkLabel();
            this.llHome = new System.Windows.Forms.LinkLabel();
            this.lbUangAwal = new System.Windows.Forms.Label();
            this.lbRp = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbJangkaWaktu = new System.Windows.Forms.Label();
            this.tbJangkaWaktu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTabungan = new System.Windows.Forms.Label();
            this.tbTabungan = new System.Windows.Forms.TextBox();
            this.btnAddFinance = new System.Windows.Forms.Button();
            this.dgvReccom = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.llOutcome = new System.Windows.Forms.LinkLabel();
            this.lbKetUangAwal = new System.Windows.Forms.Label();
            this.lblKetJangkaWaktu = new System.Windows.Forms.Label();
            this.lbKetTabungan = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblKetDanaMasuk = new System.Windows.Forms.Label();
            this.lbDateMasuk = new System.Windows.Forms.Label();
            this.dtpDanaMasuk = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReccom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tbUangAwal
            // 
            this.tbUangAwal.Location = new System.Drawing.Point(132, 142);
            this.tbUangAwal.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbUangAwal.Name = "tbUangAwal";
            this.tbUangAwal.Size = new System.Drawing.Size(210, 27);
            this.tbUangAwal.TabIndex = 0;
            // 
            // llIncome
            // 
            this.llIncome.AutoSize = true;
            this.llIncome.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.llIncome.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.llIncome.Location = new System.Drawing.Point(558, 25);
            this.llIncome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llIncome.Name = "llIncome";
            this.llIncome.Size = new System.Drawing.Size(73, 21);
            this.llIncome.TabIndex = 13;
            this.llIncome.TabStop = true;
            this.llIncome.Text = "Income";
            // 
            // llHome
            // 
            this.llHome.AutoSize = true;
            this.llHome.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.llHome.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.llHome.Location = new System.Drawing.Point(342, 25);
            this.llHome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llHome.Name = "llHome";
            this.llHome.Size = new System.Drawing.Size(59, 21);
            this.llHome.TabIndex = 11;
            this.llHome.TabStop = true;
            this.llHome.Text = "Home";
            this.llHome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llHome_LinkClicked);
            // 
            // lbUangAwal
            // 
            this.lbUangAwal.AutoSize = true;
            this.lbUangAwal.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbUangAwal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbUangAwal.Location = new System.Drawing.Point(122, 107);
            this.lbUangAwal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUangAwal.Name = "lbUangAwal";
            this.lbUangAwal.Size = new System.Drawing.Size(161, 30);
            this.lbUangAwal.TabIndex = 14;
            this.lbUangAwal.Text = "Dana Masuk";
            // 
            // lbRp
            // 
            this.lbRp.AutoSize = true;
            this.lbRp.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbRp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbRp.Location = new System.Drawing.Point(84, 139);
            this.lbRp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRp.Name = "lbRp";
            this.lbRp.Size = new System.Drawing.Size(44, 30);
            this.lbRp.TabIndex = 15;
            this.lbRp.Text = "Rp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(84, 270);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 30);
            this.label1.TabIndex = 18;
            // 
            // lbJangkaWaktu
            // 
            this.lbJangkaWaktu.AutoSize = true;
            this.lbJangkaWaktu.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbJangkaWaktu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbJangkaWaktu.Location = new System.Drawing.Point(122, 238);
            this.lbJangkaWaktu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbJangkaWaktu.Name = "lbJangkaWaktu";
            this.lbJangkaWaktu.Size = new System.Drawing.Size(181, 30);
            this.lbJangkaWaktu.TabIndex = 17;
            this.lbJangkaWaktu.Text = "Jangka Waktu";
            // 
            // tbJangkaWaktu
            // 
            this.tbJangkaWaktu.Location = new System.Drawing.Point(132, 274);
            this.tbJangkaWaktu.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbJangkaWaktu.Name = "tbJangkaWaktu";
            this.tbJangkaWaktu.Size = new System.Drawing.Size(210, 27);
            this.tbJangkaWaktu.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label2.Location = new System.Drawing.Point(84, 406);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 30);
            this.label2.TabIndex = 21;
            this.label2.Text = "Rp";
            // 
            // lbTabungan
            // 
            this.lbTabungan.AutoSize = true;
            this.lbTabungan.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbTabungan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbTabungan.Location = new System.Drawing.Point(122, 374);
            this.lbTabungan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTabungan.Name = "lbTabungan";
            this.lbTabungan.Size = new System.Drawing.Size(133, 30);
            this.lbTabungan.TabIndex = 20;
            this.lbTabungan.Text = "Tabungan";
            // 
            // tbTabungan
            // 
            this.tbTabungan.Location = new System.Drawing.Point(132, 410);
            this.tbTabungan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTabungan.Name = "tbTabungan";
            this.tbTabungan.Size = new System.Drawing.Size(210, 27);
            this.tbTabungan.TabIndex = 19;
            // 
            // btnAddFinance
            // 
            this.btnAddFinance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnAddFinance.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddFinance.ForeColor = System.Drawing.Color.White;
            this.btnAddFinance.Location = new System.Drawing.Point(145, 669);
            this.btnAddFinance.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddFinance.Name = "btnAddFinance";
            this.btnAddFinance.Size = new System.Drawing.Size(169, 50);
            this.btnAddFinance.TabIndex = 22;
            this.btnAddFinance.Text = "Add";
            this.btnAddFinance.UseVisualStyleBackColor = false;
            // 
            // dgvReccom
            // 
            this.dgvReccom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReccom.Location = new System.Drawing.Point(689, 194);
            this.dgvReccom.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvReccom.Name = "dgvReccom";
            this.dgvReccom.RowHeadersWidth = 62;
            this.dgvReccom.RowTemplate.Height = 33;
            this.dgvReccom.Size = new System.Drawing.Size(305, 180);
            this.dgvReccom.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label3.Location = new System.Drawing.Point(694, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(318, 30);
            this.label3.TabIndex = 24;
            this.label3.Text = "Rekomendasi untuk Anda";
            // 
            // llOutcome
            // 
            this.llOutcome.AutoSize = true;
            this.llOutcome.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.llOutcome.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.llOutcome.Location = new System.Drawing.Point(760, 25);
            this.llOutcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.llOutcome.Name = "llOutcome";
            this.llOutcome.Size = new System.Drawing.Size(90, 21);
            this.llOutcome.TabIndex = 25;
            this.llOutcome.TabStop = true;
            this.llOutcome.Text = "Outcome";
            this.llOutcome.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llOutcome_LinkClicked);
            // 
            // lbKetUangAwal
            // 
            this.lbKetUangAwal.AutoSize = true;
            this.lbKetUangAwal.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbKetUangAwal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbKetUangAwal.Location = new System.Drawing.Point(122, 178);
            this.lbKetUangAwal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbKetUangAwal.Name = "lbKetUangAwal";
            this.lbKetUangAwal.Size = new System.Drawing.Size(326, 17);
            this.lbKetUangAwal.TabIndex = 26;
            this.lbKetUangAwal.Text = "Masukkan uang Anda saat ini (dalam rupiah) ";
            // 
            // lblKetJangkaWaktu
            // 
            this.lblKetJangkaWaktu.AutoSize = true;
            this.lblKetJangkaWaktu.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblKetJangkaWaktu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblKetJangkaWaktu.Location = new System.Drawing.Point(122, 309);
            this.lblKetJangkaWaktu.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKetJangkaWaktu.Name = "lblKetJangkaWaktu";
            this.lblKetJangkaWaktu.Size = new System.Drawing.Size(407, 17);
            this.lblKetJangkaWaktu.TabIndex = 27;
            this.lblKetJangkaWaktu.Text = "Masukkan jumlah hari Anda akan menggunakan uang ini";
            // 
            // lbKetTabungan
            // 
            this.lbKetTabungan.AutoSize = true;
            this.lbKetTabungan.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lbKetTabungan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbKetTabungan.Location = new System.Drawing.Point(122, 446);
            this.lbKetTabungan.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbKetTabungan.Name = "lbKetTabungan";
            this.lbKetTabungan.Size = new System.Drawing.Size(538, 17);
            this.lbKetTabungan.TabIndex = 28;
            this.lbKetTabungan.Text = "Masukkan uang tabungan dalam rupiah (jika tidak ingin menabung isikan 0)";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(734, 430);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 205);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 40;
            this.pictureBox1.TabStop = false;
            // 
            // lblKetDanaMasuk
            // 
            this.lblKetDanaMasuk.AutoSize = true;
            this.lblKetDanaMasuk.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblKetDanaMasuk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblKetDanaMasuk.Location = new System.Drawing.Point(122, 571);
            this.lblKetDanaMasuk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblKetDanaMasuk.Name = "lblKetDanaMasuk";
            this.lblKetDanaMasuk.Size = new System.Drawing.Size(212, 17);
            this.lblKetDanaMasuk.TabIndex = 43;
            this.lblKetDanaMasuk.Text = "Masukkan uang masuk Anda ";
            // 
            // lbDateMasuk
            // 
            this.lbDateMasuk.AutoSize = true;
            this.lbDateMasuk.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbDateMasuk.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbDateMasuk.Location = new System.Drawing.Point(122, 504);
            this.lbDateMasuk.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDateMasuk.Name = "lbDateMasuk";
            this.lbDateMasuk.Size = new System.Drawing.Size(109, 30);
            this.lbDateMasuk.TabIndex = 42;
            this.lbDateMasuk.Text = "Tanggal";
            // 
            // dtpDanaMasuk
            // 
            this.dtpDanaMasuk.CalendarForeColor = System.Drawing.Color.Black;
            this.dtpDanaMasuk.CalendarTitleForeColor = System.Drawing.Color.Black;
            this.dtpDanaMasuk.Font = new System.Drawing.Font("Century Gothic", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpDanaMasuk.Location = new System.Drawing.Point(132, 545);
            this.dtpDanaMasuk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtpDanaMasuk.Name = "dtpDanaMasuk";
            this.dtpDanaMasuk.Size = new System.Drawing.Size(238, 24);
            this.dtpDanaMasuk.TabIndex = 41;
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1134, 774);
            this.Controls.Add(this.lblKetDanaMasuk);
            this.Controls.Add(this.lbDateMasuk);
            this.Controls.Add(this.dtpDanaMasuk);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbKetTabungan);
            this.Controls.Add(this.lblKetJangkaWaktu);
            this.Controls.Add(this.lbKetUangAwal);
            this.Controls.Add(this.llOutcome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvReccom);
            this.Controls.Add(this.btnAddFinance);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTabungan);
            this.Controls.Add(this.tbTabungan);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbJangkaWaktu);
            this.Controls.Add(this.tbJangkaWaktu);
            this.Controls.Add(this.lbRp);
            this.Controls.Add(this.lbUangAwal);
            this.Controls.Add(this.llIncome);
            this.Controls.Add(this.llHome);
            this.Controls.Add(this.tbUangAwal);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form6";
            this.Text = "Form6";
            ((System.ComponentModel.ISupportInitialize)(this.dgvReccom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox tbUangAwal;
        private LinkLabel llIncome;
        private LinkLabel llHome;
        private Label lbUangAwal;
        private Label lbRp;
        private Label label1;
        private Label lbJangkaWaktu;
        private TextBox tbJangkaWaktu;
        private Label label2;
        private Label lbTabungan;
        private TextBox tbTabungan;
        private Button btnAddFinance;
        private DataGridView dgvReccom;
        private Label label3;
        private LinkLabel llOutcome;
        private Label lbKetUangAwal;
        private Label lblKetJangkaWaktu;
        private Label lbKetTabungan;
        private PictureBox pictureBox1;
        private Label lblKetDanaMasuk;
        private Label lbDateMasuk;
        private DateTimePicker dtpDanaMasuk;
    }
}