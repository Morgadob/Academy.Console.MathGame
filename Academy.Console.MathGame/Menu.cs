namespace MathGame
{
    internal class Menu
    {
        GameEngine engine = new();

        internal void  showMenu(string name, DateTime date)
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
                        Helpers.getGames();
                        break;
                    case "a":
                        engine.AdditionGame("Addition game");
                        break;
                    case "s":
                        engine.SubtractionGame("Subtraction game");
                        break;
                    case "m":
                        engine.MultiplicationGame("Multiplication game");
                        break;
                    case "d":
                        engine.DivisionGame("Division game");
                        break;
                    case "q":
                        Console.WriteLine("Goodbye");
                        isGameOn = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;
                }
            }
            while (isGameOn);

            //return gameSelected;
        }

    }
}
