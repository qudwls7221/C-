using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _003_Interger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            int a, b, c;
            
            // 정수선언의 기초
            {
                Console.WriteLine("정수선언의 기초");

                x = 1;
                a = 20;
                b = 30;
                c = 40;

                Console.WriteLine("x : " + x);
                Console.WriteLine($"a : {a}");
                Console.WriteLine("b : {0}", b);
                Console.WriteLine("{0} : {1}", "c : ", c);
            }

            //정수 리터럴
            {
                Console.WriteLine("\n정수 리터럴");

                a = 10;
                b = 0b10;
                c = 0x10;

                Console.WriteLine($"a : {a}");
                Console.WriteLine($"b : {b}");
                Console.WriteLine($"c : {c}");
            }

            //정수 타입 크기
            {
                Console.WriteLine("\n정수 타입 크기");

                Console.WriteLine($"Type of{typeof(int)} Sizeof{sizeof(int)}");
                Console.WriteLine($"Type of{typeof(short)} Sizeof{sizeof(short)}");
                Console.WriteLine($"Type of{typeof(long)} Sizeof{sizeof(long)}");

                int num = 0;
                uint uNum = 0U; // 접미사(U,u)
                short sNum = 0;
                long INum = 0L;
                ulong ulNum = 0ul;

                Console.WriteLine($"num : {num}");
                Console.WriteLine($"unum : {uNum}");
                Console.WriteLine($"snum : {sNum}");
                Console.WriteLine($"lnum : {INum}");
                Console.WriteLine($"ulnum : {ulNum}");
            }
            //저장 가능범위
            {
                Console.WriteLine("저장 가능범위");

                int maxValue = int.MaxValue;
                int minValue = int.MinValue;

                Console.WriteLine($"maxValue : {maxValue}");
                Console.WriteLine($"minValue : {minValue}");
            }
        }
    }
}
