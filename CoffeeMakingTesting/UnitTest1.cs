using CoffeeMaker;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CoffeeMakingTesting
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void OrderCoffeeFake_InStarBucks_ShouldReturnRecieveMessage()
        {
            StarBuksStore store = new StarBuksStore(new FakeStarBuks());
            string actual = store.OrderCoffee(5, 10);
            Assert.AreEqual(actual, "Your Coffee is Recieve");
        }
    }
}