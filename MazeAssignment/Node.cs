/**
* Node – Node constructor plus getters and setters
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
    class Node<T> where T : IComparable<T>
    {
        const string STUDENT = "Matt Scott 0286401";

        private T element;
        private Node<T> previous;
        
        /// <summary>
        /// An all arg constructor for a node
        /// </summary>
        /// <param name="data">The data to be stored in the node</param>
        /// <param name="previous">The node that was created before this one</param>
        public Node(T element, Node<T> previous)
        {
            this.element = element;
            this.previous = previous;
        }

        /// <summary>
        /// Returns the data stored in the node
        /// </summary>
        /// <returns>The data from the node</returns>
        public T GetData()
        {
            return element;
        }
        
        /// <summary>
        /// Returns the previous node propertry
        /// </summary>
        /// <returns>The previous node</returns>
        public Node<T> GetPrevious()
        {
            return previous;
        }        
    }
}
