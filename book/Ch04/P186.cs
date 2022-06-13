using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch04
{
    internal class P186
    {
        static void Main186(string[] args)
        {
            Console.WriteLine("메서드 호출 전");
            Console.SetCursorPosition(10, 15);
            Console.Write("메서드 호출 후");

            Console.WriteLine("첫 번째 출력");
            Thread.Sleep(1000);
            Console.WriteLine("두 번째 출력");
        }
    }
}
