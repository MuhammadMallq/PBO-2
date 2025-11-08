using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_2_714240062
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== Data Pembudidaya (Renegade Immortal) =====");
            Console.WriteLine();

            // Membuat object dari class turunan
            // Walaupun tipe variabelnya 'Pembudidaya', object aslinya
            // adalah 'DewaKuno' dan 'Alkemis' (Ini adalah Polymorphism)
            Pembudidaya wangLin = new DewaKuno("Wang Lin", "Formasi Jiwa (Soul Formation)", 5);
            Pembudidaya liMuwan = new Alkemis("Li Muwan", "Jiedan (Core Formation)", "Pembuat Pil Kebangkitan");

            // Masukkan mereka ke dalam satu List bertipe 'Pembudidaya'
            List<Pembudidaya> daftarKarakter = new List<Pembudidaya>();
            daftarKarakter.Add(wangLin);
            daftarKarakter.Add(liMuwan);

            // Loop dan tampilkan info
            foreach (Pembudidaya karakter in daftarKarakter)
            {
                // c. Polymorphism saat runtime
                // Program akan otomatis memanggil 'TampilkanStatus'
                // versi 'DewaKuno' atau 'Alkemis'
                karakter.TampilkanStatus();

                // Program juga akan memanggil 'GunakanJurusUltimate'
                // yang sesuai dengan object aslinya
                karakter.GunakanJurusUltimate();
                Console.WriteLine("------------------------------------------");
            }

            Console.ReadKey();
        }
    }
}

