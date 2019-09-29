using System;
using System.Collections.Generic;
using System.Linq;

namespace maxvalue_player
{
    class Program
    {
        static void Main(string[] args)
        {
            bool game = true;
            int max = 0;
            List<Player> playerList = new List<Player>(); // list of player
            List<int> scoreplayer = new List<int>();    // list player scores
            Console.WriteLine("Welcome to this program!");
            Console.ReadLine();

            while (game)
            {
                Player players = new Player(); // object name is players from clas Player

                Console.Write("Enter player first name: ");
                string input = Console.ReadLine();
                if (input == "n")
                {
                    game = false;
                }
                players.FirstName = input;  // input first name from user 
                Console.Write("Enter player last name: ");
                input = Console.ReadLine();
                players.LastName = input;   // input last name from user
                Console.Write("Enter player score:");
                input = Console.ReadLine();     // input scores from users
                players.Score = int.Parse(input);

                playerList.Add(players);

                Console.WriteLine("do you want to enter another player y/n");
                input = Console.ReadLine(); // user enter y to continue or n to finish
                if (input == "y")
                {
                    game = true;
                }
                else if (input == "n")
                {
                    game = false;
                }
                scoreplayer.Add(players.Score);
                max = scoreplayer.Max();
                scoreplayer.Sort();

            }
            // print details of users
            for (int i = 0; i < playerList.Count; i++)
            {
                playerList[i].Printdetails();

            }
            Console.WriteLine("max score is : " + scoreplayer.Max());
        }
    }
}
