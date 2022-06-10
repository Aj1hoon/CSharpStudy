using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJoon._02단계
{
    internal class Main2_03
    {
        static void Main03(string[] args)
        {
            string num = Console.ReadLine();
            int n1 = int.Parse(num);

            if (n1 % 100 != 0 && n1 % 4 == 0)
            {
                    Console.WriteLine("1");
            }

            else if (n1 % 100 == 0 && n1 % 400 != 0)
            {
                    Console.WriteLine("0");
            }

            else if (n1 % 400 == 0)
            {
                Console.WriteLine("1");
            }

            else
            {
                Console.WriteLine("0");
            }
        }
    }
}
