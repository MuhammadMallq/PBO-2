using System;
using System.Windows.Forms;

namespace P6_4_714240062
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string nama = txtNama.Text;
            string email = txtEmail.Text;
            string umur = txtUmur.Text;
            string kode = txtKode.Text;
            string konfirmasi = txtKonfirmasi.Text;
            string catatan = txtCatatan.Text;
            string kursi = numKursi.Value.ToString();
            string tanggal = dtTanggal.Value.ToShortDateString();

            // Required Validator
            // Bagian ini memastikan semua field penting sudah terisi. Kalau ada yang kosong, proses dihentikan dan muncul pesan error.
            if (string.IsNullOrWhiteSpace(nama) ||
                string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(umur) ||
                string.IsNullOrWhiteSpace(kode) ||
                string.IsNullOrWhiteSpace(konfirmasi))
            {
                MessageBox.Show("Semua field wajib diisi!",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Char Validator
            // Pengecekan agar isi field Nama hanya boleh huruf dan spasi. Tidak boleh angka atau sim
            if (!System.Text.RegularExpressions.Regex.IsMatch(nama, @"^[a-zA-Z\s]+$"))
            {
                MessageBox.Show("Nama hanya boleh berisi huruf!",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Numeric Validator
            // Pengecekan agar isi field Umur hanya boleh angka. Tidak boleh huruf atau simbol
            if (!int.TryParse(umur, out _))
            {
                MessageBox.Show("Umur harus angka!",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Email Validator
            // Pengecekan agar isi field Email sesuai format email yang benar
            if (!System.Text.RegularExpressions.Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Format email tidak valid!",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Length Validator
            // Pengecekan agar isi field Kode Tiket minimal 4 karakter
            if (kode.Length < 4)
            {
                MessageBox.Show("Kode tiket minimal 4 karakter!",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Comparison Validator
            // Pengecekan agar isi field Kode Tiket dan Konfirmasi Kode Tiket harus sama
            if (kode != konfirmasi)
            {
                MessageBox.Show("Kode tiket dan konfirmasi tidak sesuai!",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Jika lolos semua validasi
            MessageBox.Show(
                $"Nama: {nama}\nEmail: {email}\nUmur: {umur}\nTanggal: {tanggal}\nKode Tiket: {kode}\nKursi: {kursi}\nCatatan: {catatan}",
                "Konfirmasi Pemesanan",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );

            // langsung bersihkan form setelah submit
            ClearForm();
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtNama.Clear();
            txtEmail.Clear();
            txtUmur.Clear();
            txtKode.Clear();
            txtKonfirmasi.Clear();
            txtCatatan.Clear();

            numKursi.Value = 1;
            dtTanggal.Value = DateTime.Now;

            txtNama.Focus(); // kembali ke input awal
        }
    }
}