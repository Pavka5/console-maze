using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int mazeSize = 11;
            var maze = new string[mazeSize, mazeSize];

            for (int i = 0; i < mazeSize; i++)
            {
                for(int j = 0; j < mazeSize; j++) 
                {
                    maze[i, j] = "x";
                    Console.Write(string.Format("{0} ", maze[i, j]));
                }
<<<<<<< Updated upstream
                Console.Write(Environment.NewLine + Environment.NewLine);
=======
            }

            Console.WriteLine("Ola");

            for (int i = 0;i < maze.GetLength(0); i++)
            {
                for (int j = 0; j < maze.GetLength(1); j++)
                {
                    var item = maze[i, j];
                    Console.Write(item + " ");
                }
                Console.Write(Environment.NewLine);
>>>>>>> Stashed changes
            }
        }
    }
}
