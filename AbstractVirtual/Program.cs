using AbstractVirtual.Model;
using System;
using System.Collections.Generic;

namespace AbstractVirtual
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Instantiate

            // TODO: Insert animals in list
            List<Animal> animals = new List<Animal>() { /* replace this with animal objects */ };

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
