using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._8
{
    internal class _8_01
    {
        static void Main01(string[] args)
        {
            Console.Write("연도 입력 : ");
            int year = int.Parse(Console.ReadLine());

            if (year % 4 == 0 && year % 100 != 0 || year % 400 == 0)
            {
                Console.WriteLine("{0}는 윤년 입니다.", year);
            }
            else
            {
                Console.WriteLine("{0}는 평년 입니다.", year);
            }

            // 윤년을 구하는 식을 작성할 필요 없이 해당 메서드가 존재
            if (DateTime.IsLeapYear(year))
            {
                Console.WriteLine("{0}는 윤년 입니다.", year);
            }
            else
            {
                Console.WriteLine("{0}는 평년 입니다.", year);
            }
        }
    }
}