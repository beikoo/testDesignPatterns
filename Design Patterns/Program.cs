using Design_Patterns.AbstractFactory;
using System;

namespace Design_Patterns
{
    class MainApp

    {
        public static void Main()
        {
            BrandFactory german = new GermanCarFactory();
            Car world = new Car(german);
            world.BeatChain();

            BrandFactory german2 = new GermanCarFactory2();
            world = new Car(german2);
            world.BeatChain();

            Console.ReadKey();
        }
    }
}
