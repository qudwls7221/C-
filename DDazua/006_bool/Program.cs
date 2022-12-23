using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _006_bool
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isEqual = 100 == 100; // == 는 =이다 '같다'
            bool isResult = 100 < 1; // false 저장

            Console.WriteLine($"isEqual : {isEqual}\nisResult : {isResult}");
        }
    }
}
