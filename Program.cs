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
                }
            }
        }
    }
}
