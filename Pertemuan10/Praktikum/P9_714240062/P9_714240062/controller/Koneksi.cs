using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9_714240062
{
    internal class Koneksi
    {
        string connectString = "Server=localhost;Database=pemrog2ulbi;Uid=root;Pwd=;";
        MySqlConnection koneksi;

        public void OpenConnection()
        {
            koneksi = new MySqlConnection(connectString);
            koneksi.Open();
        }

        public void CloseConnection()
        {
            koneksi.Close();
        }

        public object ShowData(string query)
        {
            OpenConnection();

            MySqlDataAdapter Adapter = new MySqlDataAdapter(query, koneksi);
            DataTable table = new DataTable();
            Adapter.Fill(table);

            CloseConnection();
            return table;
        }

        public void ExecuteQuery(MySqlCommand command)
        {
            command.Connection = koneksi;
            command.ExecuteNonQuery();
        }
    }
}
