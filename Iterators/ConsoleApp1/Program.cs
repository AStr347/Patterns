using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu pancakeHouseMenu = new Menu("PancakeHouse", "Breakfast");
            Menu dinerMenu = new Menu("DINER MENU", "Lunch");
            Menu AllMenu = new Menu("ALL MENU", "ALL");
            AllMenu.Add(pancakeHouseMenu);
            AllMenu.Add(dinerMenu);

            Waitress waitress = new Waitress(AllMenu);
            

            pancakeHouseMenu.Add(new MenuItem("K & B's Pancake Breakfast",
            "Pancakes with scrambled eggs, and toast",
            true,
            2.99));
            pancakeHouseMenu.Add(new MenuItem("Regular Pancake Breakfast",
            "Pancakes with fried eggs, sausage",
            false,
            2.99));
            pancakeHouseMenu.Add(new MenuItem("Blueberry Pancakes",
            "Pancakes made with fresh blueberries",
            true,
            3.49));
            pancakeHouseMenu.Add(new MenuItem("Waffles",
            "Waffles, with your choice of blueberries or strawberries",
            true,
            3.59));

            dinerMenu.Add(new MenuItem("Vegetarian BLT",
            "(Fakin’) Bacon with lettuce & tomato on whole wheat", 
            true, 2.99));
            dinerMenu.Add(new MenuItem("BLT",
            "Bacon with lettuce & tomato on whole wheat", 
            false, 2.99));
            dinerMenu.Add(new MenuItem("Soup of the day",
            "Soup of the day, with a side of potato salad", 
            false, 3.29));
            dinerMenu.Add(new MenuItem("Hotdog",
            "A hot dog, with saurkraut, relish, onions, topped with cheese",
            false, 3.05));

            waitress.PrintMenu();
            Console.WriteLine("\n\n");
            waitress.PrintVegetarian();
            Console.ReadKey();
        }
    }
}
