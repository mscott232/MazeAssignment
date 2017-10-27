/**
* DepthFirst class - class to find exit of maze
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

namespace MazeAssignment
{
    class DepthFirst
    {
        const string STUDENT = "Matt Scott 0286401";

        private char[,] maze;
        private Stack<Point> stack;
        private Point p;
        private bool result = false;
        private Point startingPoint;
        private Stack<Point> exitStack;
        private bool depthFirstSearchFinished = false;

        /// <summary>
        /// Contructor for the DepthFirst class
        /// </summary>
        /// <param name="maze">2D Char array of a maze</param>
        public DepthFirst(char[,] maze)
        {
            this.maze = maze;
            stack = new Stack<Point>();
        }

        /// <summary>
        /// Used to find an exit out of the maze
        /// </summary>
        /// <returns>True when exit is found, false when no exit</returns>
        public bool DepthFirstSearch(int row, int column)
        {                     
            char visitedMarker = 'V';

            // Create a starting point Point to use in ExitFound()
            if (stack.IsEmpty())
            {
                startingPoint = new Point(row, column);
            }

            // Determine if the current position is the exit
            if (maze[row, column] == 'E')
            {
                p = new Point(row, column);
                stack.Push(p);
                result = true;
                depthFirstSearchFinished = true;
            }
            else
            {
                // Determine if the current position has not been visied and mark it as visited if it hasn't
                if(maze[row, column] != visitedMarker)
                {
                    p = new Point(row, column);
                    stack.Push(p);
                    maze[row, column] = visitedMarker;
                }

                // Determine if the rows and columns adjacent to the current position is a wall or end marker
                if (maze[row + 1, column] == 'E' || maze[row + 1, column] == ' ')
                {
                    DepthFirstSearch(row + 1, column);
                }
                else if (maze[row, column + 1] == 'E' || maze[row, column + 1] == ' ')
                {
                    DepthFirstSearch(row, column + 1);
                }
                else if (maze[row, column - 1] == 'E' || maze[row, column - 1] == ' ')
                {
                    DepthFirstSearch(row, column - 1);
                }
                else if (maze[row - 1, column] == 'E' || maze[row - 1, column] == ' ')
                {
                    DepthFirstSearch(row - 1, column);
                }
                else
                {
                    stack.Pop();

                    // Determine if stack is empty if it is the result is false
                    if (stack.IsEmpty())
                    {                        
                        result = false;
                        depthFirstSearchFinished = true;
                    }
                    else
                    {
                        Point backOne = stack.Top();
                        DepthFirstSearch(backOne.GetRow(), backOne.GetColumn());
                    }
                }                
            }

            return result;
        }

        /// <summary>
        /// Returns a string stating there is no exit from the maze
        /// </summary>
        /// <returns>String stating there is no exit</returns>
        public string NoExit()
        {
            if(!depthFirstSearchFinished)
            {
                throw new InvalidOperationException("Depth First Search did not finish");
            }

            return "There is no exit out of the maze.";
        }

        /// <summary>
        /// Returns a string showing the start exit and number of steps to the exit
        /// </summary>
        /// <returns>String stating an exit was found</returns>
        public string ExitFound()
        {
            if (!depthFirstSearchFinished)
            {
                throw new InvalidOperationException("Depth First Search did not finish");
            }

            return String.Format("Path to follow from Start {0} to Exit {1} - {2} steps:", startingPoint, p.ToString(), stack.GetSize());
        }
        
        /// <summary>
        /// Returns the stack
        /// </summary>
        /// <returns>The stack</returns>
        public Stack<Point> PathToFollow()
        {
            if (!depthFirstSearchFinished)
            {
                throw new InvalidOperationException("Depth First Search did not finish");
            }

            exitStack = new Stack<Point>();

            while(!stack.IsEmpty())
            {
                Point point = stack.Pop();
                exitStack.Push(point);

                if (point != p)
                {
                    maze[point.GetRow(), point.GetColumn()] = '.';
                }
            }

            return exitStack;
        }

        /// <summary>
        /// Returns a string of the maze with visited marks and the steps shown to the exit if it was found 
        /// </summary>
        /// <returns>String of the maze</returns>
        public string DumpMaze()
        {
            if (!depthFirstSearchFinished)
            {
                throw new InvalidOperationException("Depth First Search did not finish");
            }

            StringBuilder stringBuilder = new StringBuilder();

            for(int i = 0; i < maze.GetLength(0); i++)
            {
                stringBuilder.Append("\n");

                for (int j = 0; j < maze.GetLength(1); j++)
                {
                    stringBuilder.Append(maze[i, j]);
                }                
            }

            return stringBuilder.ToString();
        }
    }
}
