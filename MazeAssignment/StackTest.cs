/**
* StackTest – Methods to test the Stack class
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
    class StackTest
    {
        #region Test Fixture Setup and Tear Down

        /**
         * Default constructor for test class LinkedListTest
         */
        public StackTest() { }

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
         *  Method to test the no arg constructor of the stack class
         */
        [Test]
        public void TestStackNoArgConstructor()
        {
            Stack<Point> stack = new Stack<Point>();

            Assert.That(stack, Is.Not.Null);
            Assert.That(stack.GetSize(), Is.EqualTo(0));
        }

        /**
         *  Method to test that the push method properly sets head data
         */
        [Test]
        public void TestPush()
        {
            Stack<Point> stack = new Stack<Point>();
            Point point1 = new Point(1, 1);

            stack.Push(point1);
            Assert.That(stack.Top(), Is.EqualTo(point1));
            Assert.That(stack.GetSize(), Is.EqualTo(1));
        }

        /**
         *  Method to test that Top method throws an exception when stack size is 0
         */
        [Test]
        public void TestTop_Throws_Exception_When_Size_0()
        {
            Stack<Point> stack = new Stack<Point>();

            Assert.That(() => stack.Top(), Throws.Exception.TypeOf<IndexOutOfRangeException>());
        }

        /**
         *  Method to test Top method returns correct head data
         */
        [Test]
        public void TestTop_Correct_Return_Data()
        {
            Stack<Point> stack = new Stack<Point>();
            Point point1 = new Point(1, 1);
            stack.Push(point1);

            Assert.That(stack.Top(), Is.EqualTo(point1));
        }

        /**
         *  Method to test that Pop method throws an exception when stack size is 0
         */
        [Test]
        public void TestPop_Throws_Exception_When_Size_0()
        {
            Stack<Point> stack = new Stack<Point>();

            Assert.That(() => stack.Pop(), Throws.Exception.TypeOf<IndexOutOfRangeException>());
        }

        /**
         *  Method to test that Pop method returns the proper data
         */
        [Test]
        public void TestPop_Returns_The_Proper_Data()
        {
            Stack<Point> stack = new Stack<Point>();
            Point point1 = new Point(1, 1);
            Point point2 = new Point(2, 2);

            stack.Push(point1);
            stack.Push(point2);

            Assert.That(stack.Pop(), Is.EqualTo(point2));
        }

        /**
         *  Method to test that Pop method removes and Replaces the head
         */
        [Test]
        public void TestPop_Removes_And_Replaces_Head()
        {
            Stack<Point> stack = new Stack<Point>();
            Point point1 = new Point(1, 1);
            Point point2 = new Point(2, 2);

            stack.Push(point1);
            stack.Push(point2);

            stack.Pop();
            Assert.That(stack.Top(), Is.EqualTo(point1));
        }

        /**
         *  Method to test that GetSize returns the correct size
         */
        [Test]
        public void TestGetSize()
        {
            Stack<Point> stack = new Stack<Point>();
            Point point1 = new Point(1, 1);
            Point point2 = new Point(2, 2);

            stack.Push(point1);
            stack.Push(point2);

            Assert.That(stack.GetSize(), Is.EqualTo(2));
        }

        /**
         *  Method to test the IsEmpty returns true when size 0
         */
        [Test]
        public void TestIsEmpty_True()
        {
            Stack<Point> stack = new Stack<Point>();

            Assert.That(stack.IsEmpty(), Is.True);
        }

        /**
         *  Method to test the IsEmpty returns true when size 0
         */
        [Test]
        public void TestIsEmpty_False()
        {
            Stack<Point> stack = new Stack<Point>();
            Point point1 = new Point(1, 1);
            stack.Push(point1);

            Assert.That(stack.IsEmpty(), Is.False);
        }
    }
}
