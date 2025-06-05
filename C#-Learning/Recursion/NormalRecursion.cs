using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Learning.Recursion
{
    public class NormalRecursion : ILearnInterface
    {
        public void Run()
        {
            Console.WriteLine("Enter a Number:");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The Factorial of Number {a} is {Factorial(a)}");
            Console.ReadLine();
        }

        private static int Factorial(int n)
        {
            if (n == 0 || n == 1) return 1;
            return n * Factorial(n - 1);
        }
    }
}
