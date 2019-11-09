using System;
namespace fabric
{
    abstract class SimplePizzaStore
    {
        protected string place;
        public abstract Pizza CreatePizza(string type);

        public Pizza PizzaOrder(string type){
            Pizza p;
            p = CreatePizza(type);
            p.Prepare(place);
            p.Bake();
            p.Cut(8);
            p.Box();
            return p;
        }
    }

    class NYSimplePizzaFactory : SimplePizzaStore
    {
        public NYSimplePizzaFactory() {
            place = "New York";
        }
        override public Pizza CreatePizza(string type) {
            Pizza p = null;
            switch (type)
            {
                case "Peperoni":
                    p = new Peperoni("thin", "Marinara");
                    break;
                case "Cheese":
                    p = new Cheese("thin", "Marinara");
                    break;
            }
            return p;
        }
    }

    class ChicagoSimplePizzaFactory : SimplePizzaStore
    {
        public ChicagoSimplePizzaFactory() {
            place = "Chicago";
        }
        override public Pizza CreatePizza(string type) {
            Pizza p = null;
            switch (type)
            {
                case "Peperoni":
                    p = new Peperoni("thick", "Plum tomato");
                    break;
                case "Cheese":
                    p = new Cheese("thick", "Plum tomato");
                    break;
            }
            return p;
        }
    }
}
