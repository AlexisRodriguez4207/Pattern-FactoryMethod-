using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrón_Factory_Method_Desarrollo.NYPizza
{
    //Rodriguez Perez Carlos Alexis 20210627
    public class NYPepperoniPizza : Pizza
    {
        public NYPepperoniPizza()
        {
            name = "NY Style Pepperoni Pizza";
            dough = "Thin Crust Dough";
            sauce = "Marinara Sauce";
            toppings.Add("Grated Reggiano Cheese");
            toppings.Add("Sliced Pepperoni");
            toppings.Add("Garlic");
            toppings.Add("Onion");
        }
    }
}
