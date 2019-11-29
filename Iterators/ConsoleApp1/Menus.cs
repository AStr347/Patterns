using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Menu : MenuComponent
    {
        string Name, Description;
        List<MenuComponent> menuItems;
        public Menu(string name, string description)
        {
            Name = name;
            Description = description;
            menuItems = new List<MenuComponent>();
        }

        public override string GetName()
        {
            return Name;
        }

        public override string GetDescription()
        {
            return Description;
        }

        override public void Add(MenuComponent menuComponent)
        {
            menuItems.Add(menuComponent);
        }

        override public IIterator<MenuComponent> Iterator()
        {
            return new CompositeIterator(new  MenuIterator<MenuComponent> (menuItems));
        }

        public override void Print()
        {
            Console.WriteLine("\n"+GetName());
            Console.WriteLine(", " +GetDescription());
            Console.WriteLine("---------------------");
            IIterator<MenuComponent> iterator = Iterator();
            while (iterator.HasNext())
            {
                MenuComponent menuComponent = iterator.Next();
                menuComponent.Print();
            }
        }
    }

    /*class DinerMenu : Menu
    {
        const int MAX_ITEMS = 6;
        int numberOfItems = 0;
        MenuComponent[] menuItems;
        public DinerMenu()
        {
            menuItems = new MenuComponent[MAX_ITEMS];
            Add(new MenuItem("Vegetarian BLT",
            "(Fakin’) Bacon with lettuce & tomato on whole wheat", true, 2.99));
            Add(new MenuItem("BLT",
            "Bacon with lettuce & tomato on whole wheat", false, 2.99));
            Add(new MenuItem("Soup of the day",
            "Soup of the day, with a side of potato salad", false, 3.29));
            Add(new MenuItem("Hotdog",
            "A hot dog, with saurkraut, relish, onions, topped with cheese",
            false, 3.05));
            // a couple of other Diner Menu items added here
        }
        public void Add(MenuComponent menuComponent)
        {
            if (numberOfItems >= MAX_ITEMS)
            {
                Console.WriteLine("Sorry, menu is full!Can’t Add item to menu");
            }
            else
            {
                menuItems[numberOfItems] = menuComponent;
                numberOfItems = numberOfItems + 1;
            }
        }
        public IIterator<MenuComponent> CreIterator()
        {
            return new DinnerMenuIterator<MenuComponent>(menuItems);
        }
    }*/
}
