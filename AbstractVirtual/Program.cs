using AbstractVirtual.Model;
using System;
using System.Collections.Generic;

// TODO: Instantiate the animal objects and insert them into the list

List<Animal> animals = new() { new Cat("Cat", "Mutant"), new Dog("Dog", "Golden Retriver") };

foreach (Animal ani in animals)
{
    Console.WriteLine(ani);
    ani.PerformTrick();
    ani.FeedAnimal();
}
Console.ReadLine();
