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
            world[0] = new char[] { ' ', ' ', ' ' };
            world[1] = new char[] { ' ', 'O', ' ' };
            world[2] = new char[] { ' ', ' ', ' ' };

           

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
            var strBuilder = new StringBuilder();
            strBuilder.Append(" 0 1 2\nA");
 
            string strWorld = strBuilder.ToString();

            Console.WriteLine(strWorld);
        }
    }
}
