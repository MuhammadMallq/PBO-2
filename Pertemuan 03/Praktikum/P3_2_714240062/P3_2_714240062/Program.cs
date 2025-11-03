using System;

namespace P3_2_NPM
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.Clear();
                Console.WriteLine("===== MENU PERSEGI PANJANG =====");
                Console.WriteLine("1. Hitung Luas");
                Console.WriteLine("2. Hitung Keliling");
                Console.WriteLine("3. Keluar");
                Console.Write("Silahkan pilih menu (1, 2, atau 3): ");
                string menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        HitungLuas();
                        break;

                    case "2":
                        HitungKeliling();
                        break;

                    case "3":
                        running = false;
                        Console.WriteLine("Program selesai...");
                        break;

                    default:
                        Console.WriteLine("Menu tidak tersedia!");
                        Console.WriteLine("Tekan ENTER untuk kembali...");
                        Console.ReadLine();
                        break;
                }
            }
        }

        static void HitungLuas()
        {
            Console.Clear();
            Console.WriteLine("=== Hitung Luas Persegi Panjang ===");
            Console.Write("Masukkan panjang: ");
            double panjang = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan lebar   : ");
            double lebar = Convert.ToDouble(Console.ReadLine());

            double luas = panjang * lebar;

            Console.WriteLine($"Luas persegi panjang = {luas}");
            UlangiAtauKembali();
        }

        static void HitungKeliling()
        {
            Console.Clear();
            Console.WriteLine("=== Hitung Keliling Persegi Panjang ===");
            Console.Write("Masukkan panjang: ");
            double panjang = Convert.ToDouble(Console.ReadLine());
            Console.Write("Masukkan lebar   : ");
            double lebar = Convert.ToDouble(Console.ReadLine());

            double keliling = 2 * (panjang + lebar);

            Console.WriteLine($"Keliling persegi panjang = {keliling}");
            UlangiAtauKembali();
        }

        static void UlangiAtauKembali()
        {
            Console.Write("Ulangi? (Y/T): ");
            string jawab = Console.ReadLine().ToUpper();

            if (jawab == "T")
            {
                Console.WriteLine("Terima kasih! Program selesai dijalankan...");
                Environment.Exit(0);
            }
            else if (jawab == "Y")
            {
                // Kembali ke menu utama
            }
            else
            {
                Console.WriteLine("Input tidak dikenali, kembali ke halaman menu...");
                Console.ReadLine();
            }
        }
    }
}
