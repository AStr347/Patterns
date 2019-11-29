using System;

namespace ConsoleApp1
{
    class Waitress
    {
        MenuComponent allMenus;

        public Waitress(MenuComponent m)
        {
            allMenus = m;
        }
        public void PrintMenu()
        {
            allMenus.Print();
        }
        public void PrintVegetarian() {
            IIterator<MenuComponent> iterator =  allMenus.Iterator();
            Console.WriteLine("Vegetarian Menu");
            while (iterator.HasNext()) {
                MenuComponent component = iterator.Next();
                try
                {
                    if (component.IsVegetarian())
                        component.Print();
                }
                catch (NotSupportedException) {}
            }
        }
    }
}
