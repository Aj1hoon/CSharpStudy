using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch10
{
    internal class P478
    {
        static void Main(string[] args)
        {
            Console.WriteLine("입력 : ");
            try
            {
                string input = Console.ReadLine();
                int[] array = { 52, 273, 32, 103 };

                int index = int.Parse(input);
                Console.WriteLine("입력 숫자 : " + index);
                Console.WriteLine("입력 숫자 : " + array[index]);
            }
            catch (FormatException exception)
        }
    }
}
