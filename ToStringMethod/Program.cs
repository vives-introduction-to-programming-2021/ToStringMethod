using System;

namespace ToStringMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to doggy world");

            Dog rose = new Dog();
            rose.SetName("Rose");

            rose.Breed = "Samoyed";     // Via property

            Console.WriteLine("Our dogs name is " + rose.GetName());
            Console.WriteLine("The breed of our dog is " + rose.Breed);

            // Calling the ToString() method
            Console.WriteLine(rose.ToString());
            Console.WriteLine(rose);
            string myDog = "My dog: " + rose;
            Console.WriteLine(myDog);
        }
    }
}
