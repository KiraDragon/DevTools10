using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading;
using System.IO;


namespace SnakeTest
{
    public struct Position
    {
        public int row;
        public int col;
        public Position(int row, int col)
        {
            this.row = row;
            this.col = col;
        }
    }

    public class Tester
    {
        public string SaveScore(string username, int score)
        {
            StreamWriter sw = new StreamWriter("../../scoreboard.txt", true);
            string entry;
            entry = "{0}: {1} points";
            entry = string.Format(entry, username, score.ToString());
            sw.WriteLine(entry);
            sw.Close();
            //modified to return entry
            return entry; 
        }

        public List<Position> MakeObstacles(Random rng)
        {
            List<Position> obstacles = new List<Position>();
            for (int i = 0; i < 5; i++)
            {
                obstacles.Add(new Position(rng.Next(6, Console.WindowHeight - 6),
                            rng.Next(6, Console.WindowWidth - 6)));
            };
            foreach (Position obstacle in obstacles)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.SetCursorPosition(obstacle.col, obstacle.row);
                Console.Write("▒");
            }

            return obstacles;
        }

        public List<Position> MakeNewObstacles(Random rng, List<Position> obstacles, Position food, Queue<Position> snakeElements)
        {

            //modified to ensure no infinite loops
            Position obstacle = new Position();
          
            obstacle = new Position(rng.Next(6, Console.WindowHeight - 6),
            rng.Next(6, Console.WindowWidth - 6));
            


            obstacles.Add(obstacle);
            
            Console.SetCursorPosition(obstacle.col, obstacle.row);
            
            Console.ForegroundColor = ConsoleColor.Cyan;
  
            Console.Write("▒");

            //modified to return obstacles
            return obstacles; 
        }
    }
}
