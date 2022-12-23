using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _009_Var
{
    internal class Program
    {
        //var numVar = 100; 사용이불가능하다. (멤버 변수 사용불가능.)


        //static var Func() {} 사용불가 함수의 반환형으로 사용불가
        //static void Func(var a, var b) 함수의 파라미터로 사용불가
        static void Main(string[] args)
        {
            // var 은 지역변수로만 사용할수있다. 
            var numVar = 100;
            var numFVar = 0.00043f;

            Console.WriteLine($"numVar : {numVar}");
            Console.WriteLine($"numFVar : {numFVar}");

            //var numNull = null; //null초기값으로 사용불가능.
        }
    }
}
