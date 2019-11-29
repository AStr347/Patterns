using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IIterator <T>
    {
        bool HasNext();
        T Next();
    }

    class DinnerMenuIterator<T> : IIterator <T>
    {
        T[] Menu;
        int pos;

        public DinnerMenuIterator(T[] m)
        {
            Menu = m;
            pos = 0;
        }

        public bool HasNext()
        {
            if (pos >= Menu.Length || Menu[pos] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public T Next()
        {
            return Menu[pos++];
        }
    }

    class MenuIterator<T> : IIterator<T>
    {
        List<T> Menu;
        int pos;

        public MenuIterator(List<T> m)
        {
            Menu = m;
            pos = 0;
        }

        public bool HasNext()
        {
            if (pos >= Menu.Count || Menu[pos] == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public T Next()
        {
            return Menu[pos++];
        }
    }


    class CompositeIterator : IIterator<MenuComponent>
    {
        Stack<IIterator<MenuComponent>> stack = new Stack<IIterator<MenuComponent>>();
        public CompositeIterator(IIterator<MenuComponent> iterator)
        {
            stack.Push(iterator);
        }
        public MenuComponent Next()
        {
            if (HasNext())
            {
                IIterator<MenuComponent> iterator = stack.Peek();
                MenuComponent component = iterator.Next();
                stack.Push(component.Iterator());
                return component;
            }
            else
            {
                return null;
            }
        }
        public bool HasNext()
        {
            if (stack.Count == 0)
            {
                return false;
            }
            else
            {
                IIterator<MenuComponent> iterator = stack.Peek();
                if (!iterator.HasNext())
                {
                    stack.Pop();
                    return HasNext();
                }
                else
                {
                    return true;
                }
            }
        }
    }


    class NullIterator : IIterator<MenuComponent> {
        public bool HasNext()
        {
            return false;
        }
        public MenuComponent Next()
        {
            return null;
        }
    }

}
