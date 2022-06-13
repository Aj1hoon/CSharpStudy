using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch04
{
    internal class P175
    {
        static void Main175(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < i + 1; j++)
                    Console.Write('*');
                Console.Write('\n');
            }
            Console.WriteLine();

            for (int k = 0; k < 10; k++)
            {
                for (int l = 10; l > k; l--)
                    Console.Write(' ');
                for (int q = 0; q < k+1; q++)
                    Console.Write('*');
                for (int r = 0; r < k; r++)
                    Console.Write('*');
                Console.Write('\n');
            }
        }
    }
}
