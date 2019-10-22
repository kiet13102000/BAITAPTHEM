using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PICK_BALL
{
    class Player
    {
        private String name;
        public Player(String namer)
        {
            name = namer;
        }

        public void PickBall(Board game)
        {
            Console.WriteLine("What you want pickball group ? ");
            int group = int.Parse(Console.ReadLine());
            Console.WriteLine("How many you want pickballs : ");
            int balls = int.Parse(Console.ReadLine());
         
            game.PickBall(group, balls);
        }
        public string GetName()
        {
            return name;
        }
    }
}
