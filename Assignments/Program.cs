using System.Security.Cryptography.X509Certificates;

namespace Assignments
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, Ravi!");

            //Console.WriteLine("Multiplication Table Using a For Loop");
            //Console.Write(" Enter the Number : ");

            ////string s = Console.ReadLine();
            //int x = int.Parse(Console.ReadLine());
            //Console.Write(" Enter Table of :" + x);
            //Table(x);

            //void Table(int x)
            //{
            //    for (int i = 1; i <= 10; i++)
            //    {
            //        Console.WriteLine(x + " *" + i + " = " + x * i);
            //    }

            ////}
            //Calculator ca = new Calculator();

            //ca.CalculatorOperation();



            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            int[] arr2 = { 2, 3, 4, 5, 6, 7, 8, 9 };

            Console.WriteLine("Array 1 length :"+arr.Length);
            Console.WriteLine("Array 2 length :" + arr2.Length);

            foreach (int item in arr){
                Console.WriteLine(item);
            }
         

            char[] gender = { 'm', 'f', 'm', 'm', 'f' };
            int maleCount = 0, femaleCount = 0;

            // Counting males and females using foreach
            foreach (char g in gender)
            {
                if (g == 'm')
                    maleCount++;
                else if (g == 'f')
                    femaleCount++;
            }

            Console.WriteLine("Number of males: " + maleCount);
            Console.WriteLine("Number of females: "
            + femaleCount);

            Console.ReadLine();

        }
    }
}
