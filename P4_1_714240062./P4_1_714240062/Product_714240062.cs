using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714240062
{
    public abstract class Product_714240062
    {
        private string myType;
        private string myTitle;

        public Product_714240062()
        {

        }

        //Constructor
        public Product_714240062(string type, string title)
        {
            myType = type;
            myTitle = title;

        }
        //Peroperty untuk Mytype
        public string MyType
        {
            get{ return myType; }
            set{ myType = value; }
        }

        //Peroperty untuk MyTitle
        public string MyTitle
        {
            get{ return myTitle; }
            set{ myTitle = value; }
        }

        //Metode Abstrack untuk menampilkan informasi produk
        public abstract void DisplayInfo();
           
    }
}
