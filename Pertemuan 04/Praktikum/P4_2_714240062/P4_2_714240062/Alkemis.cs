using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714240062
{
    public class Alkemis : Pembudidaya
    {
        // Properti unik untuk Alkemis
        public string KeahlianUtama { get; private set; }

        // e. Constructor
        public Alkemis(string nama, string tahapAwal, string keahlian)
            : base(nama, tahapAwal) // Memanggil constructor 'Pembudidaya'
        {
            this.KeahlianUtama = keahlian;
        }

        // c. Polymorphism (Override method abstract)
        // Implementasi 'GunakanJurusUltimate' untuk 'Alkemis' sangat berbeda
        public override void GunakanJurusUltimate()
        {
            Console.WriteLine($"{NamaKultivator} menggunakan keahlian alkimia: [Membuat Pil Penentang Surga]!");
        }

        // c. Polymorphism (Override method virtual)
        // Kita modifikasi 'TampilkanStatus' untuk menyertakan info Keahlian
        public override void TampilkanStatus()
        {
            base.TampilkanStatus(); // Memanggil method TampilkanStatus() dari 'Pembudidaya'
            Console.WriteLine($"Keahlian       : {this.KeahlianUtama}");
        }
    }
}
