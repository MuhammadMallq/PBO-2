using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P4_1_714240062
{
    public class Book_714240062 : Product_714240062
    {
        protected string pagecount;

        public Book_714240062(string type, string title, string pagecount) 
            : base(type, title)
        {
            this.pagecount = pagecount;
        }

        public string PageCount
        {
            get { return pagecount; }
            set { pagecount = value; }
        }

        // Implementasi metode abstrak
        public override void DisplayInfo()
        {
            Console.WriteLine("Product is a {0} called \"{1}\" and has {2} pages", MyType, MyTitle, PageCount);
        }
    }
}
