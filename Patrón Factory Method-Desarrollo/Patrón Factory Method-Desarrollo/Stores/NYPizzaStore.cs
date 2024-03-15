using Patrón_Factory_Method_Desarrollo.NYPizza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Rodriguez Perez Carlos Alexis 20210627
namespace Patrón_Factory_Method_Desarrollo.Stores
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            if (type.Equals("Cheese"))
            {
                return new NYCheesePizza();
            }
            else if (type.Equals("Pepperoni"))
            {
                return new NYPepperoniPizza();
            }
            else if (type.Equals("Clam"))
            {
                return new NYPepperoniPizza();
            }
            else if (type.Equals("Veggie"))
            {
                return new NYVeggiePizza();
            }
            else
            {
                return null;
            }
        }
    }
}
