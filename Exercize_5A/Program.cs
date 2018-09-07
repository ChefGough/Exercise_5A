using System;

namespace Exercize_5A
{
    class Program
    {
        static void Main(string[] args)
        {
            Horse horse = new Horse();
            Cow cow = new Cow();
            Dog dog = new Dog();
            Lizzard lizzard = new Lizzard();

            //Horse
            Console.WriteLine("______________________________HORSE_______________________________");

            horse.Speak();
            horse.Eat();
            horse.Product();
            horse.Species();

            //Cow
            Console.WriteLine("______________________________COW_______________________________");
            
            cow.Speak();
            cow.Eat();
            horse.Product();
            cow.Species();

            //Dog
            Console.WriteLine("______________________________DOG_______________________________");
            dog.Speak();
            dog.Eat();
            dog.Product();
            dog.Species();

            //Lizzard
            Console.WriteLine("______________________________LIZZARD_______________________________");
            lizzard.Speak();
            lizzard.Eat();
            lizzard.Product();
            lizzard.Species();





        }
    }
}
