using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Rodriguez Perez Carlos Alexis 20210627
namespace Patrón_Factory_Method_Desarrollo.CaliforniaStylePizza
{
    public class CaliforniaPepperoniPizza : Pizza
    {
        public CaliforniaPepperoniPizza()
        {
            name = "California Style Pepperoni Pizza";
            dough = "Thick Crust Dough";
            sauce = "Plum Tomato Sauce";
            toppings.Add("Grated Reggiano Cheese");
            toppings.Add("Sliced Pepperoni");
            toppings.Add("Garlic");
            toppings.Add("Onion");
        }
    }
}
