using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * 날짜 : 2022/06/02
 * 이름 : 김철학
 * 내용 : C# 변수 실습하기 교재p.79
 * 
 * 변수(Variable)
 *  - 데이터를 처리하기 위해 생성되는 메모리 공간
 *  - 여러번 데이터를 변경할 수 있음
 *  
 *  상수(Constant)
 *  - 데이터를 변경할 수 없는 변수
 */
namespace Ch02
{
    internal class _1_Variable
    {
        static void Main1(string[] args)
        {
            ///////////////////////////
            //변수
            ///////////////////////////
            int num1;
            num1 = 1;

            int num2 = 2;
            int num3 = num1 + num2;

            Console.WriteLine("num3 ; "+num3);



            ///////////////////////////
            //상수
            ///////////////////////////
            const double PI = 3.151592;
            const int NUM = 10;
            //num = 20; <-상수는 값 변경 X
            //num = 30;

            Console.WriteLine("NUM : "+NUM);
            Console.WriteLine("PI : " + PI);
        }
    }
}
