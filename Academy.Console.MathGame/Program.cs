//using Academy.Console.MathGame;
using System;
using System.Collections.Generic;
using static System.Formats.Asn1.AsnWriter;


namespace MathGame
{
    class Program
    {
        static void Main(string[] args)
        {

            var menu = new Menu();

            var date = DateTime.UtcNow;

            var games = new List<string>();

            string name = GetName();
           
            menu.showMenu(name, date);

            String GetName()
            {
                Console.WriteLine("Please type your name");
                name = Console.ReadLine();

                return name;
            }

           

            

            


            
        }
    }
}
