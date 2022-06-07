using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch03
{
    internal class P135
    {
        static void Main135(string[] args)
        {
            //if else if 조건문
            if (DateTime.Now.Hour < 11)
            {
                Console.WriteLine("아침 먹을 시간입니다.");
            }
            else if (DateTime.Now.Hour < 15)
            {
                Console.WriteLine("점심 먹을 시간입니다.");
            }
            else
            {
                Console.WriteLine("저녁 먹을 시간입니다.");
            }

            // 논리 연산자와 조건문
            // 학점 변수
            double score = 1.2;
            // 조건을 구분합니다.
            if (score == 4.5)
                Console.WriteLine("신");
            else if (4.2 <= score && score < 4.5)
                Console.WriteLine("반신");
            else if (3.5 <= score && score < 4.2)
                Console.WriteLine("인간계 최강");
            else if (2.8 <= score && score < 3.5)
                Console.WriteLine("인간계");
            else if (2.3 <= score && score < 2.8)
                Console.WriteLine("백정");
            else if (1.75 <= score && score < 2.3)
                Console.WriteLine("망나니");
            else if (1.0 <= score && score < 1.75)
                Console.WriteLine("벌레");
            else if (0.5 <= score && score < 1.0)
                Console.WriteLine("생략");


            // 조건문 간단 사용
            Console.Write("학점 : ");
            double sco = double.Parse(Console.ReadLine());
            
            if (sco == 4.5)
                Console.WriteLine("신");
            else if (4.2 <= sco)
                Console.WriteLine("반신");
            else
                Console.WriteLine("생략");



        }
    }
}
