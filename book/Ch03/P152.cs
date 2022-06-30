using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch03
{
    internal class P152
    {
        static void Main152(string[] args)
        {
            Console.WriteLine("몇 월 입니까?");
            int mon = int.Parse(Console.ReadLine());            

            switch (mon)
            {
                case 12:
                case 1:
                case 2:
                     Console.WriteLine("겨울");
                     break;

                case 3:
                case 4:
                case 5:
                    Console.WriteLine("봄");
                    break;

                case 6:
                case 7:
                case 8:
                    Console.WriteLine("여름");
                    break;

                case 9:
                case 10:
                case 11:
                    Console.WriteLine("가을");
                    break;
            }
                

                
        }
    }
}
