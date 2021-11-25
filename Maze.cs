using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows;
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
        public void BuildLeadingPoints(string [,] maze, string leadingPoint)
        {
            for (int i = 2; i < maze.GetLength(0) - 1; i++)
            {
                for (int j = 2; j < maze.GetLength(1) - 1; j++)
                {
                    if (i % 2 == 0 && j % 2 == 0)
                    maze [i, j] = leadingPoint;
                }
            }
        }
        public void BuildWalls(string [,] maze, string walls, string leadingPoint)
        {
            var leadingPoints = GetLeadingPoints(maze, leadingPoint);
            leadingPoints.Shuffle();

            foreach (var point in leadingPoints)
            {
                BuildWall(maze, walls, point);
            }
        }

        public void BuildWall(string [,] maze, string wall, Point start)
        {
            var rd = new Random();
            //ENUM DIRECTIONS - UP, DOWN, LEFT, RIGHT
            //METODU CO VRATI NAHODNE DIRECTION
            //IF A POSTAVITE STENY

            // return value -1 or 1... which is direction
            var directionX = 2 * rd.Next(0, 2) - 1;
            var directionY = 2 * rd.Next(0, 2) - 1;
        }

        private List<Point> GetLeadingPoints(string [,] maze, string leadingPoint)
        {
            var points = new List<Point>();

            for (int i = 2; i < maze.GetLength(0) - 1; i++)
            {
                for (int j = 2; j < maze.GetLength(1) - 1; j++)
                {
                    if (maze[i, j] == leadingPoint)
                    {
                        points.Add (new Point (i, j));
                    }
                }
            }
            return points;
        }
    }
}
