using System;
namespace abstract_fabric
{
    abstract class Dough : IIngredient { }

    class ThinDough : Dough
    {
        public ThinDough()
        {
            name = "Thin Dough";
        }
    }

    class ThickDough : Dough
    {
        public ThickDough()
        {
            name = "Thick Dough";
        }
    }
}
