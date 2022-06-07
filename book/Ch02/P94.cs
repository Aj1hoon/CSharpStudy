using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch02
{
    internal class P94
    {
        static void Main94(string[] args)
        {
            int number = 10;
            Console.WriteLine(number);
            Console.WriteLine(number++);
            Console.WriteLine(number--);
            Console.WriteLine(number);

            int a = 10;
            Console.WriteLine(a);
            Console.WriteLine(a--);
            Console.WriteLine(a);
            Console.WriteLine(--a);
        }
    }
}
