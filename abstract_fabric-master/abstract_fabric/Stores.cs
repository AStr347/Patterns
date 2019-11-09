using System;
namespace abstract_fabric
{
    abstract class SimplePizzaStore
    {
        protected string place;
        protected IIngredientFactory idf;
        public abstract Pizza CreatePizza(string type);

        public Pizza PizzaOrder(string type){
            Pizza p;
            p = CreatePizza(type);
            p.Prepare(place);
            p.Bake();
            p.Cut(8);
            p.Box();
            Console.WriteLine();
            return p;
        }
    }

    class NYSimplePizzaFactory : SimplePizzaStore
    {
        public NYSimplePizzaFactory() {
            place = "New York";
            idf = new NYIngredientFactory();
        }
        override public Pizza CreatePizza(string type) {
            Pizza p = null;
            switch (type)
            {
                case "Peperoni":
                    p = new PeperoniPizza(idf);
                    break;
                case "Cheese":
                    p = new CheesePizza(idf);
                    break;
                case "Clam":
                    p = new ClamPizza(idf);
                    break;
            }
            return p;
        }
    }

    class ChicagoSimplePizzaFactory : SimplePizzaStore
    {
        public ChicagoSimplePizzaFactory() {
            place = "Chicago";
            idf = new ChicagoIngredientFactory();
        }
        override public Pizza CreatePizza(string type) {
            Pizza p = null;
            switch (type)
            {
                case "Peperoni":
                    p = new PeperoniPizza(idf);
                    break;
                case "Cheese":
                    p = new CheesePizza(idf);
                    break;
                case "Clam":
                    p = new ClamPizza(idf);
                    break;
            }
            return p;
        }
    }
}
