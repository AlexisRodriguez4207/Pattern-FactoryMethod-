using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrón_Factory_Method_Desarrollo
{
    //Rodriguez Perez Carlos Alexis 20210627
    public abstract class Pizza
    {
        public string name;
        public string dough;
        public string sauce;
        internal ArrayList toppings = new ArrayList();

        public virtual void Prepare()
        {
            Console.WriteLine("Preparing: " + name);
            Console.WriteLine("Tossing dough: " + dough);
            Console.WriteLine("Adding sauce: " + sauce);
            Console.WriteLine("Adding toppings: ");
            foreach (String topping in toppings)
            {
                Console.WriteLine("\t" + topping);
            }
        }

        public virtual void Bake()
        {
            Console.WriteLine("Baking for 25 minutes at 350°.");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }

        public virtual void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
        }

        public virtual string getName()
        {
            return name;
        }
    }
}
