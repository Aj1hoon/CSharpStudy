using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch05
{
    internal class P203
    {
        // 자료형 정의
        int carNumber;
        int inTime;
        int outTime;

        // 자료형 정의 -> 배열
        int[] carNumbers = new int[10];
        int[] inTimes = new int[10];
        int[] outTimes = new int[10];

        // 자료형 정의 -> 배열 -> class
        class Car
        {
            int carNumber;
            int inTime;
            int outTime;
        }

        static void Main205(string[] args)
        {
            Car[] cars = new Car[10];
        }
    }
}
