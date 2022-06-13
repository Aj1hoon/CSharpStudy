using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch04
{
    internal class P168
    {
        static void Main168(string[] args)
        {
            // 변수를 선언합니다.
            int output = 1;

            // 반복을 수행합니다.
            for (int i = 1; i <= 10; i++)
            {
                output *= i;
            }

            // 출력합니다.
            Console.WriteLine(output);

            // 한글 전부 출력
            for (int j = '가'; j <= '힣'; j++)
            {
                Console.Write((char)j);
            }

            long start = DateTime.Now.Ticks; // 변수를 선언합니다.
            long count = 0;

            // 반복을 수행합니다 : 10000000Tick = 1초
            while (start + (10000000) > DateTime.Now.Ticks)
            {
                count++;
            }

            Console.WriteLine(count + "만큼 반복했습니다.");
        }
    }
}
