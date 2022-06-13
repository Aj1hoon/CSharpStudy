using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch04
{
    internal class P165
    {
        static void Main165(string[] args)
        {
            //do while 반복문 활용
            string input;
            do
            {
                Console.Write("입력(exit를 입력하면 종료) : ");
                input = Console.ReadLine();
            }
            while (input != "exit");
        }
    }
}
