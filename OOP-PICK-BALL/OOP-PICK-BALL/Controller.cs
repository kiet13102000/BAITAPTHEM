using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PICK_BALL
{
    class Controller
    {
        private Board Game;
        private Player P1, P2;

        public Controller()
        {
            P1 = new Player("Kiet");
            P2 = new Player("Nhan");
            Game = new Board(4, 5, 6);
        }
        public void playGame()
        {
            Game.PrintGame();
            while(true)
            {
                Console.WriteLine(P1.GetName() + "Play");
                P1.PickBall(Game);
                if( Game.IsGameOVer())
                {
                    Console.WriteLine(P1.GetName() + "lose");
                    Console.WriteLine(P2.GetName() + " win");
                    break;
                }
                Game.PrintGame();
                Console.WriteLine(P2.GetName() + " play");
                P2.PickBall(Game);
                if (Game.IsGameOVer())
                {
                    Console.WriteLine(P2.GetName() + "lose");
                    Console.WriteLine(P1.GetName() + " win");
                    break;
                }
                Game.PrintGame();
            }
        }

        
    }
}
