using Microsoft.VisualStudio.TestTools.UnitTesting;
using PromotionEngine;

namespace PromotionEngineTDD
{
    [TestClass]
    public class UnitTest1
    {
        // Test First Offer 
        [TestMethod]
        public void TestFirstOffer()
        {
            string Result = Scenario.ScenarioA(5, 3, 130, 50).ToString();
            Assert.AreEqual("230", Result);
        }

        // Test Second Offer 
        [TestMethod]
        public void TestSecondOffer()
        {
            string Result = Scenario.ScenarioA(5, 2, 45, 30).ToString();
            Assert.AreEqual("230", Result);
        }
    }
}
