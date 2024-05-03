using MathMethodLib;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MathMathodLib.Tests
{
    [TestClass]
    public class MathMathodTests
    {
        // 1 тест -----------------------------
        [TestMethod]
        public void Sum_5_20_25returned()
        {
            int x = 5;
            int y = 20;
            int expected = 25;

            MathMethod z = new MathMethod();
            int actual = z.Sum(x, y);

            Assert.AreEqual(expected, actual);
        }
        // 2 тест -----------------------------
        [TestMethod]
        public void Sum_10_40_50returned()
        {
            int x = 10;
            int y = 40;
            int expected = 50;

            MathMethod z = new MathMethod();
            int actual = z.Sum(x, y);

            Assert.AreEqual(expected, actual);
        }
        // 3 тест -----------------------------
        [TestMethod]
        public void Sum_15_15_30returned()
        {
            int x = 15;
            int y = 15;
            int expected = 30;

            MathMethod z = new MathMethod();
            int actual = z.Sum(x, y);

            Assert.AreEqual(expected, actual);
        }
        // 4 тест -----------------------------
        [TestMethod]
        public void Sum_1_17_18returned()
        {
            int x = 1;
            int y = 17;
            int expected = 18;

            MathMethod z = new MathMethod();
            int actual = z.Sum(x, y);

            Assert.AreEqual(expected, actual);
        }
        // 5 тест -----------------------------
        [TestMethod]
        public void Sum_17_15_2returned()
        {
            int x = 17;
            int y = -15;
            int expected = 2;

            MathMethod z = new MathMethod();
            int actual = z.Sum(x, y);

            Assert.AreEqual(expected, actual);
        }
        // 6 тест -----------------------------
        [TestMethod]
        public void Sum_110_15_125returned()
        {
            int x = 110;
            int y = 15;
            int expected = 125;

            MathMethod z = new MathMethod();
            int actual = z.Sum(x, y);

            Assert.AreEqual(expected, actual);
        }
        // 7 тест -----------------------------
        [TestMethod]
        public void Sum_100_15_85returned()
        {
            int x = 100;
            int y = -15;
            int expected = 85;

            MathMethod z = new MathMethod();
            int actual = z.Sum(x, y);

            Assert.AreEqual(expected, actual);
        }
        // 8 тест -----------------------------
        [TestMethod]
        public void Sum_12345_12345_24690returned()
        {
            int x = 12345;
            int y = 12345;
            int expected = 24690;

            MathMethod z = new MathMethod();
            int actual = z.Sum(x, y);

            Assert.AreEqual(expected, actual);
        }
        // 9 тест -----------------------------
        [TestMethod]
        public void Sum_15_15_0returned()
        {
            int x = 15;
            int y = -15;
            int expected = 0;

            MathMethod z = new MathMethod();
            int actual = z.Sum(x, y);

            Assert.AreEqual(expected, actual);
        }
        // 10 тест -----------------------------
        [TestMethod]
        public void Sum_10_15_5returned()
        {
            int x = -10;
            int y = 15;
            int expected = 5;

            MathMethod z = new MathMethod();
            int actual = z.Sum(x, y);

            Assert.AreEqual(expected, actual);
        }

    }
}
