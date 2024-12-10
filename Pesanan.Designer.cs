namespace UTS_NET
{
    partial class Pesanan
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.JmlKursi = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_cari = new System.Windows.Forms.Button();
            this.destinasi = new System.Windows.Forms.ComboBox();
            this.asal = new System.Windows.Forms.ComboBox();
            this.Tujuan = new System.Windows.Forms.Label();
            this.awal = new System.Windows.Forms.Label();
            this.tabelBus = new System.Windows.Forms.DataGridView();
            this.TabelPesanan = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnHapus = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.Email = new System.Windows.Forms.TextBox();
            this.NoKursi = new System.Windows.Forms.ComboBox();
            this.Total = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Tgl_Pesanan = new System.Windows.Forms.DateTimePicker();
            this.addPesanan = new System.Windows.Forms.Button();
            this.idPesan = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Nama_Pelanggan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbPenumpang = new System.Windows.Forms.ComboBox();
            this.cbBus = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Cd_Bus = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelBus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabelPesanan)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.JmlKursi);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btn_cari);
            this.groupBox1.Controls.Add(this.destinasi);
            this.groupBox1.Controls.Add(this.asal);
            this.groupBox1.Controls.Add(this.Tujuan);
            this.groupBox1.Controls.Add(this.awal);
            this.groupBox1.Location = new System.Drawing.Point(40, 144);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 246);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "record new order";
            // 
            // JmlKursi
            // 
            this.JmlKursi.Location = new System.Drawing.Point(166, 118);
            this.JmlKursi.Name = "JmlKursi";
            this.JmlKursi.Size = new System.Drawing.Size(197, 20);
            this.JmlKursi.TabIndex = 74;
            this.JmlKursi.TextChanged += new System.EventHandler(this.JmlKursi_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(39, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 15);
            this.label6.TabIndex = 73;
            this.label6.Text = "num of seats";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // btn_cari
            // 
            this.btn_cari.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cari.Location = new System.Drawing.Point(288, 150);
            this.btn_cari.Name = "btn_cari";
            this.btn_cari.Size = new System.Drawing.Size(75, 23);
            this.btn_cari.TabIndex = 72;
            this.btn_cari.Text = "Cari";
            this.btn_cari.UseVisualStyleBackColor = true;
            this.btn_cari.Click += new System.EventHandler(this.btn_cari_Click);
            // 
            // destinasi
            // 
            this.destinasi.FormattingEnabled = true;
            this.destinasi.Items.AddRange(new object[] {
            "jogja",
            "malang",
            "bandung",
            "bali"});
            this.destinasi.Location = new System.Drawing.Point(166, 77);
            this.destinasi.Name = "destinasi";
            this.destinasi.Size = new System.Drawing.Size(197, 21);
            this.destinasi.TabIndex = 63;
            this.destinasi.SelectedIndexChanged += new System.EventHandler(this.destinasi_SelectedIndexChanged);
            // 
            // asal
            // 
            this.asal.FormattingEnabled = true;
            this.asal.Items.AddRange(new object[] {
            "jakarta",
            "surabaya",
            "purwokerto",
            "banjarnegara"});
            this.asal.Location = new System.Drawing.Point(166, 38);
            this.asal.Name = "asal";
            this.asal.Size = new System.Drawing.Size(197, 21);
            this.asal.TabIndex = 62;
            this.asal.SelectedIndexChanged += new System.EventHandler(this.asal_SelectedIndexChanged);
            // 
            // Tujuan
            // 
            this.Tujuan.AutoSize = true;
            this.Tujuan.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tujuan.Location = new System.Drawing.Point(39, 85);
            this.Tujuan.Name = "Tujuan";
            this.Tujuan.Size = new System.Drawing.Size(24, 15);
            this.Tujuan.TabIndex = 58;
            this.Tujuan.Text = "To";
            // 
            // awal
            // 
            this.awal.AutoSize = true;
            this.awal.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.awal.Location = new System.Drawing.Point(39, 38);
            this.awal.Name = "awal";
            this.awal.Size = new System.Drawing.Size(44, 15);
            this.awal.TabIndex = 57;
            this.awal.Text = "From";
            // 
            // tabelBus
            // 
            this.tabelBus.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabelBus.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelBus.Location = new System.Drawing.Point(474, 144);
            this.tabelBus.Name = "tabelBus";
            this.tabelBus.Size = new System.Drawing.Size(831, 261);
            this.tabelBus.TabIndex = 72;
            this.tabelBus.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabelBus_CellContentClick);
            // 
            // TabelPesanan
            // 
            this.TabelPesanan.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.TabelPesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TabelPesanan.Location = new System.Drawing.Point(40, 433);
            this.TabelPesanan.Name = "TabelPesanan";
            this.TabelPesanan.Size = new System.Drawing.Size(772, 463);
            this.TabelPesanan.TabIndex = 73;
            this.TabelPesanan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TabelPesanan_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Cd_Bus);
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.btnHapus);
            this.groupBox2.Controls.Add(this.btnEdit);
            this.groupBox2.Controls.Add(this.Email);
            this.groupBox2.Controls.Add(this.NoKursi);
            this.groupBox2.Controls.Add(this.Total);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Tgl_Pesanan);
            this.groupBox2.Controls.Add(this.addPesanan);
            this.groupBox2.Controls.Add(this.idPesan);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.Nama_Pelanggan);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(832, 551);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(473, 345);
            this.groupBox2.TabIndex = 73;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "record new order";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(58, 316);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 86;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnHapus
            // 
            this.btnHapus.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHapus.Location = new System.Drawing.Point(160, 316);
            this.btnHapus.Name = "btnHapus";
            this.btnHapus.Size = new System.Drawing.Size(75, 23);
            this.btnHapus.TabIndex = 85;
            this.btnHapus.Text = "Hapus";
            this.btnHapus.UseVisualStyleBackColor = true;
            this.btnHapus.Click += new System.EventHandler(this.btnHapus_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(262, 316);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 84;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(217, 118);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(197, 20);
            this.Email.TabIndex = 83;
            this.Email.TextChanged += new System.EventHandler(this.Email_TextChanged);
            // 
            // NoKursi
            // 
            this.NoKursi.FormattingEnabled = true;
            this.NoKursi.Items.AddRange(new object[] {
            "jogja",
            "malang",
            "bandung",
            "bali"});
            this.NoKursi.Location = new System.Drawing.Point(217, 241);
            this.NoKursi.Name = "NoKursi";
            this.NoKursi.Size = new System.Drawing.Size(197, 21);
            this.NoKursi.TabIndex = 75;
            this.NoKursi.SelectedIndexChanged += new System.EventHandler(this.NoKursi_SelectedIndexChanged);
            // 
            // Total
            // 
            this.Total.Location = new System.Drawing.Point(217, 277);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(197, 20);
            this.Total.TabIndex = 82;
            this.Total.TextChanged += new System.EventHandler(this.Total_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(90, 241);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 15);
            this.label5.TabIndex = 80;
            this.label5.Text = "No Kursi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(90, 282);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 15);
            this.label4.TabIndex = 78;
            this.label4.Text = "Total Harga";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(90, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 15);
            this.label3.TabIndex = 76;
            this.label3.Text = "nama pelanggan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(90, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 15);
            this.label1.TabIndex = 75;
            this.label1.Text = "tgl pesanan";
            // 
            // Tgl_Pesanan
            // 
            this.Tgl_Pesanan.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Tgl_Pesanan.Location = new System.Drawing.Point(217, 165);
            this.Tgl_Pesanan.Name = "Tgl_Pesanan";
            this.Tgl_Pesanan.Size = new System.Drawing.Size(197, 20);
            this.Tgl_Pesanan.TabIndex = 74;
            this.Tgl_Pesanan.ValueChanged += new System.EventHandler(this.Tgl_Pesanan_ValueChanged);
            // 
            // addPesanan
            // 
            this.addPesanan.Font = new System.Drawing.Font("Cooper Black", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPesanan.Location = new System.Drawing.Point(369, 316);
            this.addPesanan.Name = "addPesanan";
            this.addPesanan.Size = new System.Drawing.Size(75, 23);
            this.addPesanan.TabIndex = 72;
            this.addPesanan.Text = "ADD";
            this.addPesanan.UseVisualStyleBackColor = true;
            this.addPesanan.Click += new System.EventHandler(this.addPesanan_Click);
            // 
            // idPesan
            // 
            this.idPesan.Location = new System.Drawing.Point(217, 42);
            this.idPesan.Name = "idPesan";
            this.idPesan.Size = new System.Drawing.Size(197, 20);
            this.idPesan.TabIndex = 71;
            this.idPesan.TextChanged += new System.EventHandler(this.idPesan_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(90, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 15);
            this.label2.TabIndex = 70;
            this.label2.Text = "id pesanan";
            // 
            // Nama_Pelanggan
            // 
            this.Nama_Pelanggan.Location = new System.Drawing.Point(217, 78);
            this.Nama_Pelanggan.Name = "Nama_Pelanggan";
            this.Nama_Pelanggan.Size = new System.Drawing.Size(197, 20);
            this.Nama_Pelanggan.TabIndex = 69;
            this.Nama_Pelanggan.TextChanged += new System.EventHandler(this.Nama_Pelanggan_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(90, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 15);
            this.label9.TabIndex = 57;
            this.label9.Text = "id user";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(90, 205);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 15);
            this.label10.TabIndex = 56;
            this.label10.Text = "bus code";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbPenumpang);
            this.groupBox3.Controls.Add(this.cbBus);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Location = new System.Drawing.Point(832, 433);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(473, 112);
            this.groupBox3.TabIndex = 75;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "record new order";
            // 
            // cbPenumpang
            // 
            this.cbPenumpang.FormattingEnabled = true;
            this.cbPenumpang.Items.AddRange(new object[] {
            "jogja",
            "malang",
            "bandung",
            "bali"});
            this.cbPenumpang.Location = new System.Drawing.Point(166, 77);
            this.cbPenumpang.Name = "cbPenumpang";
            this.cbPenumpang.Size = new System.Drawing.Size(197, 21);
            this.cbPenumpang.TabIndex = 63;
            this.cbPenumpang.SelectedIndexChanged += new System.EventHandler(this.cbPenumpang_SelectedIndexChanged);
            // 
            // cbBus
            // 
            this.cbBus.FormattingEnabled = true;
            this.cbBus.Items.AddRange(new object[] {
            "jakarta",
            "surabaya",
            "purwokerto",
            "banjarnegara"});
            this.cbBus.Location = new System.Drawing.Point(166, 38);
            this.cbBus.Name = "cbBus";
            this.cbBus.Size = new System.Drawing.Size(197, 21);
            this.cbBus.TabIndex = 62;
            this.cbBus.SelectedIndexChanged += new System.EventHandler(this.cbBus_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(39, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(24, 15);
            this.label8.TabIndex = 58;
            this.label8.Text = "To";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(39, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 15);
            this.label11.TabIndex = 57;
            this.label11.Text = "From";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cooper Black", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(546, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(217, 42);
            this.label7.TabIndex = 76;
            this.label7.Text = "PESANAN";
            // 
            // Cd_Bus
            // 
            this.Cd_Bus.Location = new System.Drawing.Point(217, 205);
            this.Cd_Bus.Name = "Cd_Bus";
            this.Cd_Bus.Size = new System.Drawing.Size(197, 20);
            this.Cd_Bus.TabIndex = 87;
            this.Cd_Bus.TextChanged += new System.EventHandler(this.Cd_Bus_TextChanged_1);
            // 
            // Pesanan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UTS_NET.Properties.Resources.lovepik_a_driving_bus_background_image_400149197;
            this.ClientSize = new System.Drawing.Size(1370, 925);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.TabelPesanan);
            this.Controls.Add(this.tabelBus);
            this.Controls.Add(this.groupBox1);
            this.Name = "Pesanan";
            this.Text = "Pesanan";
            this.Load += new System.EventHandler(this.Pesanan_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelBus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TabelPesanan)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox destinasi;
        private System.Windows.Forms.ComboBox asal;
        private System.Windows.Forms.Label Tujuan;
        private System.Windows.Forms.Label awal;
        private System.Windows.Forms.DataGridView tabelBus;
        private System.Windows.Forms.Button btn_cari;
        private System.Windows.Forms.DataGridView TabelPesanan;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button addPesanan;
        private System.Windows.Forms.TextBox idPesan;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Nama_Pelanggan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker Tgl_Pesanan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Total;
        private System.Windows.Forms.TextBox JmlKursi;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox NoKursi;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cbPenumpang;
        private System.Windows.Forms.ComboBox cbBus;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.Button btnHapus;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Cd_Bus;
    }
}