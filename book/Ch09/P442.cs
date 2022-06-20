using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch09
{
    internal class P442
    {
        static void Main442(string[] args)
        {
            File.WriteAllText(@"C:\Users\1302\Desktop\test.txt", "문자열을 파일에 씁니다");
            Console.WriteLine(File.ReadAllText(@"C:\Users\1302\Desktop\test.txt"));
        }
    }
}
