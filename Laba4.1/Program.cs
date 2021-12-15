using System;

namespace Laba4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal();
            Dog dog = new Dog();
            Poppy poppy = new Poppy();
            poppy.name();
            dog.Barking();
            animal.jump();
            animal.Run();
            animal.bite();
          
        }

    }
    class Animal
    {
      
        public void jump()
        {
            Console.WriteLine("I jump");
        }
        public void Run()
        {
            Console.WriteLine("I runing");
        }
        public void bite()
        {
            Console.WriteLine("I'm biting");
        }
        
    }
   class Dog : Animal
    {
       public void Barking(Dog dog)
        {
            dog.Barking();
        }
        public void jump(Animal animal)
        {
            animal.jump();
        }
        
        public void Run(Animal animal)
        {
            animal.Run();
        }
        public void dite(Animal animal)
        {
            animal.bite();
        }
        public void Barking()
        {
            Console.WriteLine("Gav Gav");
        }
    }
    class Poppy : Dog
    {
        public void name()
        {
            Console.WriteLine("Rex");
        }
        public void name(Poppy poppy)
        {
            poppy.name();
        }
    }
}

