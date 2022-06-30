using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch02
{
    internal class P82
    {
        static void Main82(string[] args)
        {
            // 음수를 사용하지 않을때
            uint unsignedInt = 4147483647;
            ulong unsignedLong = 11223372036854775808;
            Console.WriteLine(unsignedInt);
            Console.WriteLine(unsignedLong);

            // 최댓값과 최솟값
            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);
            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);
        }
    }
}
