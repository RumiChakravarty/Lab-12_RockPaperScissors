using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12_RockPaperScissors
{
    class Player2 : Player
    {
        string firstplayerName = "";
        public Player2(string name) : base(name)
        {
            this.firstplayerName = name;
        }
        public override string generateRoshambo(string RoshamboValue)
        {
            return Roshamba.ROCK.ToString();

        }
    }
}

