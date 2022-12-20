using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_Variable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //변수 선언의 기초방법.
            {
                //int number = 10;
                int number;
                number = 10;
                Console.WriteLine(number);
            }
            //number = 1000;
            //여기서는 {} 의 외부이기때문에 number 변수는 사용할수없다.
            //변수 선언의 다양한 방법. 자바의 변수선언방식과 동일하다.
            {
                int x;
                int a, b, c;

                int xx = 100;
                int aa = 0, bb = 1, cc = 2;
            }
        }
    }
}
