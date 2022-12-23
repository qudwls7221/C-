using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _010_Nullable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? num = 100;
            double? dNum = 3323245545.23d;

            Console.WriteLine($"num : {num}");
            Console.WriteLine($"num : {num.Value}");
            Console.WriteLine($"num : {num.HasValue}");
            Console.WriteLine($"dNum : {dNum}");
            num = null;
            Console.WriteLine($"num : {num}");

            int? nullNum = 100;
            int numCast = (int)nullNum;

            Console.WriteLine($"numCast : {numCast}");
        }
    }
}
