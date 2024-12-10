namespace UTS_NET
{
    partial class Penumpang
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
            this.btn_AddBus = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Alamat = new System.Windows.Forms.TextBox();
            this.NoTelepon = new System.Windows.Forms.TextBox();
            this.EmailPelanggan = new System.Windows.Forms.TextBox();
            this.NamaPenumpang = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.IdPenumpang = new System.Windows.Forms.TextBox();
            this.Tujuan = new System.Windows.Forms.Label();
            this.awal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabelPenumpang = new System.Windows.Forms.DataGridView();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_kembali = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelPenumpang)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_AddBus
            // 
            this.btn_AddBus.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddBus.Location = new System.Drawing.Point(925, 271);
            this.btn_AddBus.Name = "btn_AddBus";
            this.btn_AddBus.Size = new System.Drawing.Size(117, 65);
            this.btn_AddBus.TabIndex = 80;
            this.btn_AddBus.Text = "insert";
            this.btn_AddBus.UseVisualStyleBackColor = true;
            this.btn_AddBus.Click += new System.EventHandler(this.btn_AddBus_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Alamat);
            this.groupBox1.Controls.Add(this.NoTelepon);
            this.groupBox1.Controls.Add(this.EmailPelanggan);
            this.groupBox1.Controls.Add(this.NamaPenumpang);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.IdPenumpang);
            this.groupBox1.Controls.Add(this.Tujuan);
            this.groupBox1.Controls.Add(this.awal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(293, 271);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 294);
            this.groupBox1.TabIndex = 79;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "record new account";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Alamat
            // 
            this.Alamat.Location = new System.Drawing.Point(157, 225);
            this.Alamat.Name = "Alamat";
            this.Alamat.Size = new System.Drawing.Size(197, 20);
            this.Alamat.TabIndex = 71;
            this.Alamat.TextChanged += new System.EventHandler(this.Alamat_TextChanged);
            // 
            // NoTelepon
            // 
            this.NoTelepon.Location = new System.Drawing.Point(157, 188);
            this.NoTelepon.Name = "NoTelepon";
            this.NoTelepon.Size = new System.Drawing.Size(197, 20);
            this.NoTelepon.TabIndex = 70;
            this.NoTelepon.TextChanged += new System.EventHandler(this.NoPhone_TextChanged);
            // 
            // EmailPelanggan
            // 
            this.EmailPelanggan.Location = new System.Drawing.Point(157, 147);
            this.EmailPelanggan.Name = "EmailPelanggan";
            this.EmailPelanggan.Size = new System.Drawing.Size(197, 20);
            this.EmailPelanggan.TabIndex = 69;
            this.EmailPelanggan.TextChanged += new System.EventHandler(this.EmailPelanggan_TextChanged);
            // 
            // NamaPenumpang
            // 
            this.NamaPenumpang.Location = new System.Drawing.Point(157, 100);
            this.NamaPenumpang.Name = "NamaPenumpang";
            this.NamaPenumpang.Size = new System.Drawing.Size(197, 20);
            this.NamaPenumpang.TabIndex = 68;
            this.NamaPenumpang.TextChanged += new System.EventHandler(this.NamaPelanggan_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 15);
            this.label2.TabIndex = 66;
            this.label2.Text = "Alamat";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(60, 188);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 15);
            this.label7.TabIndex = 64;
            this.label7.Text = "No Telfon";
            // 
            // IdPenumpang
            // 
            this.IdPenumpang.Location = new System.Drawing.Point(157, 59);
            this.IdPenumpang.Name = "IdPenumpang";
            this.IdPenumpang.Size = new System.Drawing.Size(197, 20);
            this.IdPenumpang.TabIndex = 60;
            this.IdPenumpang.TextChanged += new System.EventHandler(this.IdPelanggan_TextChanged);
            // 
            // Tujuan
            // 
            this.Tujuan.AutoSize = true;
            this.Tujuan.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tujuan.Location = new System.Drawing.Point(60, 147);
            this.Tujuan.Name = "Tujuan";
            this.Tujuan.Size = new System.Drawing.Size(48, 15);
            this.Tujuan.TabIndex = 58;
            this.Tujuan.Text = "Email";
            // 
            // awal
            // 
            this.awal.AutoSize = true;
            this.awal.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.awal.Location = new System.Drawing.Point(60, 100);
            this.awal.Name = "awal";
            this.awal.Size = new System.Drawing.Size(48, 15);
            this.awal.TabIndex = 57;
            this.awal.Text = "Nama ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 15);
            this.label3.TabIndex = 56;
            this.label3.Text = "id pelanggan";
            // 
            // tabelPenumpang
            // 
            this.tabelPenumpang.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabelPenumpang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelPenumpang.Location = new System.Drawing.Point(176, 601);
            this.tabelPenumpang.Name = "tabelPenumpang";
            this.tabelPenumpang.Size = new System.Drawing.Size(1004, 261);
            this.tabelPenumpang.TabIndex = 78;
            this.tabelPenumpang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelPenumpang_CellContentClick);
            // 
            // btn_hapus
            // 
            this.btn_hapus.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hapus.Location = new System.Drawing.Point(761, 377);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(117, 65);
            this.btn_hapus.TabIndex = 77;
            this.btn_hapus.Text = "hapus";
            this.btn_hapus.UseVisualStyleBackColor = true;
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(761, 271);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(117, 65);
            this.btn_edit.TabIndex = 76;
            this.btn_edit.Text = "update";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_kembali
            // 
            this.btn_kembali.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kembali.Location = new System.Drawing.Point(761, 494);
            this.btn_kembali.Name = "btn_kembali";
            this.btn_kembali.Size = new System.Drawing.Size(281, 65);
            this.btn_kembali.TabIndex = 75;
            this.btn_kembali.Text = "kembali";
            this.btn_kembali.UseVisualStyleBackColor = true;
            this.btn_kembali.Click += new System.EventHandler(this.btn_kembali_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(925, 377);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(117, 65);
            this.btn_Reset.TabIndex = 74;
            this.btn_Reset.Text = "reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(478, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 112);
            this.label1.TabIndex = 73;
            this.label1.Text = "Welcome \r\nPENUMPANG";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Penumpang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::UTS_NET.Properties.Resources.lovepik_a_driving_bus_background_image_400149197;
            this.ClientSize = new System.Drawing.Size(1329, 898);
            this.Controls.Add(this.btn_AddBus);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabelPenumpang);
            this.Controls.Add(this.btn_hapus);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_kembali);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.label1);
            this.Name = "Penumpang";
            this.Text = "Penumpang";
            this.Load += new System.EventHandler(this.Penumpang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelPenumpang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AddBus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox IdPenumpang;
        private System.Windows.Forms.Label Tujuan;
        private System.Windows.Forms.Label awal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView tabelPenumpang;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_kembali;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NamaPenumpang;
        private System.Windows.Forms.TextBox EmailPelanggan;
        private System.Windows.Forms.TextBox Alamat;
        private System.Windows.Forms.TextBox NoTelepon;
    }
}