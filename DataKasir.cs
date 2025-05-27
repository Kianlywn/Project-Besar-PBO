using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBO_Besar.Auth;
using PBO_BESAR.DataAccess;

namespace PBO_Besar.Menu.Menu_Admin.Data_Kasir
{
    public partial class DataKasir : Form
    {
        // Inisialisasi di constructor atau Load event
        public DataKasir()
        {
            InitializeComponent();

            // Atur properti DataGridView
            dgvKasir.AutoGenerateColumns = false; // Nonaktifkan auto-generate kolom
            dgvKasir.AllowUserToAddRows = false; // Nonaktifkan row baru
            dgvKasir.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Tambahkan kolom manual (opsional)
            dgvKasir.Columns.Add("id", "ID Kasir");
            dgvKasir.Columns.Add("username", "Username");
            dgvKasir.Columns.Add("full_name", "Nama Panjang");

            dgvKasir.Columns["id"].DataPropertyName = "id";
            dgvKasir.Columns["username"].DataPropertyName = "username";
            dgvKasir.Columns["full_name"].DataPropertyName = "full_name";

            LoadDataKasir(); // Memuat data
        }

        private void LoadDataKasir()
        {
            try
            {
                string query = "SELECT id, username, full_name FROM users WHERE role = @role";
                var parameters = new Dictionary<string, object>
                {
                    { "@role", "kasir" }
                };

                DataTable data = Database.ExecuteQuery(query, parameters);
                dgvKasir.DataSource = data;

                // Konfigurasi kolom (opsional)
                dgvKasir.Columns["id"].HeaderText = "ID Kasir";
                dgvKasir.Columns["username"].HeaderText = "Username";
                dgvKasir.Columns["full_name"].HeaderText = "Nama Panjang";
                dgvKasir.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        //Tombol Edit, Tambah, Hapus, dan Kembali
        private void btnEdit_Click(object sender, EventArgs e)
        {
            this.Hide();
            EditKasir editKasir = new EditKasir();
            editKasir.FormClosed += (s, args) =>
            {
                this.Show();
            };
            editKasir.Show();
        }
        private void btnTambah_Click(object sender, EventArgs e)
        {
            this.Hide();
            TambahKasir tambahKasir = new TambahKasir();
            tambahKasir.FormClosed += (s, args) =>
            {
                this.Show();
            };
            tambahKasir.Show();
        }
        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            HapusKasir hapusKasir = new HapusKasir();
            hapusKasir.FormClosed += (s, args) =>
            {
                this.Show();
            };
            hapusKasir.Show();
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.Show();
            this.Close();
        }
    }
}
