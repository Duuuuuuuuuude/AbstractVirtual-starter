using System;

namespace AbstractVirtual.Model
{
    public class Cat : Animal
    {


        public Cat(string species, string breed) : base(species, breed)
        {
        }

        public override void PerformTrick()
        {
            Console.WriteLine("Cat performed a trick.");
        }
    }
}
