/**
* Program class - class to read maze file and traverse maze
*
* <pre>
*
* Assignment: #2
* Course: ADEV-3001
* Date Created: October 25, 2017
* 
* Revision Log
* Who        When       Reason
* --------- ---------- ----------------------------------
*
* </pre>
*
* @author Matt Scott
* @version 1.0
*/

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
        const string STUDENT = "Matt Scott 0286401";

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

            DepthFirst depthFirst = new DepthFirst(maze);

            bool result = depthFirst.DepthFirstSearch(startingPoint[0], startingPoint[1]);

            if(!result)
            {
                Console.WriteLine(depthFirst.NoExit());
                Console.WriteLine(depthFirst.DumpMaze());
            }
            else
            {
                Console.WriteLine(depthFirst.ExitFound());
                Console.WriteLine(depthFirst.PathToFollow());
                Console.WriteLine(depthFirst.DumpMaze());
            }

            Console.ReadKey();
        }
    }
}
