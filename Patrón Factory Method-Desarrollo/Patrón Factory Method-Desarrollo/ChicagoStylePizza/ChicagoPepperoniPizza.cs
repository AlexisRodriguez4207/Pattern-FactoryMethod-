using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Rodriguez Perez Carlos Alexis 20210627
namespace Patrón_Factory_Method_Desarrollo.ChicagoStylePizza
{
    public class ChicagoPepperoniPizza : Pizza
    {
        public ChicagoPepperoniPizza()
        {
            name = "Chicago Style Pepperoni Pizza";
            dough = "Extra Thick Crust Dought";
            sauce = "Plum Tomato Sauce";
            toppings.Add("Shredded Mozzarella Cheese");
            toppings.Add("Pepperoni");
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices");
        }
    }
}
