using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _011_Char
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char chA = 'a';
            char chHan = '한';

            Console.WriteLine($"chA : { chA}");
            Console.WriteLine($"chHan : {chHan}");
            // 타입 크기
            {
                Console.WriteLine("\n 타입 크기");

                char chB ='A';
                Console.WriteLine($"Type  :{chA.GetTypeCode()}\n size : {sizeof(char)}");
            }
            // 저장 범위
            {
                Console.WriteLine("\n 타입 저장범위");

                int maxch = char.MaxValue;
                int minch = char.MinValue;

                Console.WriteLine($"charMax : {maxch}\ncharMin : {minch}");
            }
            //리터럴
            {
                char ch0 = 'j';
                char ch1 = '\u006A';
                char ch2 = '\x6A';
                char ch3 = (char)106;

                Console.WriteLine($"ch0 : {ch0}");
                Console.WriteLine($"ch1 : {ch1}");
                Console.WriteLine($"ch2 : {ch2}");
                Console.WriteLine($"ch3 : {ch3}");

            }
            //변환
            {
                Console.WriteLine("\n변환");

                char chVar = 'A';
                int numCh = chVar;

                Console.WriteLine($"numCh : {numCh}");

                int result = chVar + 'B';
                Console.WriteLine($"result : {result}");
                Console.WriteLine($"result : {(char)result}");
            }
        }
    }
}
