namespace UTS_NET
{
    partial class Dasboard
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
            this.LoginPesanan = new System.Windows.Forms.Button();
            this.LoginJadwal = new System.Windows.Forms.Button();
            this.LoginPenumpang = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginPesanan
            // 
            this.LoginPesanan.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPesanan.Location = new System.Drawing.Point(66, 313);
            this.LoginPesanan.Name = "LoginPesanan";
            this.LoginPesanan.Size = new System.Drawing.Size(188, 48);
            this.LoginPesanan.TabIndex = 0;
            this.LoginPesanan.Text = "Login Pesanan";
            this.LoginPesanan.UseVisualStyleBackColor = true;
            this.LoginPesanan.Click += new System.EventHandler(this.LoginPesanan_Click);
            // 
            // LoginJadwal
            // 
            this.LoginJadwal.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginJadwal.Location = new System.Drawing.Point(317, 313);
            this.LoginJadwal.Name = "LoginJadwal";
            this.LoginJadwal.Size = new System.Drawing.Size(194, 51);
            this.LoginJadwal.TabIndex = 1;
            this.LoginJadwal.Text = "Login Jadwal";
            this.LoginJadwal.UseVisualStyleBackColor = true;
            this.LoginJadwal.Click += new System.EventHandler(this.LoginJadwal_Click);
            // 
            // LoginPenumpang
            // 
            this.LoginPenumpang.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginPenumpang.Location = new System.Drawing.Point(567, 313);
            this.LoginPenumpang.Name = "LoginPenumpang";
            this.LoginPenumpang.Size = new System.Drawing.Size(170, 51);
            this.LoginPenumpang.TabIndex = 2;
            this.LoginPenumpang.Text = "Login Penumpang";
            this.LoginPenumpang.UseVisualStyleBackColor = true;
            this.LoginPenumpang.Click += new System.EventHandler(this.LoginPenumpang_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(254, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 55);
            this.label1.TabIndex = 3;
            this.label1.Text = "DASHBOARD";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UTS_NET.Properties.Resources.download;
            this.pictureBox1.Location = new System.Drawing.Point(66, 195);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UTS_NET.Properties.Resources.schedule_icon_or_logo_isolated_sign_symbol_vector_36735700;
            this.pictureBox2.Location = new System.Drawing.Point(317, 194);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(188, 112);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::UTS_NET.Properties.Resources.images;
            this.pictureBox3.Location = new System.Drawing.Point(567, 194);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(170, 112);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // Dasboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UTS_NET.Properties.Resources.lovepik_a_driving_bus_background_image_400149197;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LoginPenumpang);
            this.Controls.Add(this.LoginJadwal);
            this.Controls.Add(this.LoginPesanan);
            this.Name = "Dasboard";
            this.Text = "Dasboard";
            this.Load += new System.EventHandler(this.Dasboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LoginPesanan;
        private System.Windows.Forms.Button LoginJadwal;
        private System.Windows.Forms.Button LoginPenumpang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}