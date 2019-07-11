using System;
using System.Collections.Generic;
using System.Text;

namespace TemolateMethod_Food.Food
{
    class Hamburger : FastFood
    {
        public override void PrepareMainIngredient()
        {
            Console.WriteLine("Meat");
        }

        public override void AddTopings()
        {
            Console.WriteLine("Ketchup");
        }
    }
}
