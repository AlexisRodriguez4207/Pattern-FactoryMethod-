using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Rodriguez Perez Carlos Alexis 20210627
namespace Patrón_Factory_Method_Desarrollo.CaliforniaStylePizza
{
    public class CaliforniaCheesePizza : Pizza
    {
        public CaliforniaCheesePizza()
        {
            name = "California Style Cheese Pizza";
            dough = "Thick Crust Dought";
            sauce = "Plum Tomato Sauce";
            toppings.Add("Mozzarella Cheese");
        }
    }
}
