using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBO_Besar.Menu.Menu_Admin.Data_Kasir;

namespace PBO_Besar.Menu.Menu_Admin
{
    public partial class MenuAdmin : Form
    {
        public MenuAdmin(int userId)
        {
            InitializeComponent();
        }

        private void btnKasir_Click(object sender, EventArgs e)
        {
            this.Hide();

            // Buat instance form DataKasir
            DataKasir dataKasirForm = new DataKasir();

            // Event handler saat form DataKasir ditutup
            dataKasirForm.FormClosed += (s, args) =>
            {
                // Tampilkan kembali form admin/menu ketika form DataKasir ditutup
                this.Show();
            };

            // Tampilkan form DataKasir
            dataKasirForm.Show();
        }
    }
}
