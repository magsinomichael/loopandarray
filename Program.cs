using System;

namespace WhileLoopExample
{

    class Program
    {
        static void Main(string[] args)
        {

            //             int number;
            //             int sum = 0;

            //             Console.WriteLine("Enter a number to add. Note: If you type zero(0), number input will stop: ");

            //             while (true)
            //             {
            //                 Console.WriteLine("Enter a number: ");
            //                 number = Convert.ToInt32(Console.ReadLine());

            //                 if (number == 0)
            //                     break;

            //                 sum += number;
            //             }

            //             Console.WriteLine($"Total Sum is: {sum}");
            //         }
            //     }

            // }
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
            // int[] numbers = { 5, 10, 15, 0, 20, 25, -30 };

            // Console.WriteLine("Processing numbers....");

            // for (int i = 0; i < numbers.Length; i++)
            // {
            //     // if (numbers[i] == 0)
            //     // {
            //     //     Console.WriteLine("Skipped Zero");
            //     //     continue;
            //     // }
            //     if (numbers[i] < 0)
            //     {
            //         Console.WriteLine("We've found a Negative Number. Stopping now");
            //         break;
            //     }
            //     Console.WriteLine($"Numbers: {numbers[i]}");
            // }

            Console.Write("How many students do you have (1-10)? ");
            if (!int.TryParse(Console.ReadLine(), out int maxStudents) || maxStudents < 1 || maxStudents > 10)
            {
                Console.WriteLine("Invalid number of students.");
                return;
            }

            int validCount = 0;
            double totalScore = 0;

            for (int i = 0; i < maxStudents; i++)
            {
                Console.Write($"\nEnter name of student #{i + 1}: ");
                string? name = Console.ReadLine();

                double score;
                while (true)
                {
                    Console.Write($"Enter score for {name}: ");
                    string? input = Console.ReadLine();

                    if (!double.TryParse(input, out score))
                    {
                        Console.WriteLine("Invalid score. Try again.");
                        continue;
                    }

                    // Stop input if negative score is encountered
                    if (score < 0)
                    {
                        Console.WriteLine("We've found negative score: stopping input.");
                        goto CalculateResults;
                    }

                    // Skip zero score but keep input going
                    if (score == 0)
                    {
                        Console.WriteLine("Score is zero(0): Skip this student.");
                        break; // go to next student
                    }

                    break; // valid positive score
                }

                if (score > 0)
                {
                    totalScore += score;
                    validCount++;
                }
            }

        CalculateResults:

            if (validCount > 0)
            {
                Console.WriteLine($"\nTotal students with valid scores: {validCount}");
                Console.WriteLine($"Average score: {(totalScore / validCount):F2}");
            }
            else
            {
                Console.WriteLine("\nNo valid scores entered.");
            }


        }
    }
}


