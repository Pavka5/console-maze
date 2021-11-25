using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MazeGenerator
{
    internal class Maze
    {
        public string[,] GetEmptyMaze(int width, int height = 0)
        {
            height = height == 0 ? width : height;
            return new string[height, width];
        }
        public void FillMaze(string[,] maze, string symbol = ".")
        {
            for (int i = 0; i < maze.GetLength(0); i++)
            {
                for (int j = 0; j < maze.GetLength(1); j++)
                {
                    maze[i, j] = symbol;    
                }
            }
        }
        public void OutputMaze(string [,] maze)
        {
            for (int i = 0; i < maze.GetLength(0); i++)
            {
                for (int j = 0; j < maze.GetLength(1); j++)
                {
                    var item = maze[i, j];
                    Console.Write(item + " ");
                }
                Console.Write(Environment.NewLine);
            }
        }
        public void BuildBorder(string [,] maze, string wall)
        {
            for (int i = 0; i < maze.GetLength(0); i++)
            {
                for (int j = 0; j < maze.GetLength(1); j++)
                {
                    //check if can build TOP wall
                    if (i == 0)
                        maze[i, j] = wall;
                    //check if can build BOTTOM wall
                    if (i == maze.GetLength(0) - 1)
                        maze[i, j] = wall;
                    //check if can build LEFT wall
                    if (j == 0)
                        maze[i, j] = wall;
                    //check if can build RIGHT wall
                    if (j == maze.GetLength(1) - 1)
                        maze[i, j] = wall;
                }
                Console.Write(Environment.NewLine);
            }
        }
    }
}
