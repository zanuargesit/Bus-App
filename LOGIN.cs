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
    public partial class LOGIN : Form
    {

        private string conStr = "Data Source=LAPTOP-Q7V9DRNQ\\SQLEXPRESS;" +
            "Initial Catalog=db_bus; Integrated Security=True";
        private SqlConnection Con;
        public LOGIN()
        {
            InitializeComponent();
            Con = new SqlConnection(conStr);
        }



        private void Username_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Username.Text) || string.IsNullOrEmpty(Password.Text))
            {
                MessageBox.Show("Username dan Password tidak boleh kosong!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Con.Open();
                string query = "SELECT COUNT(*) FROM Admin WHERE Username = @Username AND Password = @Password";
                SqlCommand cmd = new SqlCommand(query, Con);
                cmd.Parameters.AddWithValue("@Username", Username.Text);
                cmd.Parameters.AddWithValue("@Password", Password.Text);

                int result = (int)cmd.ExecuteScalar();

                if (result > 0) // Jika login berhasil
                {
                    MessageBox.Show("Login berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Buka form Dashboard
                    Dasboard dashboard = new Dasboard();
                    dashboard.Show();

                    // Sembunyikan form Login
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Username atau Password salah!", "Login Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Con.Close();
            }
        }
    }
}
