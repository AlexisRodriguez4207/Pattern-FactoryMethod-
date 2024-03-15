using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Rodriguez Perez Carlos Alexis 20210627
namespace Patrón_Factory_Method_Desarrollo.ChicagoStylePizza
{
    public class ChicagoClamPizza : Pizza
    {
        public ChicagoClamPizza()
        {
            name = "Chicago Style Clam Pizza";
            dough = "Extra Thick Crust Dough";
            sauce = "Plum Tomato Sauce";
            toppings.Add("Shredded Mozzarella Cheese");
            toppings.Add("Clams");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}
