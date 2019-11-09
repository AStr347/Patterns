using System;

namespace fabric
{
    abstract class Pizza
    {
        protected string name;
        protected string thickness, sause;
        public void Prepare(string from)    { Console.WriteLine("Preparing {0} {1} pizza", from, name); }
        public void Bake()                  { Console.WriteLine("Bake {0} pizza with {1} dough and {2} sause", name, thickness, sause); }
        public void Cut(int k)              { Console.WriteLine("Cutting into {0} pieces", k); }
        public void Box()                   { Console.WriteLine("Pack in a box"); }
    }

    class Peperoni : Pizza
    {
        public Peperoni (string h, string s) {
            name = "Peperoni";
            thickness = h;
            sause = s;
        }
    }

    class Cheese : Pizza
    {
        public Cheese (string h, string s) {
            name = "Cheese";
            thickness = h;
            sause = s;
        }
    }
}
