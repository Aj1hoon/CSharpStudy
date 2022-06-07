using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch02
{
    internal class P81
    {
        static void Main81(string[] args)
        {
            // 오버플로우
            int a = 2147483640;
            int b = 52273;

            // int 자료형 범위를 넘어서면 한 바퀴 돌아서 다시 수를 표시함.
            Console.WriteLine(a + b);
            Console.WriteLine();

            int c = 2000000000;
            int d = 1000000000;

            Console.WriteLine(c + d);
        }
    }
}
