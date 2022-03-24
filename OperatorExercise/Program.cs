using System;

namespace OperatorExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            int quotient = a / b;
            int remainder = a % b;
            var pi = 20;
            var Rad = 1256.6370614359173;

            if (a == 17 && b == 4)
            {
                Console.WriteLine($"{a} / {b} is {quotient} remainder {remainder}");
                Console.WriteLine($"What is the radius of your circle?");
                Console.WriteLine(pi);
                Console.WriteLine($"The area of a circle with radius of 20 is {Rad}");
                var radius = double.Parse(Console.ReadLine());

            }
        




        }
    }
}
