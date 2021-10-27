using System;

namespace Power Formula 
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("P value  :");
            decimal P = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("T value  :");
            decimal T = Convert.ToDecimal(Console.ReadLine());
            decimal result = P * T;
            Console.WriteLine(" W = " + result);
        }
    }
}
