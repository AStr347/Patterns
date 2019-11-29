using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class MenuItem : MenuComponent
    {
        String name;
        String description;
        bool vegetarian;
        double price;

        public MenuItem(String name, String description,
                        bool vegetarian, double price)
        {
            this.name = name;
            this.description = description;
            this.vegetarian = vegetarian;
            this.price = price;
        }
        override public String GetName()
        {
            return name;
        }
        override public String GetDescription()
        {
            return description;
        }
        override public double GetPrice()
        {
            return price;
        }
        override public bool IsVegetarian()
        {
            return vegetarian;
        }
        public override void Print()
        {
            Console.WriteLine("\n{0}\t{1}\t{2}\t{3}\t", name, description, vegetarian? "V" : "X", price, description);
        }

        public override IIterator<MenuComponent> Iterator()
        {
            return new NullIterator();
        }
    }
}
