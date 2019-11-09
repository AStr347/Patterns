using System;

namespace abstract_fabric
{
    abstract class Clams : IIngredient { }

    class FreshClams : Clams
    {
        public FreshClams()
        {
            name = "Fresh Clams";
        }
    }

    class FrozenClams : Clams
    {
        public FrozenClams()
        {
            name = "Frozen Clams";
        }
    }
}
