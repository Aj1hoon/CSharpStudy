using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test._4
{
    class Employee
    {
        public string Name { get; set; } = "홍길동"; // 캡슐화 된 데이터(private name, private position)에 쉽게 접근하려고 사용하는 getter, setter
        public string Position { get; set; } = "사원";

        public void Show()
        {
            Console.WriteLine("====================");
            Console.WriteLine("이름 : " + Name);
            Console.WriteLine("직급 : " + Position);
            Console.WriteLine("--------------------");
        }
    }

    internal class _4_03
    {
        static void Main03(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.Show();

            Employee emp2 = new Employee();
            emp2.Name = "김유신";
            emp2.Position = "대리";
            emp2.Show();

            Employee emp3 = new Employee() { Name="김춘추", Position="과장" };
            emp3.Show();

        }
    }
}
