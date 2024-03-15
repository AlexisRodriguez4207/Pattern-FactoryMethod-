using Patrón_Factory_Method_Desarrollo.ChicagoStylePizza;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Rodriguez Perez Carlos Alexis 20210627
namespace Patrón_Factory_Method_Desarrollo.Stores
{
    public class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type) 
        {
            if (type.Equals("Cheese"))
            {
                return new ChicagoPepperoniPizza();
            }
            else if (type.Equals("Pepperoni"))
            {
                return new ChicagoPepperoniPizza();
            }
            else if (type.Equals("Clam"))
            {
                return new ChicagoClamPizza();
            }
            else if (type.Equals("Veggie"))
            {
                return new ChicagoVeggiePizza();
            }
            else
            {
                return null;
            } 
        }
    }
}
