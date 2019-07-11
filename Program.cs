using System;
using TemolateMethod_Food.Food;

namespace TemolateMethod_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            Hamburger ham = new Hamburger();
            ham.Prepare();
            Console.WriteLine();
            HotDog hd = new HotDog();
            hd.Prepare();
        }
    }
}
