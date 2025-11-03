using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P3_1_714240062
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Console.Clear();

                Console.WriteLine("menentukan Indeks Prestasi Mahasiswa");
                Console.WriteLine("\nMasukan Nama Mahasiswa");

                String nama = Console.ReadLine();

                Console.WriteLine("Masukan Nilai : ");

                int nilai = Convert.ToInt16(Console.ReadLine());

                String[] grade = { "A", "B", "C", "D", };

                if (nilai >= 85)
                {
                    Console.WriteLine("Indeks nilai {0} adalah {1}", nama, grade[0]);
                }
                else if (nilai >= 70 && nilai < 85)
                {
                    Console.WriteLine("Indeks nilai {0} adalah {1}", nama, grade[0]);
                }
                else if (nilai >= 60 && nilai < 70)
                {
                    Console.WriteLine("Indeks nilai {0} adalah {1}", nama, grade[0]);
                }
                else
                {
                    Console.WriteLine("Indeks nilai {0} adalah {1}", nama, grade[0]);
                }

                Console.WriteLine("\nMasukan Indeks yang ditampilkan : ");
                char indeks = Convert.ToChar(Console.ReadLine());
                Console.Write("Indeks prestasi {0} adalah ", nama);

                prestasi(indeks);

                Console.Write("\nIngin mengulang kembali (Y/T)");
            }
            while (Console.ReadLine() == "y");
        }
    
        

    private static void prestasi(char indeks)
        { 
            switch (indeks)
            {
                case 'A':
                    Console.WriteLine("Sangat Baik");
                    break;
                case 'B':
                    Console.WriteLine("Baik");
                    break;
                case 'C':
                    Console.WriteLine("Cukup");
                    break;
                case 'D':
                    Console.WriteLine("Buruk");
                    break;
                default:
                    Console.WriteLine("Invalid Ineks Prestasi");
                    break;
            }
        }
    }
}
