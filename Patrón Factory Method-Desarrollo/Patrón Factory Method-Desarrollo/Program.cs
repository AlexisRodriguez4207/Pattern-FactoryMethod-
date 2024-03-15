using Patrón_Factory_Method_Desarrollo.Stores;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patrón_Factory_Method_Desarrollo
{
    public class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();
            PizzaStore californiaStore = new CaliforniaPizzaStore();

            Console.WriteLine("-------- Pizza Pizza --------");
            Console.WriteLine("1. New York Pizza Store ");
            Console.WriteLine("2. Chicago Pizza Store ");
            Console.WriteLine("3. California Pizza Store ");
            Console.WriteLine("4. Salir ");
            Console.Write("Seleccione una opción: ");
            int opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                /* New York Pizza Store */
                case 1:
                    Console.Clear();
                    Console.WriteLine("---- New York Pizza Store ---- ");
                    Console.WriteLine("------------ Menú ------------ ");
                    Console.WriteLine("1. Cheese");
                    Console.WriteLine("2. Pepperoni");
                    Console.WriteLine("3. Clam");
                    Console.WriteLine("4. Veggie");
                    Console.Write("Seleccione una opción: ");
                    int opcion2 = Convert.ToInt32(Console.ReadLine());
                    switch (opcion2)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("---- Cheese Pizza ---- ");
                            Pizza pizza = nyStore.OrderPizza("Cheese");
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("---- Pepperoni Pizza ---- ");
                            pizza = nyStore.OrderPizza("Pepperoni");
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("---- Clam Pizza ---- ");
                            pizza = nyStore.OrderPizza("Clam");
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("---- Veggie Pizza ---- ");
                            pizza = nyStore.OrderPizza("Veggie");
                            break;
                        default:
                            Console.WriteLine("Opción no válida");
                            break;
                    }
                    break;
                /* Chicago Pizza Store */
                case 2:
                    Console.Clear();
                    Console.WriteLine("---- Chicago Pizza Store ---- ");
                    Console.WriteLine("------------ Menú ------------ ");
                    Console.WriteLine("1. Cheese");
                    Console.WriteLine("2. Pepperoni");
                    Console.WriteLine("3. Clam");
                    Console.WriteLine("4. Veggie");
                    Console.Write("Seleccione una opción: ");
                    opcion2 = Convert.ToInt32(Console.ReadLine());
                    switch (opcion2)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("---- Cheese Pizza ---- ");
                            Pizza pizza = chicagoStore.OrderPizza("Cheese");
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("---- Pepperoni Pizza ---- ");
                            pizza = chicagoStore.OrderPizza("Pepperoni");
                            break;
                        case 3:
                            Console.Clear();
                            Console.WriteLine("---- Clam Pizza ---- ");
                            pizza = chicagoStore.OrderPizza("Clam");
                            break;
                        case 4:
                            Console.Clear();
                            Console.WriteLine("---- Veggie Pizza ---- ");
                            pizza = chicagoStore.OrderPizza("Veggie");
                            break;
                        default:
                            Console.WriteLine("Opción no válida");
                            break;
                    }
                    break;

                /* California Pizza Store */
                case 3:
                Console.Clear();
                Console.WriteLine("---- California Pizza Store ---- ");
                Console.WriteLine("------------ Menú ------------ ");
                Console.WriteLine("1. Cheese");
                Console.WriteLine("2. Pepperoni");
                Console.WriteLine("3. Clam");
                Console.WriteLine("4. Veggie");
                Console.Write("Seleccione una opción: ");
                opcion2 = Convert.ToInt32(Console.ReadLine());
                switch (opcion2)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("---- Cheese Pizza ---- ");
                        Pizza pizza = californiaStore.OrderPizza("Cheese");
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("---- Pepperoni Pizza ---- ");
                        pizza = californiaStore.OrderPizza("Pepperoni");
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("---- Clam Pizza ---- ");
                        pizza = californiaStore.OrderPizza("Clam");
                        break;
                    case 4:
                        Console.Clear();
                        Console.WriteLine("---- Veggie Pizza ---- ");
                        pizza = californiaStore.OrderPizza("Veggie");
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
                break;  

                case 4:
                    Console.WriteLine("Gracias por su visita...");
                    break;

                default:
                    Console.WriteLine("Opción no válida");
                    break;
            }
        }
    }
}
