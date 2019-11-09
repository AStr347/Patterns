using System;

namespace abstract_fabric
{
    abstract class Cheese : IIngredient { }

    class ReggianoCheese : Cheese
    {
        public ReggianoCheese()
        {
            name = "Reggiano Cheese";
        }
    }

    class MozzarellaCheese : Cheese {
        public MozzarellaCheese() {
            name = "Mozzarella Cheese";
        }
    }

}
