using System;

namespace WhileLoopExample
{

    class Program
    {
        static void Main(string[] args)
        {
            int number;
            int sum;

            Console.WriteLine("Enter a number to add. Note: if you type zero(0) number input will stop");

            while (true)
            {
                Console.Write("Enter a number: ");
                number = Convert.ToInt32(Console.ReadLine());

                if (number == 0)
                {
                    break;
                }
            }
        }
    }
}
