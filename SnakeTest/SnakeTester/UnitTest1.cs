using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Threading;
using System.IO;
using SnakeTest; 

namespace SnakeTester
{ 
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test1()
        {
            Random rng = new Random(); 
            Tester test = new Tester();
            Position food = new Position();
            Queue<Position> snakeElements = new Queue<Position>();
            for (int i = 0; i <= 3; i++)
            {
                snakeElements.Enqueue(new Position(0, i));
            }
            List<Position> testObs = test.MakeObstacles(rng);
            List<Position> testObs2 = test.MakeNewObstacles(rng, testObs, food, snakeElements);
            Assert.AreEqual(6, testObs2.Count);
        }

        [TestMethod]
        public void testSaveScore()
        {
            Tester test = new Tester();
            string t1 = test.SaveScore("User1", 150);
            Assert.AreEqual("User1: 150 points", t1);
        }

        [TestMethod]
        public void testMakeObstacles()
        {
            Tester test = new Tester();
            Random rng = new Random();

            List<Position> testObs = test.MakeObstacles(rng);
            Assert.AreEqual(5, testObs.Count);

        }
    }
}
