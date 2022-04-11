using System;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            animal.Eat();

            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();

            Puppy puppy = new Puppy();
            puppy.Eat();
            puppy.Bark();
            puppy.Weep();

            Cat cat = new Cat();
            cat.Eat();
            cat.Meow();

        }
    }
}
