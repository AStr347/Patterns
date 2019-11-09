using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstract_fabric
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                SimplePizzaStore sps = new NYSimplePizzaFactory();
                sps.PizzaOrder("Peperoni");
                sps.PizzaOrder("Clam");
                sps.PizzaOrder("Cheese");
            }

            {
                SimplePizzaStore sps = new ChicagoSimplePizzaFactory();
                sps.PizzaOrder("Peperoni");
                sps.PizzaOrder("Clam");
                sps.PizzaOrder("Cheese");
            }
            Console.ReadKey();

        }
    }
}
