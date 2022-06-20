using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch09
{
    internal class P445
    {
        static void Main445(string[] args)
        {
            using (StreamWriter writer = new StreamWriter(@"C:\Users\1302\Desktop\test.txt"))
            {
                writer.WriteLine("안녕하세요");
                writer.WriteLine("StreamWriter 클래스를 사용해");
                writer.WriteLine("글자를 여러 줄 입력해봅니다");

                for (int i = 0; i < 10; i++)
                {
                    writer.WriteLine("반복문 - " + i);
                }
            }
            Console.WriteLine(File.ReadAllText(@"C:\Users\1302\Desktop\test.txt"));
        }
        
    }
}

