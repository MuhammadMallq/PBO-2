using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714240062
{
    public class DewaKuno : Pembudidaya
    {
        // Properti unik untuk Dewa Kuno
        public int JumlahBintang { get; private set; }

        // e. Constructor (memanggil constructor base class)
        public DewaKuno(string nama, string tahapAwal, int bintangAwal)
            : base(nama, tahapAwal) // Memanggil constructor 'Pembudidaya'
        {
            this.JumlahBintang = bintangAwal;
        }

        // c. Polymorphism (Override method abstract)
        // Implementasi spesifik 'GunakanJurusUltimate' untuk 'DewaKuno'
        public override void GunakanJurusUltimate()
        {
            Console.WriteLine($"{NamaKultivator} mengaktifkan kekuatan Dewa Kuno: [Tinju Pemecah Surga]!");
        }

        // c. Polymorphism (Override method virtual)
        // Kita modifikasi 'TampilkanStatus' untuk menyertakan info Bintang Dewa Kuno
        public override void TampilkanStatus()
        {
            base.TampilkanStatus(); // Memanggil method TampilkanStatus() dari 'Pembudidaya'
            Console.WriteLine($"Kekuatan       : Dewa Kuno ({JumlahBintang} Bintang)");
        }
    }
}
