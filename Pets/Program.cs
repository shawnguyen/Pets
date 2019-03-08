using System;

namespace Pets
{
    class Program
    {
        static void Main(string[] args)
        {
            Pet pet1 = new Pet();
            pet1.MakePet("dog", "Shadow", "Jose", 42.6);
            Console.WriteLine("Name: " + pet1.Name());
            Console.WriteLine("Weight: " + pet1.Weight());
            Console.WriteLine(pet1.GetTag());

            Dog dog1 = new Dog();
            dog1.MakeDog("Daisy", "Kent", 23.4);
            Console.WriteLine("Name: " + dog1.Name());
            Console.WriteLine("Weight: " + dog1.Weight());
            Console.WriteLine(dog1.GetTag());
            Console.WriteLine(dog1.Bark(4));

            Cat cat1 = new Cat();
            cat1.MakeCat("Simba", "Maria", 5.2);
            Console.WriteLine("Name: " + cat1.Name());
            Console.WriteLine("Weight: " + cat1.Weight());
            Console.WriteLine(cat1.GetTag());
            Console.WriteLine(cat1.Meow(3));
        }
    }
}
