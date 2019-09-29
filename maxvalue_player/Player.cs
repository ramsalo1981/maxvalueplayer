using System;
using System.Collections.Generic;
using System.Text;

namespace maxvalue_player
{
    class Player
    {
        public string FirstName;
        public string LastName;
        public int Score;
        /// <summary>
        /// prints the details about players
        /// </summary>
        public void Printdetails()
        {
            Console.WriteLine($"{FirstName} {LastName} has score: {Score}");
        }

    }
}
