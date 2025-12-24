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
    internal class Transaksi
    {
        Koneksi koneksi = new Koneksi();

        // =============================
        // TAMPIL DATA TRANSAKSI
        // =============================
        public DataTable GetAll()
        {
            return (DataTable)koneksi.ShowDataParam(
                "SELECT t.id_transaksi, t.id_barang, b.nama_barang, b.harga, t.qty, t.total " +
                "FROM t_transaksi t JOIN t_barang b ON t.id_barang = b.id_barang"
            );
        }

        // =============================
        // CEK DUPLIKAT ID BARANG
        // =============================
        public bool CekBarang(int idBarang)
        {
            DataTable dt = (DataTable)koneksi.ShowDataParam(
                "SELECT * FROM t_transaksi WHERE id_barang=@id",
                new MySqlParameter("@id", idBarang)
            );
            return dt.Rows.Count > 0;
        }

        // =============================
        // INSERT
        // =============================
        public void Insert(M_transaksi t)
        {
            MySqlCommand cmd = new MySqlCommand(
                "INSERT INTO t_transaksi (id_barang, qty, total) VALUES (@id, @qty, @total)"
            );
            cmd.Parameters.AddWithValue("@id", t.Id_Barang);
            cmd.Parameters.AddWithValue("@qty", t.Qty);
            cmd.Parameters.AddWithValue("@total", t.Total);

            koneksi.ExecuteQuery(cmd);
        }

        // =============================
        // UPDATE
        // =============================
        public void Update(M_transaksi t)
        {
            MySqlCommand cmd = new MySqlCommand(
                "UPDATE t_transaksi SET qty=@qty, total=@total WHERE id_barang=@id"
            );
            cmd.Parameters.AddWithValue("@id", t.Id_Barang);
            cmd.Parameters.AddWithValue("@qty", t.Qty);
            cmd.Parameters.AddWithValue("@total", t.Total);

            koneksi.ExecuteQuery(cmd);
        }


        // =============================
        // DELETE
        // =============================
        public void Delete(int idBarang)
        {
            MySqlCommand cmd = new MySqlCommand(
                "DELETE FROM t_transaksi WHERE id_barang=@id"
            );
            cmd.Parameters.AddWithValue("@id", idBarang);

            koneksi.ExecuteQuery(cmd);
        }

    }
}