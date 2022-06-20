using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch09
{
    internal class P432
    {
        class Dummy : IDisposable
        {
            public void Dispose()
            {
                Console.WriteLine("Dispse() 메서드를 호출합니다.");
            }
        }

        static void Main432(string[] args)
        {
            Dummy dummy = new Dummy();
            dummy.Dispose();

            using (Dummy dummy1 = new Dummy())
            {
            }
        }
    }
}
