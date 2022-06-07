using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book.Ch03
{
    internal class P142
    {
        static void Main142(string[] args)
        {
            string num1 = Console.ReadLine();
            int number1 = int.Parse(num1);

            // 참과 거짓 위치에 불 자료형 사용
            Console.WriteLine(number1 % 2 == 0 ? true : false);

            string num2 = Console.ReadLine();
            int number2 = int.Parse(num2);

            // 참과 거짓 위치에 문자열 자료형 사용
            Console.WriteLine(number2 % 2 == 0 ? "짝수" : "홀수");

            /// 삼항 연산자를 이용한 자연수 판별 - P143
            
            string num3 = Console.ReadLine();
            int number3 = int.Parse(num3);

            Console.WriteLine(number3 > 0 ? "자연수" : "자연수 아님");
        }
    }
}
