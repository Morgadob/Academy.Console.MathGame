using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathGame
{
    internal class GameEngine
    {
        internal void AdditionGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);

            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} + {secondNumber}");
                var result = Console.ReadLine();

                if (int.Parse(result) == firstNumber + secondNumber)
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect! Type any key for the next question");
                    Console.ReadLine();
                }

                if (i == 4) Console.WriteLine($"Game over. Your final score is {score}. Pretty any key to go back to the main menu");
                Console.ReadLine();


                //games.Add($"{DateTime.Now} - Addition: Score = {score}");

            }

            Helpers.AddToHistory(score, "Addition");



        }

        internal void SubtractionGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);

            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} - {secondNumber}");
                var result = Console.ReadLine();

                if (int.Parse(result) == firstNumber - secondNumber)
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect! Type any key for the next question");
                    Console.ReadLine();
                }

                if (i == 4) Console.WriteLine($"Game over. Your final score is {score}");
            }

            Helpers.AddToHistory(score, "Subtraction");
        }

        internal void MultiplicationGame(string message)
        {
            Console.Clear();
            Console.WriteLine(message);


            var random = new Random();
            var score = 0;

            int firstNumber;
            int secondNumber;

            for (int i = 0; i < 5; i++)
            {
                firstNumber = random.Next(1, 9);
                secondNumber = random.Next(1, 9);

                Console.WriteLine($"{firstNumber} * {secondNumber}");
                var result = Console.ReadLine();

                if (int.Parse(result) == firstNumber * secondNumber)
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question");
                    score++;
                    Console.ReadLine();
                    Console.WriteLine($"Your score is {score}");
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect! Type any key for the next question");
                    Console.ReadLine();
                    Console.WriteLine($"Your score is {score}");
                }

                if (i == 4) Console.WriteLine($"Game over. Your final score is {score}");
            }

            Helpers.AddToHistory(score, "Multiplication");
        }

        //Division is broken, it does not create new questions, it needs to be fixed.
        internal void DivisionGame(string message)
        {

            var score = 0;
            var divisionNumbers = Helpers.GetDivisionNumbers();




            for (int i = 0; i < 5; i++)
            {
                Console.Clear();
                Console.WriteLine(message);


                var firstNumber = divisionNumbers[0];
                var secondNumber = divisionNumbers[1];

                Console.WriteLine($"{firstNumber} / {secondNumber}");
                var result = Console.ReadLine();

                if (int.Parse(result) == firstNumber / secondNumber)
                {
                    Console.WriteLine("Your answer was correct! Type any key for the next question");
                    score++;
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Your answer was incorrect! Type any key for the next question");
                    Console.ReadLine();
                }

                if (i == 4) Console.WriteLine($"Game over. Your final score is {score}");
            }

            Helpers.AddToHistory(score, "Division");

        }

    }
}
