using System;
using Models;

namespace Views
{
    class MainMenu
    {
        public static void display()
        {
            Boolean running = true;
            while (running)
            {
                Console.WriteLine("");
                Console.WriteLine("1) Start new game");
                Console.WriteLine("2) Quit");

                String input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        Game.game();
                        break;
                    case "2":
                        Console.WriteLine("Closing Application...");
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Not a valid command");
                        break;
                }
            }
        }
    }
}