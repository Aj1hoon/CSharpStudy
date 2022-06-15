using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch08
{
    internal class P404
    {
        class program
        {
            struct Point
            {
                public int x;
                public int y;
            }

            static void Main404(string[] args)
            {
                Point point;
                point.x = 10;
                point.y = 10;

                Console.WriteLine(point.x);
                Console.WriteLine(point.y);
            }
        }
    }
}
