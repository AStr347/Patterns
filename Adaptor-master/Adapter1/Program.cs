using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter1
{
    interface IDuck {
        void Fly();
        void Quack();
    }

    abstract class Duck : IDuck {
        public string name;
        public void Fly() { Console.WriteLine("I'm Fly"); }
        public void Quack() { Console.WriteLine("Quack!"); }
    }

    abstract class Turkey
    {
        public string name;
        public void Fly() { Console.WriteLine("I’m flying a short distance"); }
        public void Gobble() { Console.WriteLine("Gobble! gobble"); }
    }

    class WildDuck : Duck {
        public WildDuck() {
            name = "Wild Duck";
        }
    }

    class WildTurkey : Turkey
    {
        public WildTurkey()
        {
            name = "Wild Turkey";
        }
    }

    class AdapterTurkeyToDuck : IDuck{
        Turkey t;

        public AdapterTurkeyToDuck(Turkey _t) {
            t = _t;
        }

        public void Fly() {
            for(int i =0; i < 5; i++)
                t.Fly();
        }
        public void Quack() { t.Gobble(); }
    }


    class Program
    {
        static void TestDuck(IDuck d) {
            d.Fly();
            d.Quack();
        }


        static void Main(string[] args)
        {
            IDuck wildDuck = new WildDuck();
            Turkey wildTurkey = new WildTurkey();
            IDuck wildTurkeyButDuck = new AdapterTurkeyToDuck(wildTurkey);

            wildTurkey.Fly();
            wildTurkey.Gobble();
            Console.WriteLine();
            TestDuck(wildDuck);
            Console.WriteLine();
            TestDuck(wildTurkeyButDuck);
            Console.ReadLine();
        }
    }
}
