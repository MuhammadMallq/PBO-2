using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714240062
{
    public class ProductTest_714240062
    {
        static void Main(string[] args)
        {
            Book_714240062 product1 = new Book_714240062("Book", "C# Obejct Oriented Solution", "300");
            DVD_714240062 product2 = new DVD_714240062("Ethernal Sunshine Of The Spotless Mind", "145");

            product1.DisplayInfo();
            product2.DisplayInfo();
        }
    }
}
