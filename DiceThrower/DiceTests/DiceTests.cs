using DiceThrower.Implementations;
using DiceThrower.Interfaces;

namespace DiceTests
{
    [TestClass]
    public class DiceTests
    {
        [TestMethod]
        public void TestMaxD20()
        {
            IDice die = new D20();

            int maxNumber = 0;

            for (var i = 0; i < 1000; i++)
            {
                // Will be executed 1000 times
                var result = die.Throw();

                if (result > maxNumber)
                {
                    maxNumber = result;
                }
            }

            Assert.AreEqual(20, maxNumber);
        }
        [TestMethod]
        public void TestMinD20()
        {
            IDice die = new D20();

            int minNumber = int.MaxValue;

            for (var i = 0; i < 1000; i++)
            {
                var result = die.Throw();

                if (result < minNumber)
                {
                    minNumber = result;
                }
            }

            Assert.AreEqual(1, minNumber);
        }

        [TestMethod]
        public void TestMiddleD20()
        {
            IDice die = new D20();

            double expectedAverage = (1 + 20) / 2.0;

            double actualAverage = 0;

            for (var i = 0; i < 1000; i++)
            {
                var result = die.Throw();

                actualAverage += result;
            }

            actualAverage /= 1000;
            Assert.AreEqual(expectedAverage, actualAverage, 0.5);
        }
        [TestMethod]
        public void TestMinLoadedD20()
        {
            IDice die = new LoadedD20();

            int minNumber = int.MaxValue;

            for (var i = 0; i < 1000; i++)
            {
                var result = die.Throw();

                if (result < minNumber)
                {
                    minNumber = result;
                }
            }

            Assert.AreEqual(1, minNumber);
        }
        [TestMethod]
        public void TestMaxLoadedD20()
        {
            IDice die = new LoadedD20();

            int maxNumber = 0;

            for (var i = 0; i < 1000; i++)
            {
                var result = die.Throw();

                if (result > maxNumber)
                {
                    maxNumber = result;
                }
            }

            Assert.AreEqual(20, maxNumber);
        }
        [TestMethod]
        public void TestMiddleLoadedD20()
        {
            IDice die = new LoadedD20();

            double average = (1 + 20) / 2.0;

            double actualAverage = 0;

            for (var i = 0; i < 1000; i++)
            {
                var result = die.Throw();

                actualAverage += result;
            }

            actualAverage /= 1000;
            Assert.IsTrue(actualAverage > average);
        }
    }
}