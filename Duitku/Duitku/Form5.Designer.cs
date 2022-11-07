namespace Duitku
{
    partial class Form5
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
            this.components = new System.ComponentModel.Container();
            this.guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.guna2ContainerControl1 = new Guna.UI2.WinForms.Guna2ContainerControl();
            this.label1 = new System.Windows.Forms.Label();
            this.btnYesLogout = new Guna.UI2.WinForms.Guna2Button();
            this.btnNotLogout = new Guna.UI2.WinForms.Guna2Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2ContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2ContainerControl1
            // 
            this.guna2ContainerControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ContainerControl1.BackColor = System.Drawing.Color.IndianRed;
            this.guna2ContainerControl1.BorderRadius = 50;
            this.guna2ContainerControl1.Controls.Add(this.pictureBox1);
            this.guna2ContainerControl1.Controls.Add(this.btnNotLogout);
            this.guna2ContainerControl1.Controls.Add(this.btnYesLogout);
            this.guna2ContainerControl1.Controls.Add(this.label1);
            this.guna2ContainerControl1.FillColor = System.Drawing.Color.IndianRed;
            this.guna2ContainerControl1.Location = new System.Drawing.Point(69, 46);
            this.guna2ContainerControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2ContainerControl1.Name = "guna2ContainerControl1";
            this.guna2ContainerControl1.Size = new System.Drawing.Size(799, 490);
            this.guna2ContainerControl1.TabIndex = 0;
            this.guna2ContainerControl1.Text = "guna2ContainerControl1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Snow;
            this.label1.Location = new System.Drawing.Point(82, 100);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(646, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Apakah anda benar-benar ingin logout?";
            // 
            // btnYesLogout
            // 
            this.btnYesLogout.BorderRadius = 30;
            this.btnYesLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnYesLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnYesLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnYesLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnYesLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnYesLogout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnYesLogout.ForeColor = System.Drawing.Color.Brown;
            this.btnYesLogout.Location = new System.Drawing.Point(82, 366);
            this.btnYesLogout.Name = "btnYesLogout";
            this.btnYesLogout.Size = new System.Drawing.Size(270, 68);
            this.btnYesLogout.TabIndex = 1;
            this.btnYesLogout.Text = "Yes";
            // 
            // btnNotLogout
            // 
            this.btnNotLogout.BorderRadius = 30;
            this.btnNotLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNotLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNotLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNotLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNotLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnNotLogout.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNotLogout.ForeColor = System.Drawing.Color.Brown;
            this.btnNotLogout.Location = new System.Drawing.Point(444, 366);
            this.btnNotLogout.Name = "btnNotLogout";
            this.btnNotLogout.Size = new System.Drawing.Size(270, 68);
            this.btnNotLogout.TabIndex = 2;
            this.btnNotLogout.Text = "No";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Duitku.Properties.Resources.crying_pig;
            this.pictureBox1.Location = new System.Drawing.Point(314, 163);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(170, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(940, 586);
            this.Controls.Add(this.guna2ContainerControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form5";
            this.Text = "Form5";
            this.guna2ContainerControl1.ResumeLayout(false);
            this.guna2ContainerControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        private Guna.UI2.WinForms.Guna2ContainerControl guna2ContainerControl1;
        private Label label1;
        private PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnNotLogout;
        private Guna.UI2.WinForms.Guna2Button btnYesLogout;
    }
}