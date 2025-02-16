//using System.Security.Cryptography.X509Certificates;

namespace Assignments
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, Ravi!");

            Console.WriteLine("Multiplication Table Using a For Loop");

            Console.Write(" Enter the Number : ");

            string s = Console.ReadLine();
            int x = int.Parse(s);

            Console.Write(" Enter Table of :" + x);

            Multiply(x);


            void Multiply(int x)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.WriteLine(x + " *" + i + " = " + x * i);
                }

            }




        }
    }
}
