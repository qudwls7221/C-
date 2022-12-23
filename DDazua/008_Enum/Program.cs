using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _008_Enum
{
    enum Color_Type
    {
        White, //0
        Red,   //1
        Bule,  //2
        Yellow,//3
    }
    internal class Program
    {
        enum DAY : ushort
        {
            MON, THE, WED, TUE, FRI, SAT, SUN
        }
        static void Main(string[] args)
        {
            Console.WriteLine($"Color_Type.White : {(int)Color_Type.White}");
            Console.WriteLine($"Color_Type.Red : {(int)Color_Type.Red}");
            Console.WriteLine($"Color_Type.Blue : {(int)Color_Type.Bule}");
            Console.WriteLine($"Color_Type.Yellow : {(int)Color_Type.Yellow}");

            DAY day = DAY.SUN;

            Console.WriteLine($"day : {day}");
            Console.WriteLine($"(int)day : {(int)day}");
        }
    }
}
