using System;
using System.Collections.Generic;
namespace abstract_fabric
{
    abstract class Pizza
    {
        protected IIngredientFactory idf;
        protected string name;
        protected IIngredient dough, sause, cheese;
        protected List<IIngredient> ingr;
        public void Prepare(string from){
            Console.WriteLine("Preparing {0} {1} pizza", from, name);
            dough = idf.CreateDough();
            sause = idf.CreateSause();
            cheese = idf.CreateCheese();
            ingr = idf.CreateIngredients(name);
        }
        public void Bake(){
            Console.WriteLine("Bake {0} pizza with {1}, {2} and {3}", name, dough.name, sause.name, cheese.name);
            Console.WriteLine("ingredients:");
            foreach (var i in ingr) {
                Console.Write("{0}, ",i.name);
            }
            Console.WriteLine();
        }
        public void Cut(int k)              { Console.WriteLine("Cutting into {0} pieces", k); }
        public void Box()                   { Console.WriteLine("Pack in a box"); }
    }

    class PeperoniPizza : Pizza
    {
        public PeperoniPizza(IIngredientFactory _idf) {
            name = "Peperoni";
            idf = _idf;
        }
    }

    class CheesePizza : Pizza
    {
        public CheesePizza(IIngredientFactory _idf) {
            name = "Cheese";
            idf = _idf;
        }
    }

    class ClamPizza : Pizza {
        public ClamPizza(IIngredientFactory _idf) {
            name = "Clam";
            idf = _idf;
        }
    }
}
