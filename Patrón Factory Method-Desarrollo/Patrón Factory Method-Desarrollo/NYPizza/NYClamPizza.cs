using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patrón_Factory_Method_Desarrollo.NYPizza;

//Rodriguez Perez Carlos Alexis 20210627
namespace Patrón_Factory_Method_Desarrollo.NYPizza
{
    public class CaliforniaClamPizza : Pizza
    {
        public CaliforniaClamPizza()
        {
            name = "NY Style Clam Pizza";
            dough = "Thin Crust Dough";
            sauce = "Marinara Sauce";
            toppings.Add("Grated Reggiano Cheese");
            toppings.Add("Fresh Clams");
        }
    }
}
