using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12_RockPaperScissors
{
    class Player1 : Player
    {
        string firstplayerName = "";
        public Player1(string name):base(name)
        {
            this.firstplayerName = name;
        }

        public override string generateRoshambo(string RoshamboValue)
        {
            //Random rdm = new Random();
            //int r1 = rdm.Next(0, 2);
            //Console.WriteLine(r1);
            switch (RoshamboValue)
            {
                case "r":
                    return Roshamba.ROCK.ToString();
                    
                case "p":
                    return Roshamba.PAPER.ToString();
                   
                case "s":
                    return Roshamba.SCISSORS.ToString();
                   
                default:
                    return "Not in the List";
                    
            }
        }
    }
}
