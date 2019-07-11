using System;
using System.Collections.Generic;
using System.Text;

namespace TemolateMethod_Food.Food
{
    abstract class FastFood
    {
        public void Prepare()
        {
            RoastBread();
            PrepareMainIngredient();
            PutVegetables();

            if(CustomerWantsTopings())
            AddTopings();
        }

        public void RoastBread()
        {
            Console.WriteLine("Bread");
        }
        public abstract void PrepareMainIngredient();

        public void PutVegetables()
        {
            Console.WriteLine("Vegetables");
        }

        public abstract void AddTopings();

        public virtual bool CustomerWantsTopings()
        {
            return true;
        }
    }
}
