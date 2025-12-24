using P9_714240062.controller;
using P9_714240062.model;
using MySql.Data.MySqlClient; // Tambahkan ini untuk parameter pencarian
using System;
using System.Data;
using System.Windows.Forms;

namespace P9_714240062.view // Pastikan namespace biasanya di folder view
{
    public partial class FormBarang : Form
    {
        Barang barang = new Barang();
        M_barang m_barang = new M_barang();
        Koneksi koneksi = new Koneksi();

        string id_barang; // Variabel penampung ID untuk Update/Delete

        public FormBarang()
        {
            InitializeComponent();
        }

        public void Tampil()
        {
            dataGridViewBarang.DataSource = barang.GetAll();

            // Judul kolom
            dataGridViewBarang.Columns[0].HeaderText = "ID";
            dataGridViewBarang.Columns[1].HeaderText = "Nama Barang";
            dataGridViewBarang.Columns[2].HeaderText = "Harga";

            // Lebar kolom
            dataGridViewBarang.Columns[0].Width = 60;
            dataGridViewBarang.Columns[1].Width = 200;
            dataGridViewBarang.Columns[2].Width = 120;

            // Rata tengah ID
            dataGridViewBarang.Columns[0].DefaultCellStyle.Alignment =
                DataGridViewContentAlignment.MiddleCenter;

            // Format Rupiah
            dataGridViewBarang.Columns[2].DefaultCellStyle.Format = "C0";
            dataGridViewBarang.Columns[2].DefaultCellStyle.FormatProvider =
                new System.Globalization.CultureInfo("id-ID");

            // Tidak auto select
            dataGridViewBarang.ClearSelection();
        }

        public void ResetForm()
        {
            textBoxNamaBarang.Text = "";
            textBoxHarga.Text = "";
            textBoxCariData.Text = "";
            id_barang = null; // Reset ID agar tidak salah update
        }

        private void dataGridViewBarang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Mengambil data dari baris yang diklik
            id_barang = dataGridViewBarang.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBoxNamaBarang.Text = dataGridViewBarang.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxHarga.Text = dataGridViewBarang.Rows[e.RowIndex].Cells[2].Value.ToString();
        }

        private void btnHapus_Click_1(object sender, EventArgs e)
        {
            if (id_barang == null)
            {
                MessageBox.Show("Pilih data yang akan dihapus terlebih dahulu", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult pesan = MessageBox.Show(
                "Yakin ingin menghapus data ini?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (pesan == DialogResult.Yes)
            {
                barang.Delete(id_barang); // Hapus berdasarkan ID, bukan nama
                ResetForm();
                Tampil();
            }
        }

        private void textBoxCariData_TextChanged_1(object sender, EventArgs e)
        {
            string query =
                "SELECT * FROM t_barang " +
                "WHERE nama_barang LIKE @cari OR CAST(id_barang AS CHAR) LIKE @cari";

            dataGridViewBarang.DataSource = koneksi.ShowDataParam(
                query,
                new MySqlParameter("@cari", "%" + textBoxCariData.Text + "%")
            );
        }

        private void btnResfresh_Click(object sender, EventArgs e)
        {
            ResetForm();
            Tampil();
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            if (textBoxNamaBarang.Text == "" || textBoxHarga.Text == "")
            {
                MessageBox.Show("Data tidak boleh kosong", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            m_barang.Nama_Barang = textBoxNamaBarang.Text;
            m_barang.Harga = int.Parse(textBoxHarga.Text);

            barang.Insert(m_barang);
            MessageBox.Show("Transaksi berhasil disimpan");

            ResetForm();
            Tampil();
        }

        private void FormBarang_Load_1(object sender, EventArgs e)
        {
            Tampil();
            dataGridViewBarang.ClearSelection();
            ResetForm();
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (id_barang == null)
            {
                MessageBox.Show("Pilih data terlebih dahulu");
                return;
            }

            m_barang.Nama_Barang = textBoxNamaBarang.Text;
            m_barang.Harga = int.Parse(textBoxHarga.Text);

            barang.Update(m_barang, id_barang);
            MessageBox.Show("Data berhasil diubah");

            ResetForm();
            Tampil();
        }

        private void dataGridViewBarang_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewBarang.SelectedRows.Count == 0)
            {
                ResetForm();
            }
        }
    }
}