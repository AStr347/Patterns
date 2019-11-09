using System;


namespace fabric
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                SimplePizzaStore Chicago = new ChicagoSimplePizzaFactory();
                Pizza z = Chicago.PizzaOrder("Peperoni");
            }

            Console.WriteLine();

            {
                SimplePizzaStore NY = new NYSimplePizzaFactory();
                Pizza z = NY.PizzaOrder("Peperoni");
            }

            Console.ReadKey();
        }
    }
}
