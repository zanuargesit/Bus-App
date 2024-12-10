using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UTS_NET
{
    public partial class Penumpang : Form
    {
        private string conStr = "Data Source=LAPTOP-Q7V9DRNQ\\SQLEXPRESS;" +
            "Initial Catalog=db_bus; Integrated Security=True";
        private SqlConnection Con;

        public Penumpang()
        {
            InitializeComponent();
            Con = new SqlConnection(conStr);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Penumpang_Load(object sender, EventArgs e)
        {
            LoadPenumpangData();

        }
        private void LoadPenumpangData()
        {
            try
            {
                Con.Open();
                string query = "SELECT * FROM dbo.AkunPenumpang";
                SqlDataAdapter sda = new SqlDataAdapter(query, Con);
                SqlCommandBuilder builder = new SqlCommandBuilder(sda);
                DataSet ds = new DataSet();
                sda.Fill(ds);
                tabelPenumpang.DataSource = ds.Tables[0];
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

        private void IdPelanggan_TextChanged(object sender, EventArgs e)
        {

        }

        private void NamaPelanggan_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailPelanggan_TextChanged(object sender, EventArgs e)
        {

        }

        private void NoPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void Alamat_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IdPenumpang.Text))
            {
                MessageBox.Show("Pilih data penumpang yang akan diubah!");
                return;
            }

            try
            {
                Con.Open();
                string query = "UPDATE dbo.AkunPenumpang SET NamaPenumpang = @NamaPenumpang, Email = @Email, Alamat = @Alamat, " +
                               "NoTelepon = @NoTelepon WHERE IDPenumpang = @IDPenumpang";
                SqlCommand cmd = new SqlCommand(query, Con);

                // Menambahkan parameter untuk kolom yang akan diperbarui
                cmd.Parameters.AddWithValue("@IDPenumpang", IdPenumpang.Text);  // IDPenumpang yang akan diupdate
                cmd.Parameters.AddWithValue("@NamaPenumpang", NamaPenumpang.Text);
                cmd.Parameters.AddWithValue("@Email", EmailPelanggan.Text); // Menambahkan email
                cmd.Parameters.AddWithValue("@Alamat", Alamat.Text);
                cmd.Parameters.AddWithValue("@NoTelepon", NoTelepon.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data penumpang berhasil diperbarui!");
                LoadPenumpangData();
                ResetForm();

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

        private void btn_AddBus_Click(object sender, EventArgs e)
        {
            // Memastikan nama penumpang, email, dan nomor telepon tidak kosong
            if (string.IsNullOrEmpty(NamaPenumpang.Text) || string.IsNullOrEmpty(EmailPelanggan.Text) || string.IsNullOrEmpty(NoTelepon.Text))
            {
                MessageBox.Show("Nama Penumpang, Email, dan Nomor Telepon wajib diisi!");
                return;
            }

            try
            {
                Con.Open();
                string query = "INSERT INTO dbo.AkunPenumpang (IDPenumpang, NamaPenumpang, Email, Alamat, NoTelepon) " +
                               "VALUES (@IDPenumpang, @NamaPenumpang, @Email, @Alamat, @NoTelepon)";
                SqlCommand cmd = new SqlCommand(query, Con);

                // Menambahkan parameter ke query
                cmd.Parameters.AddWithValue("@IDPenumpang", IdPenumpang.Text);  // IDPenumpang harus diisi oleh user
                cmd.Parameters.AddWithValue("@NamaPenumpang", NamaPenumpang.Text);
                cmd.Parameters.AddWithValue("@Email", EmailPelanggan.Text); // Menambahkan email
                cmd.Parameters.AddWithValue("@Alamat", Alamat.Text);
                cmd.Parameters.AddWithValue("@NoTelepon", NoTelepon.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("Data penumpang berhasil ditambahkan!");
                LoadPenumpangData();
                ResetForm();
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

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IdPenumpang.Text))
            {
                MessageBox.Show("Pilih data penumpang yang akan dihapus!");
                return;
            }

            try
            {
                Con.Open();
                string query = "DELETE FROM dbo.AkunPenumpang WHERE IdPenumpang = @IdPenumpang";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@IdPenumpang", IdPenumpang.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data penumpang berhasil dihapus!");
                LoadPenumpangData();
                ResetForm();

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

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }
        private void ResetForm()
        {
            IdPenumpang.Clear();
            NamaPenumpang.Clear();
            EmailPelanggan.Clear();
            NoTelepon.Clear();
            Alamat.Clear();
        }


        private void btn_kembali_Click(object sender, EventArgs e)
        {

        }

        private void tabelPenumpang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = tabelPenumpang.Rows[e.RowIndex];
                IdPenumpang.Text = row.Cells[0].Value.ToString();
                NamaPenumpang.Text = row.Cells[1].Value.ToString();
                EmailPelanggan.Text = row.Cells[2].Value.ToString();
                NoTelepon.Text = row.Cells[3].Value.ToString();
                Alamat.Text = row.Cells[4].Value.ToString();
            }
        }
    }
}
