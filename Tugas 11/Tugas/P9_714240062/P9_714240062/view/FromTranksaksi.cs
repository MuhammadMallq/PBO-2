using MySql.Data.MySqlClient;
using P9_714240062.controller;
using P9_714240062.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P9_714240062.view
{

    public partial class FromTransaksi : Form
    {
        bool isLoadingCombo = false;


        Transaksi transaksi = new Transaksi();
        M_transaksi m_transaksi = new M_transaksi();
        Koneksi koneksi = new Koneksi();

        public FromTransaksi()
        {
            InitializeComponent();

            this.Load += FromTransaksi_Load;
            comboBoxIdBarang.SelectedIndexChanged += comboBoxIdBarang_SelectedIndexChanged_1;
            dataGridViewTransaksi.CellClick += dataGridViewTransaksi_CellClick;
            textBoxQty.TextChanged += textBoxQty_TextChanged;
            btnUbah.Click += btnUbah_Click;
            btnHapus.Click += btnHapus_Click;
        }

        private void FromTransaksi_Load(object sender, EventArgs e)
        {
            LoadBarang();
            comboBoxIdBarang.SelectedIndex = -1;
            Tampil();
            ResetForm();

            // ⬇️ KUNCI INPUT
            comboBoxIdBarang.DropDownStyle = ComboBoxStyle.DropDownList;

            textBoxNamaBarang.ReadOnly = true;
            textBoxNamaBarang.TabStop = false;

            textBoxHargaBarang.ReadOnly = true;
            textBoxHargaBarang.TabStop = false;

            textBoxTotal.ReadOnly = true;
            textBoxTotal.TabStop = false;

        }

        private void LoadBarang()
        {
            isLoadingCombo = true; // 🔒 KUNCI EVENT

            DataTable dt = (DataTable)koneksi.ShowDataParam(
                "SELECT id_barang FROM t_barang"
            );

            comboBoxIdBarang.DataSource = null;   // ⬅ PENTING
            comboBoxIdBarang.Items.Clear();

            comboBoxIdBarang.DataSource = dt;
            comboBoxIdBarang.DisplayMember = "id_barang";
            comboBoxIdBarang.ValueMember = "id_barang";

            comboBoxIdBarang.SelectedIndex = -1;  // ⬅ KOSONGKAN

            isLoadingCombo = false; // 🔓 BUKA EVENT
        }

        // =============================
        // TAMPIL TRANSAKSI
        // =============================
        public void Tampil()
        {
            dataGridViewTransaksi.ClearSelection(); // ⬅ WAJIB
            dataGridViewTransaksi.DataSource = transaksi.GetAll();

            dataGridViewTransaksi.Columns[3].DefaultCellStyle.Format = "C0";
            dataGridViewTransaksi.Columns[3].DefaultCellStyle.FormatProvider =
                new System.Globalization.CultureInfo("id-ID");

            dataGridViewTransaksi.Columns[5].DefaultCellStyle.Format = "C0";
            dataGridViewTransaksi.Columns[5].DefaultCellStyle.FormatProvider =
                new System.Globalization.CultureInfo("id-ID");

        }

        private void dataGridViewTransaksi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // Ambil data dari DataGridView
            comboBoxIdBarang.Text = dataGridViewTransaksi.Rows[e.RowIndex].Cells[1].Value.ToString();
            textBoxNamaBarang.Text = dataGridViewTransaksi.Rows[e.RowIndex].Cells[2].Value.ToString();
            textBoxHargaBarang.Text = dataGridViewTransaksi.Rows[e.RowIndex].Cells[3].Value.ToString();
            textBoxQty.Text = dataGridViewTransaksi.Rows[e.RowIndex].Cells[4].Value.ToString();
            textBoxTotal.Text = dataGridViewTransaksi.Rows[e.RowIndex].Cells[5].Value.ToString();


        }


        // =============================
        // AUTO ISI NAMA & HARGA
        // =============================
        private void comboBoxIdBarang_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (isLoadingCombo) return;                 // ⬅ STOP SAAT LOAD
            if (comboBoxIdBarang.SelectedIndex == -1)   // ⬅ BELUM DIPILIH USER
            {
                textBoxNamaBarang.Text = "";
                textBoxHargaBarang.Text = "";
                return;
            }

            DataTable dt = (DataTable)koneksi.ShowDataParam(
                "SELECT * FROM t_barang WHERE id_barang=@id",
                new MySqlParameter("@id", comboBoxIdBarang.SelectedValue)
            );

            if (dt.Rows.Count > 0)
            {
                textBoxNamaBarang.Text = dt.Rows[0]["nama_barang"].ToString();
                textBoxHargaBarang.Text = dt.Rows[0]["harga"].ToString();
            }
        }

        private void btnSimpan_Click(object sender, EventArgs e)
        {
            int idBarang = int.Parse(comboBoxIdBarang.Text);

            if (transaksi.CekBarang(idBarang))
            {
                MessageBox.Show(
                        "Barang ini sudah ditransaksikan,\nSilakan tekan tombol Ubah!",
                        "Peringatan",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning   // ⬅ IKON PERINGATAN
                );
                return;
            }

            m_transaksi.Id_Barang = idBarang;
            m_transaksi.Qty = int.Parse(textBoxQty.Text);
            m_transaksi.Total = int.Parse(textBoxTotal.Text);

            transaksi.Insert(m_transaksi);
            MessageBox.Show("Transaksi berhasil disimpan");

            Tampil();
        }


        private void textBoxQty_TextChanged(object sender, EventArgs e)
        {
            if (textBoxQty.Text == "" || textBoxHargaBarang.Text == "")
            {
                textBoxTotal.Text = "";
                return;
            }

            if (int.TryParse(textBoxQty.Text, out int qty) &&
                int.TryParse(textBoxHargaBarang.Text, out int harga))
            {
                textBoxTotal.Text = (qty * harga).ToString();
            }
        }

        private void textBoxCariData_TextChanged(object sender, EventArgs e)
        {
            string query =
                "SELECT t.id_transaksi, t.id_barang, b.nama_barang, b.harga, t.qty, t.total " +
                "FROM t_transaksi t JOIN t_barang b ON t.id_barang = b.id_barang " +
                "WHERE b.nama_barang LIKE @cari " +
                "OR t.id_barang LIKE @cari";

            dataGridViewTransaksi.DataSource = koneksi.ShowDataParam(
                query,
                new MySqlParameter("@cari", "%" + textBoxCariData.Text + "%")
            );
        }

        private void btnUbah_Click(object sender, EventArgs e)
        {
            if (comboBoxIdBarang.Text == "" || textBoxQty.Text == "")
            {
                MessageBox.Show("Pilih data transaksi terlebih dahulu");
                return;
            }

            m_transaksi.Id_Barang = int.Parse(comboBoxIdBarang.Text);
            m_transaksi.Qty = int.Parse(textBoxQty.Text);
            m_transaksi.Total = int.Parse(textBoxTotal.Text);

            transaksi.Update(m_transaksi);
            MessageBox.Show("Data transaksi berhasil diubah");

            ResetForm();
            Tampil();
        }

        private void btnHapus_Click(object sender, EventArgs e)
        {
            if (comboBoxIdBarang.Text == "")
            {
                MessageBox.Show("Pilih data transaksi yang akan dihapus");
                return;
            }

            DialogResult pesan = MessageBox.Show(
                "Yakin ingin menghapus transaksi ini?",
                "Konfirmasi",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (pesan == DialogResult.Yes)
            {
                int idBarang = int.Parse(comboBoxIdBarang.Text);
                transaksi.Delete(idBarang);

                MessageBox.Show("Data transaksi berhasil dihapus");

                ResetForm();
                Tampil();
            }
        }

        private void ResetForm()
        {
            comboBoxIdBarang.SelectedIndex = -1;
            textBoxNamaBarang.Text = "";
            textBoxHargaBarang.Text = "";
            textBoxQty.Text = "";
            textBoxTotal.Text = "";
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            ResetForm();
            Tampil();
        }

        private void textBoxNamaBarang_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxQty.Focus();
        }

        private void textBoxHargaBarang_MouseDown(object sender, MouseEventArgs e)
        {
            textBoxQty.Focus();
        }
    }
}
