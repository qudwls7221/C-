using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_ReadLine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                Console.Write("문장을 입력하시오 : ");
                var inputData = Console.ReadLine();
                Console.WriteLine($"입력한값은 : {inputData}");
                Console.WriteLine($"Type : {inputData.GetType()}");
            }
            {
                Console.Write("정수를 입력하시오 : ");
                var strNum1 = Console.ReadLine();
                Console.Write("정수를 입력하시오 : ");
                var strNum2 = Console.ReadLine();
                
                var num1 = int.Parse(strNum1);
                var num2 = Convert.ToInt32(strNum2);

                Console.WriteLine($"{num1} type : {num1.GetType()}");
                Console.WriteLine($"{num2} type : {num2.GetType()}");

            }
            {
                Console.Write("문자를 입력하시오");
                var readVar = Console.Read();

                Console.WriteLine($"입력문자 : {readVar} Type : {readVar.GetType()}");
                Console.WriteLine($"입력문자 : {(char)readVar} Type : {readVar.GetType()}");
            }
            {
                ConsoleKeyInfo info;
                Console.Write("키를입력하시오 : ");
                info = Console.ReadKey();
                Console.WriteLine($"입력한 키는 : {info.Key}");
                
                Console.Write("키를입력하시오 : ");
                info = Console.ReadKey(true);
                Console.WriteLine($"입력한 키는 : {info.Key}");
            }
        }
    }
} 
