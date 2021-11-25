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
            var mazeGenerator = new Maze();
            var maze = mazeGenerator.GetEmptyMaze(11);
            mazeGenerator.FillMaze(maze, Constants.Maze.SymbolEmpty);
            mazeGenerator.OutputMaze(maze);
            mazeGenerator.BuildBorder(maze, Constants.Maze.SymbolWall);
            Console.WriteLine(Environment.NewLine);
            mazeGenerator.OutputMaze(maze);
        }
    }
}
