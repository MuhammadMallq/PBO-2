using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714240062
{
    public abstract class Pembudidaya
    {
        // d. Encapsulation (field)
        // Data internal disembunyikan menggunakan 'private'
        private string _namaKultivator;
        private string _tahapKultivasi;

        // d. Encapsulation (property)
        // 'get' bersifat public, tapi 'set' bersifat 'protected'
        // Artinya, hanya class ini dan turunannya yang bisa mengubah nilainya.
        public string NamaKultivator
        {
            get { return _namaKultivator; }
            protected set { _namaKultivator = value; }
        }

        public string TahapKultivasi
        {
            get { return _tahapKultivasi; }
            protected set { _tahapKultivasi = value; }
        }

        // e. Membuat constructor
        // Constructor untuk base class
        public Pembudidaya(string nama, string tahapAwal)
        {
            this._namaKultivator = nama;
            this._tahapKultivasi = tahapAwal;
        }

        // a. Abstraction (Method Abstrak)
        // Setiap 'Pembudidaya' pasti punya jurus pamungkas,
        // tapi caranya berbeda-beda. Class turunan WAJIB meng-override ini.
        public abstract void GunakanJurusUltimate();

        // c. Polymorphism (Method Virtual)
        // Method umum yang bisa di-override oleh class turunan jika perlu.
        public virtual void TampilkanStatus()
        {
            Console.WriteLine($"Nama           : {this.NamaKultivator}");
            Console.WriteLine($"Tahap Kultivasi: {this.TahapKultivasi}");
        }
    }
}

