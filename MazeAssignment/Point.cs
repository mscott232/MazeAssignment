/**
* Point – Point constructor plus getters and override tostring method
*
* <pre>
*
* Assignment: #2
* Course: ADEV-3001
* Date Created: October 9, 2017
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
    class Point : IComparable<Point>
    {
        const string STUDENT = "Matt Scott 0286401";

        private int row;
        private int column;

        /// <summary>
        /// All arg Point constructor
        /// </summary>
        /// <param name="row">An int value of the row</param>
        /// <param name="column">An int value of the column</param>
        public Point(int row, int column)
        {
            this.row = row;
            this.column = column;
        }

        /// <summary>
        /// Returns the row of the point
        /// </summary>
        /// <returns>The int value of the row</returns>
        public int GetRow()
        {
            return row;
        }

        /// <summary>
        /// Returns the column of the point
        /// </summary>
        /// <returns>The int value of the column</returns>
        public int GetColumn()
        {
            return column;
        }

        /// <summary>
        /// Overrides the ToString method for a point
        /// </summary>
        /// <returns>The row and column string</returns>
        public override string ToString()
        {
            return string.Format("[{0},{1}]", row, column);
        }

        public int CompareTo(Point other)
        {
            throw new NotImplementedException();
        }
    }
}
