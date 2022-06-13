using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch04
{
    internal class P183
    {
        static void Main183(string[] args)
        {
            string input = "감자 고구마 토마토";
            string[] inputs = input.Split(new char[] { ' ' });

            foreach (var item in inputs)  // foreach는 보통 var를 사용해 자료형을 자동으로 선택하는 방법이 일반적이다.
            {
                Console.WriteLine(item);
            }
        }
    }
}
