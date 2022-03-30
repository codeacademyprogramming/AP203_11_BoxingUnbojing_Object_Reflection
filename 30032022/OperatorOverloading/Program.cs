using System;

namespace OperatorOverloading
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 7;

            int result = num1 + num2;

            Box box1 = new Box(10, 40);
            Box box2 = new Box(5, 15);

            var sum = box1 + box2;
            sum = box1 + 5;

            Console.WriteLine(sum.Width+" - "+sum.Height);
        }
    }
}
