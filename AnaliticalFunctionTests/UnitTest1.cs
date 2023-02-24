using AnaliticalFunctionLib;

namespace AnaliticalFunctionTests {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void Calculate_min4_16returned() {
            int x = -4;
            int expected = 16;
            double actual = AnaliticalFunction.Calcualte(x);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Calculate_min3_9returned() {
            int x = -3;
            int expected = 9;
            double actual = AnaliticalFunction.Calcualte(x);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Calculate_min2_8returned() {
            int x = -2;
            int expected = 4;
            double actual = AnaliticalFunction.Calcualte(x);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Calculate_min1_1returned() {
            int x = -1;
            int expected = 1;
            double actual = AnaliticalFunction.Calcualte(x);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Calculate_0_0returned() {
            int x = 0;
            int expected = 0;
            double actual = AnaliticalFunction.Calcualte(x);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Calculate_1_1returned() {
            int x = 1;
            int expected = 1;
            double actual = AnaliticalFunction.Calcualte(x);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Calculate_2_8returned() {
            int x = 2;
            int expected = 8;
            double actual = AnaliticalFunction.Calcualte(x);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Calculate_3_9returned() {
            int x = 3;
            int expected = 9;
            double actual = AnaliticalFunction.Calcualte(x);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Calculate_4_12returned() {
            int x = 4;
            int expected = 12;

            AnaliticalFunction f = new AnaliticalFunction();
            double actual = AnaliticalFunction.Calcualte(x);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Calculate_5_15returned() {
            int x = 5;
            int expected = 15;

            AnaliticalFunction f = new AnaliticalFunction();
            double actual = AnaliticalFunction.Calcualte(x);

            Assert.AreEqual(expected, actual);
        }
    }
}