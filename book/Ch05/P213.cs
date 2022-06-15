using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch05
{
    internal class P213
    {
        static void Main213(string[] args)
        {
            // 변수를 선언합니다.
            List<int> list = new List<int>();

            // 리스트에 요소를 추가합니다.
            list.Add(11);
            list.Add(77);
            list.Add(777);
            list.Add(7777);
            list.Add(77777);

            // 반복을 수행합니다.
            foreach (var i in list)
            {
                Console.WriteLine("Count : " + list.Count + "  Item : " + i);
            }
        }
    }
}
