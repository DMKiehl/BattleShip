using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleShipGame
{
    class GamePlay
    {
        //member variables
        public Player player1;
        public Player player2;
        public int PlayerOneScore;
        public int PlayerTwoScore;
        //constructor
        public GamePlay()
        {

        }

        public void PlayGame()
        {
            DisplayRules();

        }
           
        //member methods

        public void DisplayRules()
        {
            Console.WriteLine("Welcome to Battleship!\n");
            Console.WriteLine("Here are the rules to the game: \n ");
            Console.WriteLine("Each player will take a turn placing their 5 ships on the board. \nPlayers must place their ships fully on the board, must not be diagnoally placed, and can't overlap.");
            Console.WriteLine("Taking turns a player will choose a location to strike (ex. C3)");
            Console.WriteLine("First player to sink all 5 of the opposing players ships wins.");
            Console.ReadLine();


        }
        

    }
}
