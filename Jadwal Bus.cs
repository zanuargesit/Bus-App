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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
namespace UTS_NET
{
    public partial class Jadwal_Bus : Form
    {

        private string conStr = "Data Source=LAPTOP-Q7V9DRNQ\\SQLEXPRESS;" +
            "Initial Catalog=db_bus; Integrated Security=True";
        private SqlConnection Con;

        public Jadwal_Bus()
        {
            InitializeComponent();
            Con = new SqlConnection(conStr);
        }
        private void populate()
        {
            Con.Open();
            MessageBox.Show("Koneksi ke database berhasil dibuka.");

            string query = "SELECT * FROM Cd_Bus_tbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            tabelBus.DataSource = ds.Tables[0];
            Con.Close();
        }
        private void Jadwal_Bus_Load(object sender, EventArgs e)
        {
            populate();
        }
        
        private void Bus_Jadwalcs_Load(object sender, EventArgs e)
        {

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

        private void btn_kembali_Click(object sender, EventArgs e)
        {
       
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            Cd_Bus.Text = "";
            JmlKursi.Text = "";
            asal.Text = "";
            destinasi.Text = "";
        }

        private void btn_hapus_Click(object sender, EventArgs e)
        {
            if (Cd_Bus.Text == "")
            {
                MessageBox.Show("Hapus Bus");
            } else {
                try
                {
                    Con.Open();
                    string query = "delete Cd_Bus_tbl where Cd_Bus='" + Cd_Bus.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bus telah dihapus");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (Cd_Bus.Text == "" || JmlKursi.Text == "" )
            {
                MessageBox.Show("Tidak boleh kosong");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update Cd_Bus_tbl set asal='"+ asal.SelectedItem.ToString() +
                        "', destinasi='"+ destinasi.SelectedItem.ToString() + "', Tanggal='" + Time.Value.Date.ToString() +
                        "',Time='" + waktu.Value.TimeOfDay.ToString() + "', JmlKursi='" + JmlKursi.Text+ "'where Cd_Bus='"+ Cd_Bus.Text+"' ";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bus telah di edit");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void btn_AddBus_Click(object sender, EventArgs e)
        {
            if (Cd_Bus.Text == "" || asal.Text == "" || destinasi.Text == "" || Time.Value.Date.ToString() == "" 
                || waktu.Value.TimeOfDay.ToString()=="" ||JmlKursi.Text == " ")
            {
                MessageBox.Show("Tidak boleh kosong");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "insert into Cd_Bus_tbl values('" + Cd_Bus.Text + "', '" + asal.SelectedItem.ToString() + "','"
                        + destinasi.SelectedItem.ToString() + "','" + Time.Value.Date.ToString() + "','" 
                        + waktu.Value.TimeOfDay.ToString() + "'," + JmlKursi.Text + ")";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Bus telah di isi");
                    Con.Close();
                    populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
      

        private void waktu_ValueChanged(object sender, EventArgs e)
        {
            waktu.CustomFormat = "HH:mm";
        }

        private void Time_ValueChanged(object sender, EventArgs e)
        {
            Time.CustomFormat = "dd/MM/yyyy";
        }

        private void Time_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Time.CustomFormat = "";
            }
        }

        private void waktu_MouseCaptureChanged(object sender, EventArgs e)
        {
            waktu.CustomFormat = "HH:mm";
        }

        private void Cd_Bus_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
