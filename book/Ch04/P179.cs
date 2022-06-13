using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch04
{
    internal class P179
    {
        static void Main179(string[] args)
        {
            for (int i = 1; i < 10; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine();

            for (int j = 1; j < 10; j++)
            {
                if (j % 2 == 1)
                {
                    Console.WriteLine(j);
                }
            }
        }
    }
}
