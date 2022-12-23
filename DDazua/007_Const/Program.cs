using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _007_Const
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 100;
            num = 0;
            Console.WriteLine($"num : {num}");

            const int CONST_NUM = 200;
            Console.WriteLine($"Const_NUM : {CONST_NUM}");
            CONST_NUM = 100;
            const int cNum;
        }
    }
}
