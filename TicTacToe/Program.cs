using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //TicTacToe Example from the challenges
            char[][] world = initWorld();
            List<int[]> movesLeft = new List<int[]>();
            bool gameEnd = false;
            drawWorld(world);
            Console.WriteLine("Computer plays ... B1");

            while(!gameEnd)
            {
                string platerMove = Console.ReadLine();  
                
                //hack to break loop
                gameEnd = true;
            }                      
        }

        private static char[][] initWorld()
        {
            char[][] world = new char[3][];
            world[0] = new char[3];
            world[1] = new char[3];
            world[2] = new char[3];

            world[0][0] = ' ';
            world[0][1] = ' ';
            world[0][2] = ' ';
            world[1][0] = ' ';
            world[1][1] = 'O';
            world[1][2] = ' ';
            world[1][0] = ' ';
            world[1][1] = ' ';
            world[1][2] = ' ';

            return world;
        }

        private int[] computeAiMove(List<int[]> movesLeft)
        {
            int[] pos = new int[2];
            Random rnd = new Random();
            rnd.Next(1, movesLeft.Count);
            return pos;
        }

        private string computeWorld(int[] move, char icon, char[][] world)
        {
            return "";
        }

        private static void drawWorld(char[][] world)
        {
            string strWorld = " 0 1 2\n";
            strWorld += "A";
            //fill in code

            Console.WriteLine(strWorld);
        }
    }
}
