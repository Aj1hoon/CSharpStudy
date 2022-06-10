using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJoon._02단계
{
    internal class Main2_02
    {
        static void Main02(string[] args)
        {
            Console.Write("시험 점수 : ");
            string num = Console.ReadLine();
            int n1 = int.Parse(num);

            if (90 <= n1 && n1 <= 100)
            {
                Console.WriteLine("A");
            }

            else if (80 <= n1 && n1 <= 89)
            {
                Console.WriteLine("B");
            }

            else if (70 <= n1 && n1 <= 79)
            {
                Console.WriteLine("C");
            }

            else if (60 <= n1 && n1 <= 69)
            {
                Console.WriteLine("D");
            }

            else
            {
                Console.WriteLine("F");
            }
        }
    }
}
