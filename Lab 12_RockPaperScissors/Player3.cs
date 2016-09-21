using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12_RockPaperScissors
{
    class Player3 : Player
    {
        string firstplayerName = "";
        public Player3(string name) : base(name)
        {
            this.firstplayerName = name;
        }

        public override string generateRoshambo(string RoshamboValue)
        {
            Random rdm = new Random();
            int r1 = rdm.Next(0, 2);
            //Console.WriteLine(r1);
            switch (r1)
            {
                case 0:
                    return Roshamba.ROCK.ToString();

                case 1:
                    return Roshamba.PAPER.ToString();

                case 2:
                    return Roshamba.SCISSORS.ToString();

                default:
                    return "Not in the List";

            }
        }
    }
}
