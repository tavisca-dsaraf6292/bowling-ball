using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Bowling.BowlingFixtures
{
    [TestClass]
    public class GameFixture
    {
        [TestMethod]
        public void TestMethod1()
        {
            int[] pins = { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };//All Strikes
            Game obj = new Game();
            foreach (int p in pins)
                obj.Roll(p);
            Assert.AreEqual(obj.GetScore(), 300);
        }
        [TestMethod]
        public void TestMethod2()
        {
         
            int[] pins = { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };//All Spares
            Game obj = new Game();
            foreach (int p in pins)
                obj.Roll(p);
            Assert.AreEqual(obj.GetScore(), 150);
        }
        [TestMethod]
        public void TestMethod3()
        {
            
             int[] pins = { 7,1,1,7,1,7,1,7,1,7,1,7,1,7,1,7,1,7,10,10,10 };//random
            Game obj = new Game();
            foreach (int p in pins)
                obj.Roll(p);
            Assert.AreEqual(obj.GetScore(), 102);
        }
        [TestMethod]
        public void TestMethod4()
        {
            int[] pins = { 0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0};//Gutter
            Game obj = new Game();
            foreach (int p in pins)
                obj.Roll(p);
            Assert.AreEqual(obj.GetScore(), 0);
        }
        [TestMethod]
        public void TestMethod5()
        {
            int[] pins = { 3, 5, 3, 5, 3, 5, 3, 5, 3, 5, 3, 5, 3, 5, 3, 5, 3, 5, 10, 3, 5};//random
            Game obj = new Game();
            foreach (int p in pins)
                obj.Roll(p);
            Assert.AreEqual(obj.GetScore(), 90);
        }
    }
}
