using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch08
{
    internal class P398
    {
        class Products
        {
            public int this[int i]
            {
                // Prouducts products = new Product();
                // products[i]
                get { return i; }
                // products[i] = 10 할 때에 호출
                set { Console.WriteLine(i + "번째 상품 설정"); }
            }
        }

        static void Main398(string[] args)
        {
            Products products = new Products();

            products[0] = 100;
            products[1] = 101;
            products[2] = 102;
            products[3] = 103;
        }
    }
}
