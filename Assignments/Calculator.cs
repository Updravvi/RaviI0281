using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignments
{
    public class Calculator
    {

        int a, b, c;
        char ch;

        public void CalculatorOperation()
        
        {
            Console.WriteLine("Calculator");
            Console.Write("Enter 1st Number : ");

            //string s = Console.ReadLine();
            a = int.Parse(Console.ReadLine());

            Console.Write("Enter 2nd Number : ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Select operation (+,-,*,/) ");
            ch = char.Parse(Console.ReadLine());

            switch (ch)
            {
                case '+':

                    c = Add(a, b);
                    Console.WriteLine("Addition : " + c);
                    break;

                case '-':
                    c = Sub(a, b);
                    Console.WriteLine("Substraction  : " + c);
                    break;

                case '*':
                    c = Mul(a, b);
                    Console.WriteLine("Multiplicatio: " + c);
                    break;

                case '/':
                    c = Div(a, b);
                    Console.WriteLine("Division : " + c);
                    break;

                default:
                    Console.WriteLine("Invalid operation");
                    break;
            }
            Console.Write("Enter to exit ");
            Console.ReadLine(); 
        }

        //Add
        public int Add(int x, int y)
        {
            return x + y;
        }

        //Sub
        public int Sub(int x, int y)
        {
            return x - y;
        }

        //Mul
        public int Mul(int x, int y)
        {
            return x * y;
        }

        //Div
        public int Div(int x, int y)
        {
            return x / y;
        }

    }
}
