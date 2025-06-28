using System;

namespace WhileLoopExample
{

    class Program
    {
        static void Main(string[] args)
        {

            // string meal;

            // do
            // {
            //     Console.WriteLine("Enter your favorite Meal. Note: if you type 'exit', program will stop");
            //     meal = Console.ReadLine();

            //     if (meal != "exit")
            //     {
            //         Console.WriteLine($"You entered: {meal}");
            //     }
            // } while (meal.ToLower() != "exit");
            // {
            //     Console.WriteLine("Program Ended!!!");
            // }

            // Console.WriteLine("Numbers \t Square");

            // for (int i = 1; i <= 10; i++)
            // {
            //     int square = i * i;
            //     Console.WriteLine($" {i}  \t \t {square}");
            // }
            int[] numbers = { 5, 10, 15, 0, 20, 25, -30 };

            Console.WriteLine("Processing numbers....");

            for (int i = 0; i < numbers.Length; i++)
            {
                // if (numbers[i] == 0)
                // {
                //     Console.WriteLine("Skipped Zero");
                //     continue;
                // }
                if (numbers[i] < 0)
                {
                    Console.WriteLine("We've found a Negative Number. Stopping now");
                    break;
                }
                Console.WriteLine($"Numbers: {numbers[i]}");
            }
        }
    }
}
