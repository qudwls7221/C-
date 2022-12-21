using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _004_Float_Double
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                float fNum = 0.001f;
                double dNum = 12342315.9;

                Console.WriteLine($"fNum : {fNum}");
                Console.WriteLine($"dNum : {dNum}");

            }
            //수치 접미사
            {
                Console.WriteLine("\n 수치 접미사");

                float fNum = 0.00014f;// f F
                double dNum = 323232324.3d;// d D

                Console.WriteLine($"fNum : {fNum}");
                Console.WriteLine($"dNum : {dNum}");
            }

            //타입 & 크기
            {
                Console.WriteLine("\n 타입 & 크기");

                float fNum = 0.00032f;

                Console.WriteLine($"Type : {fNum.GetType()} \t Size : {sizeof(float)}");
                Console.WriteLine($"Type : {45656234.4.GetType()}\t Size : {sizeof(double)}");
                // 기본적으로 실수형들은 double 형으로 인식하며 구지 float 형으로 지정하지않은 실수는 double 형이다.
            }
            // 저장 가능 범위
            {
                Console.WriteLine("\n저장 가능범위");

                float minFloat = float.MinValue;
                float maxFloat = float.MaxValue;

                Console.WriteLine($"Float min : {minFloat}\nFloat max : {maxFloat}");
            }
            // 다른 표현방식 (지수표현 )
            {
                float x = 0.0000001f;
                float y = 1e3f;
                Console.WriteLine($"\nfNum : {x}\n 이는 1의앞에 0이 7개 있다는 의미이다.");
                Console.WriteLine($"fNum : {y}\n(1e3f입력)반대로 입력하면 원하는값이출력될수도있다.");
            }
        }
    }
}
