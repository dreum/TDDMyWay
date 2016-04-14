using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimulateGameOfLife;

namespace UnitTestSimulateGameOfLife
{
    [TestClass]
    public class SimulateTest
    {
        public SimulateWorld _simulateWorld = new SimulateWorld();
        [TestMethod]
        public void SimulateReturnsDefaultWorld()
        {
            List<Cell> outputWorld = new List<Cell>(){ Cell.Dead, Cell.Alive, Cell.Dead, Cell.Alive, Cell.Dead, Cell.Alive, Cell.Dead, Cell.Alive, Cell.Dead };
            CollectionAssert.AreEqual(outputWorld, _simulateWorld.Simulate());
        }
    }
}
