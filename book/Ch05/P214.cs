using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch05
{
    internal class P214
    {
        static void Main214(string[] args)
        {
            // 변수를 선언합니다.
            List<int> list = new List<int>() { 52, 273, 32, 64 };

            // 반복을 수행합니다.
            list.Remove(52);

            // 반복을 수행합니다.
            foreach (var i in list)
            {
                Console.WriteLine("Count : " + list.Count + "  List : " + i);
            }
        }
    }
}
