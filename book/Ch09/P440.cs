using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch09
{
    internal class P440
    {
        class Parent { }

        class Child : Parent, IDisposable, IComparable
        {
            public void Dispose()
            {
                throw new NotImplementedException();
            }

            public int CompareTo(object obj)
            {
                throw new NotImplementedException();
            }
        }

        static void Main440(string[] args)
        {
            Child child = new Child();
            Parent childAsParent = new Child();
            IDisposable childAsDisposable = new Child();
            IComparable childAsComparable = new Child();
        }
    }
}
