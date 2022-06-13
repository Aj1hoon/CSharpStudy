using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch05
{
    internal class P226
    {
        class Product
        {
            public string name;
            public int price;
        }

        static void Main226(string[] args)
        {
            Product product = new Product();

            product.name = "유니티";
            product.price = 100;

            Console.WriteLine(product.name + " : " + product.price + "원");
        }
    }
}
