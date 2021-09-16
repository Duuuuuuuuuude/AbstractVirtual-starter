using AbstractVirtual.Model;
using System;
using System.Collections.Generic;

namespace AbstractVirtual
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Instantiate the animal objects and insert them into the list

            List<Animal> animals = new List<Animal>() { /* replace this with the animal objects */ };

            foreach (Animal ani in animals)
            {
                Console.WriteLine(ani);
                ani.PerformTrick();
                ani.FeedAnimal();
            }
            Console.ReadLine();
        }
    }
}
