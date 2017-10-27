/**
* NodeTest – Methods to test the node class
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
    using NUnit.Framework;

    [TestFixture]
    class NodeTest
    {  
        #region Test Fixture Setup and Tear Down

        /**
         * Default constructor for test class NodeTest
         */
        public NodeTest() { }

        /**
         * Sets up the test fixture.
         *
         * Called before every test case method.
         */
        [SetUp]
        public void SetUp() { }

        /**
         * Tears down the test fixture.
         *
         * Called after every test case method.
         */
        [TearDown]
        public void TearDown() { }

        #endregion

        /**
         *  Test the all arg constructor, make sure the data is there and other properties are set
         */
        [Test]
        public void TestAllArgContructor()
        {
            Point point1 = new Point(1, 1);
            Point point2 = new Point(1, 2);
            Node<Point> node1 = new Node<Point>(point1, null);
            Node<Point> node2 = new Node<Point>(point2, node1);

            Assert.That(node2, Is.Not.Null);
            Assert.That(node2.GetElement(), Is.EqualTo(point2));
            Assert.That(node2.GetPrevious(), Is.EqualTo(node1));
        }

        /**
         *  Test the GetElement method to determine if the proper data is returned
         */
        [Test]
        public void TestGetElement()
        {
            Point point1 = new Point(1, 1);
            Node<Point> node1 = new Node<Point>(point1, null);

            Assert.That(node1.GetElement(), Is.EqualTo(point1));
        }

        /**
         *  Test the GetPrevious method to determine if the proper data is returned
         */
        [Test]
        public void TestGetPrevious()
        {
            Point point1 = new Point(1, 1);
            Point point2 = new Point(1, 2);
            Node<Point> node1 = new Node<Point>(point1, null);
            Node<Point> node2 = new Node<Point>(point2, node1);
            
            Assert.That(node2.GetPrevious(), Is.EqualTo(node1));
        }
    }
}
