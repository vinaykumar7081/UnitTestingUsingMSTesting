using CoffeeMaker;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

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
        [TestMethod]
        public void OrderCoffeeMoq_InStarBucks_ShouldReturnRecieveMessage()
        {
            var moqService = new Mock<InterfaceMakeACoffee>();
            moqService.Setup(y => y.CheckingIngredientsAvailability()).Returns(true);
            moqService.Setup(y => y.CoffeeMaking(5, 10)).Returns("Your Coffee is Recieve");
            StarBuksStore result = new StarBuksStore(moqService.Object);
            string actual = result.OrderCoffee(5, 10);
                Assert.AreEqual(actual, "Your Coffee is Recieve");
        }
    }
}