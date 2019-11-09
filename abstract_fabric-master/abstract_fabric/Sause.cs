using System;
namespace abstract_fabric
{
    abstract class Sause : IIngredient { }

    class MarinaraSauce : Sause
    {
        public MarinaraSauce()
        {
            name = "Marinara Sauce";
        }
    }

    class PlumTomatoSauce : Sause
    {
        public PlumTomatoSauce()
        {
            name = "PlumTomato Sauce";
        }
    }
}
