using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJoon._02단계
{
    internal class Main2_01
    {
        static void Main01(string[] args)
        {
            string[] num = Console.ReadLine().Split();
            int A = int.Parse(num[0]);
            int B = int.Parse(num[1]);

            if (A > B)
            {
                Console.WriteLine(">");
            }

            if (A < B)
            {
                Console.WriteLine("<");
            }

            if (A == B)
            {
                Console.WriteLine("==");
            }
        }
    }
}
