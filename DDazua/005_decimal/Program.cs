using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _005_decimal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                decimal dcNum = 2142145436.0124m; // 접미사 m M 이다. 접미사 필수
                Console.WriteLine($"dcNum : {dcNum}");
            }
            //타입 & 크기
            {
                Console.WriteLine("\n타입 & 크기");

                decimal dcNum = 2142145436.0124m;

                Console.WriteLine($"Type : {dcNum.GetType()} \t Size : {sizeof(decimal)}");
            }
            // 저장 가능 범위
            {
                Console.WriteLine("\n저장 가능범위");

                decimal dcNummin = decimal.MinValue;
                decimal dcNummax = decimal.MaxValue;
                Console.WriteLine($"Float min : {dcNummin}\nFloat max : {dcNummax}");
            }
        }
    }
}
