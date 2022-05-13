namespace CoffeeMaker
{
    public class StarBucks : InterfaceMakeACoffee
    {
        public bool CheckingIngredientsAvailability()
        {
            return true;
        }

        public string CoffeeMaking(int sugerPerSpoon, int coffeePack)
        {
            throw new NotImplementedException();
        }
    }
        public class StubStarBuks : InterfaceMakeACoffee
        {
            public bool CheckingIngredientsAvailability()
            {
                return true;
            }

            public string CoffeeMaking(int sugerPerSpoon, int coffeePack)
            {
                return "Your Coffee is Recieve";
            }
        }
        public class FakeStarBuks : InterfaceMakeACoffee
        {
            public bool CheckingIngredientsAvailability()
            {
                return true;
            }

            public string CoffeeMaking(int sugerPerSpoon, int coffeePack)
            {
                return "Your Coffee is Recieve";
            }
        }
    
}