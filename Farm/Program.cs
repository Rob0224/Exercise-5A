using System;

namespace Farm
{
    class Program
    {
        static void Main(string[] args)
        {

            
            Cow Besty = new Cow();
            Chicken Juice = new Chicken();
            Horse Jackie = new Horse();
            Dog Rover = new Dog();

            Console.WriteLine("Hello welcome to the farm");
            Console.WriteLine("Let's see the animals");
            Console.WriteLine();

            
            Juice.Talk();
            Besty.Talk();
            Jackie.Talk();
            Rover.Talk();
            
            newAnimal();
        }

        
        static void newAnimal()
        {
            Animals custom = new Animals();
            custom.AssignName("Barbatos");
            custom.makeNoise("Woof Woof");
            custom.Eats("the blood of his enemies.");
            custom.Feet(4);
            custom.setSpecies("Dog");

            custom.Talk();
        }
    }
}
