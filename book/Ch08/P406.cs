using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch08
{
    internal class P406
    {
        struct Point
        {
            public char x;
            public char y;

            public Point(char x, char y)
            {
                this.x = x;
                this.y = y;
            }

            static void Main406(string[] args)
            {
                Point point = new Point();

                Console.WriteLine("" + point.x);
                Console.WriteLine("" + point.y);
            }
        }
    }
}
