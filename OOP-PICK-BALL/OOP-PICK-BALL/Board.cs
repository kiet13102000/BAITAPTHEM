﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_PICK_BALL
{
    class Board
    {
        private int G1, G2, G3;
        public Board(int g1, int g2, int g3)
        {
            G1 = g1;
            G2 = g2;
            G3 = g3;
        }
        public void PrintGame()
        {
            Console.Write("group {0} : ", 1);
            for (int i = 1; i <= G1; i++)
            {
                Console.Write('0');
            }
            Console.WriteLine();
            Console.Write("group{0} : ", 2);
            for (int i = 1; i <= G2; i++)
            {
                Console.Write('0');
            }
            Console.WriteLine();
            Console.Write("group {0} : ", 3);
            for (int i = 1; i <= G3; i++)
            {
                Console.Write('0');
            }
            Console.WriteLine();

        }

        public bool IsGameOVer()
        {
            if (G1 == 0 && G2 == 0 && G3 == 0)
            {
                return true;
            }
            return false;
        }
        public void PickBall ( int group , int balls)
        {
            if (group == 1)
            {
                G1 -= balls;
            }else if (group == 2)
            {
                G2 -= balls;
            }else if (group == 3)
            {
                G3 -= balls;
            }
            
        }
        public int Gve()
        {
            if (G1 == 0)
            {
                return G1;
            }
            else if(G2 ==0)
            {
                return G2;
            }else if (G3==0)
            {
                return G3;
            }
            else return 0;
        }
        public void check()
        {
            if(G1 == 0)
            {
                Console.WriteLine("Group1 da het bong, vui long nhap lai");
            }
            if (G2 == 0)
            {
                Console.WriteLine("Group2 da het bong, vui long nhap lai");

            }
            if(G3 ==0)
            {
                Console.WriteLine("Group3 da het bong, vui long nhap lai");

            }
        }
       
     
       
    }
}
