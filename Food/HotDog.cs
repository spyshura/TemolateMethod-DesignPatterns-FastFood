using System;
using System.Collections.Generic;
using System.Text;

namespace TemolateMethod_Food.Food
{
    class HotDog : FastFood
    {
        public override bool CustomerWantsTopings()
        {
            Console.WriteLine("Do you want mustard?: ");
            var userInput = Console.ReadLine();
            return userInput.ToLower() == "yes" || userInput.ToLower() == "y";
        }

        public override void PrepareMainIngredient()
        {
            Console.WriteLine("Sousage");
        }

        public override void AddTopings()
        {
            Console.WriteLine("Mustard");
        }
    }
}
