using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMaker
{
    public class StarBuksStore
    {
        private readonly InterfaceMakeACoffee service;
        public StarBuksStore(InterfaceMakeACoffee service)
        { 
        this.service = service;
        }
        public string OrderCoffee(int sugerPerSpoon, int countCoffee)
        {
            if (service.CheckingIngredientsAvailability())
            {
                return service.CoffeeMaking(sugerPerSpoon, countCoffee);
            }
            else 
            {
                return "Sorry! Coffee is not Available";
            }
        }
    }
}
