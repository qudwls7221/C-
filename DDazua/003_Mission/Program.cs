using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Mission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float f1 = float.MinValue;
            float f2 = float.MaxValue;
            double d1 = double.MinValue;
            double d2 = double.MaxValue;
            decimal dc1 = decimal.MinValue;
            decimal dc2 = decimal.MaxValue;

            Console.WriteLine($"float\tMin: {f1}\t\t~ Max:{f2}");
            Console.WriteLine($"double\tMin: {d1}\t~ Max: {d2}");
            Console.WriteLine($"decimal\tMin: {dc1}\t~ Max: {dc2}");
        }
    }
}
