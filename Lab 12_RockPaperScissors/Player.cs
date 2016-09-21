using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12_RockPaperScissors
{
   abstract class Player
    {
        private string Name = "";
       // private string RoshamboValue = "";
        abstract public string generateRoshambo(string RoshamboValue);
        public enum Roshamba { ROCK, PAPER, SCISSORS};
        public string NamePlayer
        {
            get { return Name; }
           set { this.Name = value; }
        }

        public Player(string PlayerName)
        {
            NamePlayer = PlayerName;
        }

    }
}
