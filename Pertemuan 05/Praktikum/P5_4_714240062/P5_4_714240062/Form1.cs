using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5_4_714240062
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Isi ComboBox Jenis Kelamin
            cmbGender.Items.Add("Laki-laki");
            cmbGender.Items.Add("Perempuan");
            cmbGender.SelectedIndex = -1;
        }

        private void btnTampilkan_Click_1(object sender, EventArgs e)
        {
            {
                // untuk Validasi Nama
                if (string.IsNullOrWhiteSpace(txtNama.Text))
                {
                    MessageBox.Show("Nama belum diisi!", "Peringatan");
                    return;
                }

                // untuk Validasi Jenis Kelamin
                if (cmbGender.SelectedIndex == -1)
                {
                    MessageBox.Show("Pilih jenis kelamin!", "Peringatan");
                    return;
                }

                // untuk Validasi Pilihan Kelas (CheckBox)
                List<string> kelasDipilih = new List<string>();
                foreach (Control ctrl in groupBoxKelas.Controls)
                {
                    if (ctrl is CheckBox cb && cb.Checked)
                        kelasDipilih.Add(cb.Text);
                }

                if (kelasDipilih.Count == 0)
                {
                    MessageBox.Show("Pilih minimal satu kelas!", "Peringatan");
                    return;
                }

                // untuk Validasi Pilihan Jadwal (RadioButton)
                string jadwalDipilih = "";
                foreach (Control ctrl in groupBoxJadwal.Controls)
                {
                    if (ctrl is RadioButton rb && rb.Checked)
                    {
                        jadwalDipilih = rb.Text;
                        break;
                    }
                }

                if (string.IsNullOrEmpty(jadwalDipilih))
                {
                    MessageBox.Show("Pilih jadwal latihan!", "Peringatan");
                    return;
                }

                // untuk Tampilkan hasil
                string hasil = $"Nama: {txtNama.Text}\n" +
                               $"Jenis Kelamin: {cmbGender.Text}\n" +
                               $"Tanggal Lahir: {dtTanggal.Value.ToShortDateString()}\n" +
                               $"Kelas: {string.Join(", ", kelasDipilih)}\n" +
                               $"Jadwal: {jadwalDipilih}";

                MessageBox.Show(hasil, "Data Pendaftaran");
            }
        }

        private void btnSelesai_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }
    }
}
