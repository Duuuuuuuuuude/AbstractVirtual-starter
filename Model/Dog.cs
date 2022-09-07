using System;

namespace AbstractVirtual.Model
{
    public class Dog : Animal
    {
        public Dog(string species, string breed) : base(species, breed)
        {
        }

        public override void PerformTrick()
        {
            Console.WriteLine("Dog performed a trick.");
        }
    }
}
