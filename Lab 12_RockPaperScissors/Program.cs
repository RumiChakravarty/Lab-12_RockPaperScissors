using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12_RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock Paper Scissors!");
            Console.Write("Enter your name : ");
            string nameOfThePlayer = Console.ReadLine();

            Player1 firstPlayer = new Player1(nameOfThePlayer);
            Player2 secondPlayer = new Player2("Thejets");
            Player3 thirdPlayer = new Player3("TheShark");

            Console.Write("Would you like to play against TheJets or theSharks(j/s)?");
            string choosePartner = Console.ReadLine();
            string doYouWantToPlay = "";

            do
            {
                Console.Write("Rock , Paper, or Scissors?(R/P/S): ");
                string yourChoice = Console.ReadLine();
                string playerRoshamboValue = firstPlayer.generateRoshambo(yourChoice);
                Console.WriteLine($"{nameOfThePlayer} : {playerRoshamboValue}");
                string opponentName = "";
                string opponentRoshamboValue = "";
                if (choosePartner == "j")
                {
                    opponentName = secondPlayer.NamePlayer;
                    opponentRoshamboValue = secondPlayer.generateRoshambo("j");
                    Console.WriteLine($"{opponentName} : {opponentRoshamboValue}");
                }

                if (choosePartner == "s")
                {
                    opponentName = thirdPlayer.NamePlayer;
                    opponentRoshamboValue = thirdPlayer.generateRoshambo("s");
                    Console.WriteLine($"{opponentName} : {opponentRoshamboValue}");

                }
                Console.WriteLine($"{FinalResult(playerRoshamboValue, opponentRoshamboValue, nameOfThePlayer, opponentName )}");
                Console.Write("\nPlay again?(y/n)");
                doYouWantToPlay = Console.ReadLine();
            } while (doYouWantToPlay.ToLower().Trim() == "y");
            


        }
        public static string FinalResult(string UserResult, string OpponentResult , string UserName, string OpponentName)
        {
            if (UserResult == OpponentResult)
            {
                return "Draw!";
            }
            if (((UserResult == "PAPER") && (OpponentResult == "ROCK")) || ((UserResult == "ROCK") && (OpponentResult == "SCISSORS"))||((UserResult == "SCISSORS") && (OpponentResult == "PAPER")))
            {
                return UserName + " Wins!";
            }
            else
            {
                return OpponentName + " Wins!";
            }
           
        }
    }
}
