using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Mission
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("정수 자료형의 min ~ max 출력");

            sbyte minsb = sbyte.MinValue;
            sbyte maxsb = sbyte.MaxValue;
            byte minb = byte.MinValue;
            byte maxb = byte.MaxValue;
            short mins = short.MinValue;
            short maxs = short.MaxValue;
            ushort minus = ushort.MinValue;
            ushort maxus = ushort.MaxValue;
            int mini = int.MinValue;
            int maxi = int.MaxValue;
            uint minui = uint.MinValue;
            uint maxui = uint.MaxValue;
            long minl = long.MinValue;
            long maxl = long.MaxValue;
            ulong minul = ulong.MinValue;
            ulong maxul = ulong.MaxValue;

            Console.WriteLine($"sbyte  Min : {minsb}\t ~ Max : {maxsb}");
            Console.WriteLine($"byte   Min : {minb}\t\t ~ Max : {maxb}");
            Console.WriteLine($"short  Min : {mins}\t ~ Max : {maxs}");
            Console.WriteLine($"ushort Min : {minus}\t\t ~ Max : {maxus}");
            Console.WriteLine($"Int    Min : {mini} ~ Max : {maxi}");
            Console.WriteLine($"uInt   Min : {minui}\t\t ~ Max : {maxui}");
            Console.WriteLine($"long   Min : {minl}\t ~ Max : {maxl}");
            Console.WriteLine($"ulong  Min : {minul}\t\t ~ Max : {maxul}");
        }
    }
}
