using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    abstract class MenuComponent
    {
        virtual public void Add(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }
        virtual public void Remove(MenuComponent menuComponent)
        {
            throw new NotSupportedException();
        }
        virtual public MenuComponent GetChild(int i)
        {
            throw new NotSupportedException();
        }
        virtual public String GetName()
        {
            throw new NotSupportedException();
        }
        virtual public String GetDescription()
        {
            throw new NotSupportedException();
        }
        virtual public double GetPrice()
        {
            throw new NotSupportedException();
        }
        virtual public bool IsVegetarian()
        {
            throw new NotSupportedException();
        }
        virtual public void Print()
        {
            throw new NotSupportedException();
        }
        virtual public IIterator<MenuComponent> Iterator() {
            throw new NotSupportedException();
        }
    }
}
