using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._2
{
    internal class _2_02
    {
        static void Main02(string[] args)
        {
            int[] arr = { 17, 92, 18, 33, 58, 7, 26, 42 };

            int minNum = arr[0];

            for (int i = 0; i < 8; i++)
            {
                if (minNum > arr[i])
                {
                    minNum = arr[i];
                }
            }
            Console.WriteLine("배열 arr에서 가장 작은 수 : " + minNum);
        }
    }
}
