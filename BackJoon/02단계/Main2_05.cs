using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackJoon._02단계
{
    internal class Main2_05
    {
        static void Main(string[] args)
        {
            string[] num = Console.ReadLine().Split();
            int n1 = int.Parse(num[0]);
            int n2 = int.Parse(num[1]);



            int r1 = ((60 * n1 + n2) - 45) / 60;
            int r2 = ((60 * n1 + n2) - 45) % 60;

            if (r1 == 0)
            {
                r1 = r1 + 23;
            }

            if (r2 < 0)
            {
                r2 = r2 + 60;
            }



            Console.Write(r1 + " " + r2 );
            
        }
    }
}
