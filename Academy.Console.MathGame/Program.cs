using System;
using System.Collections.Generic;

namespace MathProgramCommandLine
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = DateTime.UtcNow;

            var games = new List<string>();

            string name = GetName();
           
            Menu(name);

            String GetName()
            {
                Console.WriteLine("Please type your name");
                name = Console.ReadLine();

                return name;
            }

            void Menu(string name)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine($"Hello {name}. It's {date.DayOfWeek}. This is your math game. That's great that you're working on improving yourself");
                Console.WriteLine("\n");

                var isGameOn = true;

                do
                {
                    Console.Clear();
                    Console.WriteLine($@"What game would you like to play today? Choose from the options below:
                    V - View previous games
                    A - Addition
                    S - Subtraction
                    M - Multiplication
                    D - Division
                    Q - Quit the program");
                    Console.WriteLine("------------------------------------");

                    var gameSelected = Console.ReadLine();

                    switch (gameSelected.Trim().ToLower())
                    {
                        case "v":
                            getGames();
                            break;

                        case "a":
                            AdditionGame("Addition game");
                            break;
                        case "s":
                            SubtractionGame("Subtraction game");
                            break;
                        case "m":
                            MultiplicationGame("Multiplication game");
                            break;
                        case "d":
                            DivisionGame("Division game");
                            break;
                        case "q":
                            Console.WriteLine("Goodbye");
                            isGameOn = false;
                            break;
                        default:
                            Console.WriteLine("Invalid Input");
                            Environment.Exit(1);
                            break;
                    }
                }
                while(isGameOn);
             
                //return gameSelected;
            }


            void AdditionGame(string message)
            {
                Console.Clear();
                Console.WriteLine(message);

                var random = new Random();
                var score = 0;

                int firstNumber;
                int secondNumber;

                for(int i=0; i < 5; i++)
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
                    Console.WriteLine();


                    games.Add($"{DateTime.Now} - Addition: Score = {score}");

                }
            }

            void SubtractionGame(string message)
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

            }

            void MultiplicationGame(string message)
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
            }

            void DivisionGame(string message)
            {
                for (int i=0; i < 5; i++)
                {
                    Console.Clear();
                    Console.WriteLine(message);

                    var score = 0;
                    var divisionNumbers = GetDivisionNumbers();
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

            }

            int[] GetDivisionNumbers()
            {
                var random = new Random();
                var firstNumber = random.Next(0, 99);
                var secondNumber = random.Next(0, 99);


                var result = new int[2];

             

                while (firstNumber % secondNumber != 0)
                {
                     firstNumber = random.Next(0, 99);
                     secondNumber = random.Next(0, 99);
                }

                result[0] = firstNumber;
                result[1] = secondNumber;

                return result;
            }


            void getGames()
            {
                Console.Clear();
                Console.WriteLine("Games History");
                Console.WriteLine("----------------------------");

                foreach (var game in games)
                {
                    Console.WriteLine(game);
                }
                Console.WriteLine("----------------------------/n");
            }
        }

        
    }
}
