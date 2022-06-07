using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 날짜 : 2022/06/07
 * 이름 : 안지훈
 * 내용 : 반복문 while 실습하기 교재 p162
 */

namespace Ch03
{
    internal class _4_While
    {
        static void Main4(string[] args)
        {
            // 1부터 10까지 합
            int sum = 0;
            int k = 1;

            while(k <= 10)
            {
                sum += k;
                k++;
            }
            Console.WriteLine("1부터 10까지 합 : " + sum);

            // do ~ while : 최초 1번은 무직껀 실행하는 반복문.
            int tot = 0;
            int j = 1;

            do
            {
                if (j % 2 == 0)
                {
                    tot += j;
                }
                j++;
            }
            while(j <= 10);

            Console.WriteLine("1부터 10까지 짝수합 : "+ tot);


            // break
            int num = 1;

            while(true)
            {
                if(num % 5 == 0 && num % 7 == 0)
                {
                    break; // 반복문 종료
                }
                num++;
            }
            Console.WriteLine("5와 7의 최소공배수 : "+ num);


            // continue
            int total = 0;
            int i = 0;


            while(i <= 10)
            {
                i++;

                if(i % 2 == 1)
                { 
                    continue; // 반복문의 처음으로 이동
                }
                total += i;

            }

            Console.WriteLine("1부터 10까지 짝수합 : "+ total);


        }
    }
}
