using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shab_method
{

    abstract class ACaffeineBeverage
    {
        public void prepareRecipe() {
            boilWater();
            brew();
            pourInCup();
            addComponent();
        }
        protected void boilWater() {
            Console.WriteLine("Boiling water");
        }
        protected void pourInCup() {
            Console.WriteLine("Pouring into cup");
        }
        abstract protected void brew();
        abstract protected void addComponent();
    }

    class Coffe : ACaffeineBeverage {
        protected override void brew() { Console.WriteLine("Dripping Coffee through filter"); }
        protected override void addComponent() { Console.WriteLine("Adding Sugar and Milk"); }
    }

    class Tea : ACaffeineBeverage
    {
        protected override void brew() { Console.WriteLine("Steeping the tea"); }
        protected override void addComponent() { Console.WriteLine("Adding Lemon"); }
    }



    class Program
    {
        static void Main(string[] args)
        {
            Coffe coffe = new Coffe();
            Tea tea = new Tea();
            coffe.prepareRecipe();
            Console.WriteLine();
            tea.prepareRecipe();
            Console.ReadKey();
        }
    }
}
