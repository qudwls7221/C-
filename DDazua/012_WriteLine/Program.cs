using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _012_WriteLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 12345;
            float fNum = 0.0455663f;
            double dNum = 123456789.0;

            Console.WriteLine("{0}{1}{1}{2}{2}", num, fNum, dNum);
            Console.WriteLine("{0:D},{0:D8},{0:D3}", num);
            Console.WriteLine("{0}, {0:F}, {0:F3}, {0:F10}", fNum);
            Console.WriteLine("{0}, {0:E}, {0:E2}", dNum);
            Console.WriteLine("0x{0:X}", num);

            Console.WriteLine("{0:C3}, {1}", num, num.ToString("C"));
            Console.WriteLine("{0:N}, {0:N1}, {0:N3}", num);
            Console.WriteLine("{0:P}, {0:P1}, {0:P3}", num);

            double d1 = 12345.45567;
            Console.WriteLine($"{d1:##.##}");

            double d2 = 123456.9;
            Console.WriteLine($"{d2:#,##0.0}");

            double d3 = 12345678999;
            Console.WriteLine($"{d3:###-####-####}");
        }
    }
}
