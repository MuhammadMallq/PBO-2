using MySql.Data.MySqlClient;
using P9_714240062.model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P9_714240062.controller
{
        class Barang
        {
        Koneksi koneksi = new Koneksi();

        // =====================
        // TAMPIL DATA
        // =====================
        public DataTable GetAll()
        {
            return (DataTable)koneksi.ShowDataParam(
                "SELECT * FROM t_barang"
            );
        }

        // =====================
        // INSERT
        // =====================
        public void Insert(M_barang barang)
        {
            MySqlCommand cmd = new MySqlCommand(
                "INSERT INTO t_barang(nama_barang, harga) VALUES(@nama, @harga)"
            );
            cmd.Parameters.AddWithValue("@nama", barang.Nama_Barang);
            cmd.Parameters.AddWithValue("@harga", barang.Harga);

            koneksi.ExecuteQuery(cmd);
        }

        // =====================
        // UPDATE
        // =====================
        public void Update(M_barang barang, string id)
        {
            MySqlCommand cmd = new MySqlCommand(
                "UPDATE t_barang SET nama_barang=@nama, harga=@harga WHERE id_barang=@id"
            );
            cmd.Parameters.AddWithValue("@nama", barang.Nama_Barang);
            cmd.Parameters.AddWithValue("@harga", barang.Harga);
            cmd.Parameters.AddWithValue("@id", id);

            koneksi.ExecuteQuery(cmd);
        }

        // =====================
        // DELETE
        // =====================
        public void Delete(string id)
        {
            MySqlCommand cmd = new MySqlCommand(
                "DELETE FROM t_barang WHERE id_barang=@id"
            );
            cmd.Parameters.AddWithValue("@id", id);

            koneksi.ExecuteQuery(cmd);
        }
    }
}