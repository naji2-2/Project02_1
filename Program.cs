using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project02_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            // 나중에 입력 받을 예정

            int result;

            a = 100;
            b = 50;

            result = a + b;
            Console.WriteLine(a + "+" + b + "=" + result);  // operator : 연산자

            result = a - b;
            Console.WriteLine(a + "-" + b + "=" + result);

            result = a * b;
            Console.WriteLine(a + "*" + b + "=" + result);

            // 0으로 나누게 될 경우 대비하기
            result = a / b;
            Console.WriteLine(a + "/" + b + "=" + result);

        }
    }
}
