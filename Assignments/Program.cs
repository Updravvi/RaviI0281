using System.Security.Cryptography.X509Certificates;

namespace Assignments
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, Ravi!");

            Console.WriteLine("Multiplication Table Using a For Loop");
            Console.Write(" Enter the Number : ");

            //string s = Console.ReadLine();
            int x = int.Parse(Console.ReadLine());
            Console.Write(" Enter Table of :" + x);

            Table(x);

            Console.WriteLine("Calculator");
            Console.Write("Enter 1st Number : ");

            //string s = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter 1st Number : ");
            int b = int.Parse(Console.ReadLine());
            int c;

            c = Add(a, b);
            Console.WriteLine("Addition : " + c);

            c = Sub(a, b);
            Console.WriteLine("Substraction  : " + c);

            c = Mul(a, b);
            Console.WriteLine("Multiplicatio: " + c);

            c = Div(a, b);
            Console.WriteLine("Division : " + c);

            //Add
            int Add(int x, int y)
            {
                return x + y;
            }

            //Sub
            int Sub(int x, int y)
            {
                return x - y;
            }

            //Mul
            int Mul(int x, int y)
            {
                return x * y;
            }

            //Div
            int Div(int x, int y)
            {
                return x / y;
            }

            void Table(int x)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(x + " *" + i + " = " + x * i);
                }

            }




        }
    }
}
