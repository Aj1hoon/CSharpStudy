using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch05
{
    internal class P205
    {
        class Car
        {
            // 속성
            public int carNumber;
            public DateTime inTime;

            // 기능 메서드
            public void SetInTime(DateTime inTime)
            {
                this.inTime = DateTime.Now;
            }

            public void Show()
            {
                Console.WriteLine("===================");
                Console.WriteLine("차량번호 : " + carNumber);
                Console.WriteLine("입차시간 : " + inTime);
            }
        }

        static void Main205(string[] args)
        {
            // 객체 생성
            Car car = new Car();

            // 객체 초기화
            car.carNumber = 555555;
            car.inTime = DateTime.Now;

            // 객체 기능
            car.SetInTime(DateTime.Now);
            car.Show();
           

        }

    }
}
