using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patrón_Factory_Method_Desarrollo.NYPizza;

//Rodriguez Perez Carlos Alexis 20210627
namespace Patrón_Factory_Method_Desarrollo.CaliforniaStylePizza
{
    public class CaliforniaClamPizza : Pizza
    {
        public CaliforniaClamPizza()
        {
            name = "California Style Clam Pizza";
            dough = "Thick Crust Dough";
            sauce = "Plum Tomato Sauce";
            toppings.Add("Grated Reggiano Cheese");
            toppings.Add("Fresh Clams");
        }
    }
}
