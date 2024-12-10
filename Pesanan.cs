using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace UTS_NET
{
    public partial class Pesanan : Form
    {

        private string conStr = "Data Source=LAPTOP-Q7V9DRNQ\\SQLEXPRESS;" +
            "Initial Catalog=db_bus; Integrated Security=True";
        private SqlConnection Con;

        public Pesanan()
        {
            InitializeComponent();
            Con = new SqlConnection(conStr);
        }

        private void Pesanan_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
            LoadBusData();
            LoadPesananData();
        }

        private void LoadPesananData()
        {
          
                Con.Open();
                MessageBox.Show("Koneksi ke database berhasil dibuka.");

                string query = "SELECT * FROM tbl_pemesanan";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                var ds = new DataSet();
                sda.Fill(ds);
                TabelPesanan.DataSource = ds.Tables[0];
                Con.Close();
            
        }



        private void LoadComboBoxes()
        {
            try
            {
                Con.Open();

                // Mengisi ComboBox Bus
                string queryBus = "SELECT Cd_Bus, asal + ' - ' + destinasi AS Route FROM Cd_Bus_tbl";
                SqlDataAdapter sdaBus = new SqlDataAdapter(queryBus, Con);
                DataTable dtBus = new DataTable();
                sdaBus.Fill(dtBus);

                cbBus.DataSource = dtBus;
                cbBus.DisplayMember = "Route";  // Tampilkan rute bus
                cbBus.ValueMember = "Cd_Bus";   // Nilai ID Bus
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
            try
            {
                Con.Open();

                // Mengisi ComboBox Penumpang dengan IDPenumpang dan NamaPenumpang
                string queryPenumpang = "SELECT IDPenumpang, NamaPenumpang FROM AkunPenumpang";
                SqlDataAdapter sdaPenumpang = new SqlDataAdapter(queryPenumpang, Con);
                DataTable dtPenumpang = new DataTable();
                sdaPenumpang.Fill(dtPenumpang);

                cbPenumpang.DataSource = dtPenumpang;
                cbPenumpang.DisplayMember = "NamaPenumpang";  // Tampilkan NamaPenumpang
                cbPenumpang.ValueMember = "IDPenumpang";      // Nilai IDPenumpang

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void btnTambahPesanan_Click(object sender, EventArgs e)
        {
            if (cbPenumpang.SelectedValue == null || cbBus.SelectedValue == null)
            {
                MessageBox.Show("Pilih Penumpang dan Bus sebelum menyimpan!");
                return;
            }

            try
            {
                Con.Open();
                string query = "INSERT INTO tbl_pemesanan (id_pemesanan, Cd_Bus, id_user, nama_penumpang, tgl_pemesanan, No_Kursi, total_harga) " +
                               "VALUES (@id_pemesanan, @Cd_Bus, @id_user, @nama_penumpang, @tgl_pemesanan, @No_Kursi, @total_harga)";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@id_pemesanan", idPesan.Text);
                cmd.Parameters.AddWithValue("@Cd_Bus", cbBus.SelectedValue);
                cmd.Parameters.AddWithValue("@id_user", cbPenumpang.SelectedValue);
                cmd.Parameters.AddWithValue("@nama_penumpang", Nama_Pelanggan.Text);
                cmd.Parameters.AddWithValue("@tgl_pemesanan", Tgl_Pesanan.Value);
                cmd.Parameters.AddWithValue("@No_Kursi", NoKursi.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@total_harga", Total.Text);

                cmd.ExecuteNonQuery();
                LoadPesananData();
                MessageBox.Show("Pesanan berhasil ditambahkan!");
            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }

        private void tabelBus_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Pastikan indeks baris valid
            {
                Cd_Bus.Text = tabelBus.Rows[e.RowIndex].Cells[0].Value?.ToString();
                asal.SelectedItem = tabelBus.Rows[e.RowIndex].Cells[1].Value?.ToString();
                destinasi.SelectedItem = tabelBus.Rows[e.RowIndex].Cells[2].Value?.ToString();
                JmlKursi.Text = tabelBus.Rows[e.RowIndex].Cells[5].Value?.ToString();
            }
        }

        private void cari()
        {
            try
            {
                Con.Open();

                string query = "SELECT Cd_Bus, asal, destinasi, Tanggal, Time, JmlKursi FROM Cd_Bus_tbl " +
                               "WHERE asal = @asal AND destinasi = @destinasi";

                using (SqlCommand cmd = new SqlCommand(query, Con))
                {
                    // Menggunakan parameter untuk menghindari SQL Injection
                    cmd.Parameters.AddWithValue("@asal", asal.SelectedItem.ToString());
                    cmd.Parameters.AddWithValue("@destinasi", destinasi.SelectedItem.ToString());

                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                    var ds = new DataSet();
                    sda.Fill(ds);

                    tabelBus.DataSource = ds.Tables[0];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }
        private void asal_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




        private void btn_cari_Click(object sender, EventArgs e)
        {
            cari();
        }

        private void idPesan_TextChanged(object sender, EventArgs e)
        {

        }

        private void Nama_Pelanggan_TextChanged(object sender, EventArgs e)
        {

        }

        private void IdUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tgl_Pesanan_ValueChanged(object sender, EventArgs e)
        {

        }

     


        private void AddPesanan()
        {
            if (string.IsNullOrEmpty(Cd_Bus.Text) || string.IsNullOrEmpty(Nama_Pelanggan.Text) ||
                string.IsNullOrEmpty(Email.Text) || NoKursi.SelectedItem == null || string.IsNullOrEmpty(Total.Text))
            {
                MessageBox.Show("Mohon isi semua kolom yang diperlukan!");
                return;
            }

            try
            {
                Con.Open();

                // Cek apakah kursi sudah dipesan
                string checkQuery = "SELECT COUNT(*) FROM tbl_pemesanan WHERE Cd_Bus = @Cd_Bus AND No_Kursi = @NoKursi";
                SqlCommand checkCmd = new SqlCommand(checkQuery, Con);
                checkCmd.Parameters.AddWithValue("@Cd_Bus", Cd_Bus.Text);
                checkCmd.Parameters.AddWithValue("@NoKursi", NoKursi.SelectedItem.ToString());
                int count = (int)checkCmd.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Kursi ini sudah dipesan, pilih kursi lain.");
                    return;
                }

                // Menyimpan data pesanan ke tabel tbl_pemesanan
                string query = "INSERT INTO tbl_pemesanan (id_pemesanan, Cd_Bus, id_user, nama_penumpang, tgl_pemesanan, No_Kursi, total_harga) " +
                               "VALUES (@id_pemesanan, @Cd_Bus, @id_user, @nama_penumpang, @tgl_pemesanan, @No_Kursi, @total_harga)";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@id_pemesanan", idPesan.Text);
                cmd.Parameters.AddWithValue("@Cd_Bus", Cd_Bus.Text);
                cmd.Parameters.AddWithValue("@id_user", Email.Text);
                cmd.Parameters.AddWithValue("@nama_penumpang", Nama_Pelanggan.Text);
                cmd.Parameters.AddWithValue("@tgl_pemesanan", Tgl_Pesanan.Value);
                cmd.Parameters.AddWithValue("@No_Kursi", NoKursi.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@total_harga", Total.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Pesanan berhasil ditambahkan!");
              
                // Refresh data pesanan dan kursi yang tersedia

                LoadAvailableSeats();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                Con.Close();
                LoadPesananData();
            }
        }


        private void addPesanan_Click(object sender, EventArgs e)
        {
            AddPesanan();
            



        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void Total_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void JmlKursi_TextChanged(object sender, EventArgs e)
        {

        }

        private bool ValidateForm()
        {
            if (cbPenumpang.SelectedIndex == -1 || cbBus.SelectedIndex == -1 || string.IsNullOrEmpty(Total.Text))
            {
                MessageBox.Show("Semua field wajib diisi!");
                return false;
            }
            return true;
        }

        private void TabelPesanan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0) // Pastikan indeks baris valid
            {
                try
                {
                    // Mendapatkan data dari baris yang diklik berdasarkan nama kolom DataGridView
                    idPesan.Text = TabelPesanan.Rows[e.RowIndex].Cells["id_pemesanan"].Value?.ToString();
                    Cd_Bus.Text = TabelPesanan.Rows[e.RowIndex].Cells["Cd_Bus"].Value?.ToString();
                    Email.Text = TabelPesanan.Rows[e.RowIndex].Cells["id_user"].Value?.ToString();
                    Nama_Pelanggan.Text = TabelPesanan.Rows[e.RowIndex].Cells["nama_penumpang"].Value?.ToString();
                    Tgl_Pesanan.Value = DateTime.TryParse(TabelPesanan.Rows[e.RowIndex].Cells["tgl_pemesanan"].Value?.ToString(), out var tgl)
                        ? tgl
                        : DateTime.Now;
                    NoKursi.SelectedItem = TabelPesanan.Rows[e.RowIndex].Cells["No_Kursi"].Value?.ToString();
                    Total.Text = TabelPesanan.Rows[e.RowIndex].Cells["total_harga"].Value?.ToString();

                    MessageBox.Show("Data berhasil dimuat ke form!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Terjadi kesalahan: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void NoKursi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbBus_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbBus.SelectedValue != null)
            {
                // Pastikan SelectedValue sesuai
                Cd_Bus.Text = cbBus.SelectedValue.ToString();
                LoadAvailableSeats(); // Memuat kursi berdasarkan Cd_Bus
            }
            else
            {
                Cd_Bus.Text = string.Empty; // Kosongkan jika tidak ada pilihan
            }

        }
        private void LoadAvailableSeats()
        {
            if (string.IsNullOrEmpty(Cd_Bus.Text)) return; // Jangan lanjutkan jika Cd_Bus kosong

            NoKursi.Items.Clear(); // Kosongkan daftar kursi

            try
            {
                Con.Open();

                // Mendapatkan jumlah total kursi dari tabel Cd_Bus_tbl
                string queryTotalSeats = "SELECT JmlKursi FROM Cd_Bus_tbl WHERE Cd_Bus = @Cd_Bus";
                SqlCommand cmdTotalSeats = new SqlCommand(queryTotalSeats, Con);
                cmdTotalSeats.Parameters.AddWithValue("@Cd_Bus", Cd_Bus.Text);
                int totalSeats = Convert.ToInt32(cmdTotalSeats.ExecuteScalar());

                // Mendapatkan kursi yang sudah dipesan
                string queryBookedSeats = "SELECT No_Kursi FROM tbl_pemesanan WHERE Cd_Bus = @Cd_Bus";
                SqlCommand cmdBookedSeats = new SqlCommand(queryBookedSeats, Con);
                cmdBookedSeats.Parameters.AddWithValue("@Cd_Bus", Cd_Bus.Text);
                SqlDataReader reader = cmdBookedSeats.ExecuteReader();

                HashSet<int> bookedSeats = new HashSet<int>();
                while (reader.Read())
                {
                    bookedSeats.Add(reader.GetInt32(0)); // Menyimpan kursi yang sudah dipesan
                }
                reader.Close();

                // Tambahkan kursi yang tersedia ke ComboBox
                for (int i = 1; i <= totalSeats; i++)
                {
                    if (!bookedSeats.Contains(i)) // Tambahkan hanya kursi yang belum dipesan
                    {
                        NoKursi.Items.Add(i);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat memuat kursi: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }




        private void LoadBusData()
        {
            try
            {
                Con.Open();

                // Query untuk mendapatkan data bus
                string queryBus = "SELECT Cd_Bus, asal, destinasi, Tanggal, Time, JmlKursi FROM Cd_Bus_tbl";
                SqlDataAdapter sda = new SqlDataAdapter(queryBus, Con);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                tabelBus.DataSource = dt; // Menampilkan data ke GridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saat memuat data bus: " + ex.Message);
            }
            finally
            {
                Con.Close();
            }
        }




        private void cbPenumpang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbPenumpang.SelectedValue != null)
            {
                try
                {
                    Con.Open();

                    // Query untuk mendapatkan NamaPenumpang dan Email berdasarkan IDPenumpang
                    string query = "SELECT NamaPenumpang, Email FROM AkunPenumpang WHERE IDPenumpang = @IDPenumpang";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@IDPenumpang", cbPenumpang.SelectedValue.ToString());

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        // Mengisi Nama Penumpang dan Email ke TextBox
                        Nama_Pelanggan.Text = reader["NamaPenumpang"].ToString();
                        Email.Text = reader["Email"].ToString();
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    Con.Close();
                }
            }
            else
            {
                // Jika tidak ada penumpang yang dipilih, kosongkan TextBox
                Nama_Pelanggan.Text = string.Empty;
                Email.Text = string.Empty;
            }
        }

        private void Email_TextChanged(object sender, EventArgs e)
        {
            // Isi dengan nilai email dari ComboBox Penumpang
            if (cbPenumpang.SelectedValue != null)
            {
                try
                {
                    Con.Open();
                    string query = "SELECT Email FROM AkunPenumpang WHERE IDPenumpang = @IDPenumpang";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.Parameters.AddWithValue("@IDPenumpang", cbPenumpang.SelectedValue.ToString());

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        Email.Text = reader["Email"].ToString(); // Mengisi Email
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    Con.Close();
                }
            }
        }

      

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idPesan.Text))
            {
                MessageBox.Show("Pilih data yang ingin dihapus!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Con.Open();
                string query = "DELETE FROM tbl_pemesanan WHERE id_pemesanan = @id_pemesanan";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@id_pemesanan", idPesan.Text);

                var confirm = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirm == DialogResult.Yes)
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Data berhasil dihapus!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Con.Close();
                LoadPesananData();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idPesan.Text))
            {
                MessageBox.Show("Pilih data yang ingin diubah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Con.Open();
                string query = "UPDATE tbl_pemesanan " +
                               "SET Cd_Bus = @Cd_Bus, id_user = @id_user, nama_penumpang = @nama_penumpang, " +
                               "tgl_pemesanan = @tgl_pemesanan, No_Kursi = @No_Kursi, total_harga = @total_harga " +
                               "WHERE id_pemesanan = @id_pemesanan";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@id_pemesanan", idPesan.Text);
                cmd.Parameters.AddWithValue("@Cd_Bus", Cd_Bus.Text);
                cmd.Parameters.AddWithValue("@id_user", Email.Text);
                cmd.Parameters.AddWithValue("@nama_penumpang", Nama_Pelanggan.Text);
                cmd.Parameters.AddWithValue("@tgl_pemesanan", Tgl_Pesanan.Value);
                cmd.Parameters.AddWithValue("@No_Kursi", NoKursi.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("@total_harga", Total.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil diubah!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

              
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Con.Close();
                LoadPesananData();
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            idPesan.Text = "";
            Nama_Pelanggan.Text = "";
            Email.Text = "";
            Tgl_Pesanan.Text = "";
            Cd_Bus.Text = "";
            NoKursi.Text = " ";
            Total.Text = " ";
            Con.Close();

                LoadPesananData();
            }

    

        private void Cd_Bus_TextChanged_1(object sender, EventArgs e)
        {
            LoadAvailableSeats();

        }

        private void destinasi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
        }



