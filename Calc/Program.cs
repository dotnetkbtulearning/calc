using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calc
{
    class Program
    {
        static void Main(string[] args)
        {
            var isWork = true;

            Calculator clc = new Calculator();
            
            while (isWork)
            {

                var a = GetValueFromConsole("Введите а");

                var b = GetValueFromConsole("Введите Введите b");

                var operation = GetValueFromConsole("Введите операцию: +, -, *, /");
                
                clc.A = Convert.ToDouble(a);
                clc.B = Convert.ToDouble(b);
                var res = clc.Execute(operation);

                Console.WriteLine("Res: " + res);

                var answer = GetValueFromConsole("Хотите закончить? (1 - да, 0 - нет)");
                if (answer == "1")
                {
                    isWork = false;
                }

            }

        }

        static string GetValueFromConsole(string message)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        

    }

    
}
