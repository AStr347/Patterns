using System;
using System.Collections.Generic;

namespace abstract_fabric
{
    abstract class IIngredient { public string name;}

    class Peperoni : IIngredient {
        public Peperoni() {
            name = "Peperoni";
        }
    }


    interface IIngredientFactory
    {
        Dough CreateDough();
        Sause CreateSause();
        Cheese CreateCheese();
        List<IIngredient> CreateIngredients(string type);
    }

    class ChicagoIngredientFactory : IIngredientFactory {
        public Dough CreateDough() {
            return new ThickDough();
        }
        public Sause CreateSause() {
            return new PlumTomatoSauce();
        }
        public Cheese CreateCheese() {
            return new MozzarellaCheese();
        }
        public List<IIngredient> CreateIngredients(string type) {
            List<IIngredient> result = new List<IIngredient>();
            if (type == "Clam") {
                result.Add(new FrozenClams());
            }
            if (type == "Peperoni")
            {
                result.Add(new Peperoni());
            }
            return result;
        }
    }


    class NYIngredientFactory : IIngredientFactory
    {
        public Dough CreateDough()
        {
            return new ThinDough();
        }
        public Sause CreateSause()
        {
            return new MarinaraSauce();
        }
        public Cheese CreateCheese()
        {
            return new ReggianoCheese();
        }
        public List<IIngredient> CreateIngredients(string type)
        {
            List<IIngredient> result = new List<IIngredient>();
            if (type == "Clam")
            {
                result.Add(new FreshClams());
            }
            if (type == "Peperoni")
            {
                result.Add(new Peperoni());
            }
            return result;
        }
    }


}