using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch02
{
    internal class P85
    {
        static void Main85(string[] args)
        {
            char a = 'A';
            Console.WriteLine(a);
            Console.WriteLine();

            // 각 자료형의 크기를 알 수 있게 해주는 sizeof(자료형)
            Console.WriteLine("int : "    + sizeof(int));
            Console.WriteLine("long : "   + sizeof(long));
            Console.WriteLine("float : "  + sizeof(float));
            Console.WriteLine("double : " + sizeof(double));
            Console.WriteLine("char : "   + sizeof(char));
        }
    }
}
