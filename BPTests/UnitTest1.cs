using Microsoft.VisualStudio.TestTools.UnitTesting;

using BPCalculator;

namespace BPTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            BloodPressure bp = new BloodPressure() { Systolic = 80, Diastolic = 50 };
            Assert.AreEqual(bp.Category, BPCategory.Low);
        }

        [TestMethod]
        public void TestMethod2()
        {
            BloodPressure bp = new BloodPressure() { Systolic = 110, Diastolic = 70 };
            Assert.AreEqual(bp.Category, BPCategory.Ideal);
        }

        [TestMethod]
        public void TestMethod3()
        {
            BloodPressure bp = new BloodPressure() { Systolic = 125, Diastolic = 82 };
            Assert.AreEqual(bp.Category, BPCategory.PreHigh);
        }

        [TestMethod]
        public void TestMethod4()
        {
            BloodPressure bp = new BloodPressure() { Systolic = 180, Diastolic = 91 };
            Assert.AreEqual(bp.Category, BPCategory.High);
        }
    }
}
