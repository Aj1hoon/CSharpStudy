using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch03
{
    internal class P129
    {
        static void Main129(string[] args)
        {
            // 현재 시간 구하기
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine(DateTime.Now.Hour);
            Console.WriteLine(DateTime.Now.Minute);
            Console.WriteLine(DateTime.Now.Second);
            Console.WriteLine();

            //오전과 오후 구분하기
            if (DateTime.Now.Hour < 12)
            {
                Console.WriteLine("오전입니다.");
            }

            if (12 <= DateTime.Now.Hour)
            {
                Console.WriteLine("오후입니다.");
            }

        }
    }
}
