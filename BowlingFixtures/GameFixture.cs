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
            // Console.WriteLine("Enter The Number Of Pins For This Roll:");
            int[] pins = { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };
            //int[] pins = { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
           // int[] pins = { 7,1,1,7,1,7,1,7,1,7,1,7,1,7,1,7,1,7,10,10,10 };
            

            Game obj = new Game();
            foreach (int p in pins)
                obj.Roll(p);
            Assert.AreEqual(obj.GetScore(), 300);
        }
        [TestMethod]
        public void TestMethod2()
        {
         //   int[] pins = { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };
            int[] pins = { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
            // int[] pins = { 7,1,1,7,1,7,1,7,1,7,1,7,1,7,1,7,1,7,10,10,10 };


            Game obj = new Game();
            foreach (int p in pins)
                obj.Roll(p);
            Assert.AreEqual(obj.GetScore(), 150);
        }
        [TestMethod]
        public void TestMethod3()
        {
            // Console.WriteLine("Enter The Number Of Pins For This Roll:");
            //int[] pins = { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 };
            //int[] pins = { 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5, 5 };
             int[] pins = { 7,1,1,7,1,7,1,7,1,7,1,7,1,7,1,7,1,7,10,10,10 };


            Game obj = new Game();
            foreach (int p in pins)
                obj.Roll(p);
            Assert.AreEqual(obj.GetScore(), 102);
        }
    }
}
