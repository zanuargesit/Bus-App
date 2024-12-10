namespace UTS_NET
{
    partial class Jadwal_Bus
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
            this.tabelBus = new System.Windows.Forms.DataGridView();
            this.btn_hapus = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.btn_kembali = new System.Windows.Forms.Button();
            this.btn_Reset = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.destinasi = new System.Windows.Forms.ComboBox();
            this.asal = new System.Windows.Forms.ComboBox();
            this.JmlKursi = new System.Windows.Forms.TextBox();
            this.Cd_Bus = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Tujuan = new System.Windows.Forms.Label();
            this.awal = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.waktu = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.Time = new System.Windows.Forms.DateTimePicker();
            this.btn_AddBus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabelBus)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabelBus
            // 
            this.tabelBus.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabelBus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelBus.Location = new System.Drawing.Point(83, 394);
            this.tabelBus.Name = "tabelBus";
            this.tabelBus.Size = new System.Drawing.Size(1034, 228);
            this.tabelBus.TabIndex = 70;
            this.tabelBus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelBus_CellContentClick);
            // 
            // btn_hapus
            // 
            this.btn_hapus.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hapus.Location = new System.Drawing.Point(734, 215);
            this.btn_hapus.Name = "btn_hapus";
            this.btn_hapus.Size = new System.Drawing.Size(117, 65);
            this.btn_hapus.TabIndex = 69;
            this.btn_hapus.Text = "hapus";
            this.btn_hapus.UseVisualStyleBackColor = true;
            this.btn_hapus.Click += new System.EventHandler(this.btn_hapus_Click);
            // 
            // btn_edit
            // 
            this.btn_edit.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_edit.Location = new System.Drawing.Point(734, 112);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(117, 65);
            this.btn_edit.TabIndex = 68;
            this.btn_edit.Text = "update";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // btn_kembali
            // 
            this.btn_kembali.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_kembali.Location = new System.Drawing.Point(734, 308);
            this.btn_kembali.Name = "btn_kembali";
            this.btn_kembali.Size = new System.Drawing.Size(281, 65);
            this.btn_kembali.TabIndex = 67;
            this.btn_kembali.Text = "kembali";
            this.btn_kembali.UseVisualStyleBackColor = true;
            this.btn_kembali.Click += new System.EventHandler(this.btn_kembali_Click);
            // 
            // btn_Reset
            // 
            this.btn_Reset.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Reset.Location = new System.Drawing.Point(898, 212);
            this.btn_Reset.Name = "btn_Reset";
            this.btn_Reset.Size = new System.Drawing.Size(117, 65);
            this.btn_Reset.TabIndex = 66;
            this.btn_Reset.Text = "reset";
            this.btn_Reset.UseVisualStyleBackColor = true;
            this.btn_Reset.Click += new System.EventHandler(this.btn_Reset_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(14, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 15);
            this.label7.TabIndex = 64;
            this.label7.Text = "date";
            // 
            // destinasi
            // 
            this.destinasi.FormattingEnabled = true;
            this.destinasi.Items.AddRange(new object[] {
            "jogja",
            "malang",
            "bandung",
            "bali"});
            this.destinasi.Location = new System.Drawing.Point(111, 107);
            this.destinasi.Name = "destinasi";
            this.destinasi.Size = new System.Drawing.Size(197, 21);
            this.destinasi.TabIndex = 63;
            // 
            // asal
            // 
            this.asal.FormattingEnabled = true;
            this.asal.Items.AddRange(new object[] {
            "jakarta",
            "surabaya",
            "purwokerto",
            "banjarnegara"});
            this.asal.Location = new System.Drawing.Point(111, 68);
            this.asal.Name = "asal";
            this.asal.Size = new System.Drawing.Size(197, 21);
            this.asal.TabIndex = 62;
            // 
            // JmlKursi
            // 
            this.JmlKursi.Location = new System.Drawing.Point(111, 233);
            this.JmlKursi.Name = "JmlKursi";
            this.JmlKursi.Size = new System.Drawing.Size(197, 20);
            this.JmlKursi.TabIndex = 61;
            // 
            // Cd_Bus
            // 
            this.Cd_Bus.Location = new System.Drawing.Point(111, 27);
            this.Cd_Bus.Name = "Cd_Bus";
            this.Cd_Bus.Size = new System.Drawing.Size(197, 20);
            this.Cd_Bus.TabIndex = 60;
            this.Cd_Bus.TextChanged += new System.EventHandler(this.Cd_Bus_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 236);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 15);
            this.label6.TabIndex = 59;
            this.label6.Text = "num of seats";
            // 
            // Tujuan
            // 
            this.Tujuan.AutoSize = true;
            this.Tujuan.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tujuan.Location = new System.Drawing.Point(14, 115);
            this.Tujuan.Name = "Tujuan";
            this.Tujuan.Size = new System.Drawing.Size(24, 15);
            this.Tujuan.TabIndex = 58;
            this.Tujuan.Text = "To";
            // 
            // awal
            // 
            this.awal.AutoSize = true;
            this.awal.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.awal.Location = new System.Drawing.Point(14, 68);
            this.awal.Name = "awal";
            this.awal.Size = new System.Drawing.Size(44, 15);
            this.awal.TabIndex = 57;
            this.awal.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(14, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 15);
            this.label3.TabIndex = 56;
            this.label3.Text = "bus code";
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
            this.label1.Location = new System.Drawing.Point(312, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(518, 57);
            this.label1.TabIndex = 54;
            this.label1.Text = "Welcome Bus Travel";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.waktu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Time);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.destinasi);
            this.groupBox1.Controls.Add(this.asal);
            this.groupBox1.Controls.Add(this.JmlKursi);
            this.groupBox1.Controls.Add(this.Cd_Bus);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.Tujuan);
            this.groupBox1.Controls.Add(this.awal);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(207, 113);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 276);
            this.groupBox1.TabIndex = 71;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "record new order";
            // 
            // waktu
            // 
            this.waktu.CustomFormat = "00:00";
            this.waktu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.waktu.Location = new System.Drawing.Point(111, 193);
            this.waktu.Name = "waktu";
            this.waktu.ShowUpDown = true;
            this.waktu.Size = new System.Drawing.Size(197, 20);
            this.waktu.TabIndex = 67;
            this.waktu.Value = new System.DateTime(2024, 11, 6, 21, 56, 0, 0);
            this.waktu.ValueChanged += new System.EventHandler(this.waktu_ValueChanged);
            this.waktu.MouseCaptureChanged += new System.EventHandler(this.waktu_MouseCaptureChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 66;
            this.label2.Text = "time";
            // 
            // Time
            // 
            this.Time.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Time.Location = new System.Drawing.Point(111, 156);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(197, 20);
            this.Time.TabIndex = 65;
            this.Time.ValueChanged += new System.EventHandler(this.Time_ValueChanged);
            this.Time.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Time_KeyDown);
            // 
            // btn_AddBus
            // 
            this.btn_AddBus.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AddBus.Location = new System.Drawing.Point(898, 113);
            this.btn_AddBus.Name = "btn_AddBus";
            this.btn_AddBus.Size = new System.Drawing.Size(117, 65);
            this.btn_AddBus.TabIndex = 72;
            this.btn_AddBus.Text = "insert";
            this.btn_AddBus.UseVisualStyleBackColor = true;
            this.btn_AddBus.Click += new System.EventHandler(this.btn_AddBus_Click);
            // 
            // Jadwal_Bus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::UTS_NET.Properties.Resources.lovepik_a_driving_bus_background_image_400149197;
            this.ClientSize = new System.Drawing.Size(1193, 634);
            this.Controls.Add(this.btn_AddBus);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tabelBus);
            this.Controls.Add(this.btn_hapus);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.btn_kembali);
            this.Controls.Add(this.btn_Reset);
            this.Controls.Add(this.label1);
            this.Name = "Jadwal_Bus";
            this.Text = "Jadwal_Bus";
            this.Load += new System.EventHandler(this.Jadwal_Bus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabelBus)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView tabelBus;
        private System.Windows.Forms.Button btn_hapus;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button btn_kembali;
        private System.Windows.Forms.Button btn_Reset;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox destinasi;
        private System.Windows.Forms.ComboBox asal;
        private System.Windows.Forms.TextBox JmlKursi;
        private System.Windows.Forms.TextBox Cd_Bus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label Tujuan;
        private System.Windows.Forms.Label awal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_AddBus;
        private System.Windows.Forms.DateTimePicker waktu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker Time;
    }
}