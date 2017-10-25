using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MazeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] lines = File.ReadAllLines(@"C:\Users\Matt\Documents\School\Term 5\Programming 4\Assignments\Assignment 2\2 Final Milestone\maze.maze");

            int[] dimensions = lines[0].Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
            int[] startingPoint = lines[1].Split(' ').Select(n => Convert.ToInt32(n)).ToArray();

            char[,] maze = new char[dimensions[0], dimensions[1]];

            for(int i = 2; i < lines.Length; i++)
            {
                char[] items = lines[i].ToCharArray();

                for(int j = 0; j < items.Length; j++)
                {
                    maze[i - 2, j] = items[j];
                }
            }
        }
    }
}
