using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch10
{
    internal class P477
    {
        static void Main477(string[] args)
        {
            Console.Write("입력 : ");
            string input = Console.ReadLine();
            int[] array = { 52, 273, 32, 103 };

            int index = int.Parse(input);
            Console.WriteLine("입력 숫자 : " + index);
            Console.WriteLine("배열 요소 : " + array[index]);
        }
    }
}
