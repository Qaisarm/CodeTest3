using System;
using System.Collections.Generic;
namespace CodeTest3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(" ############################################# ");
            Console.WriteLine(" ############# 3.1) Encapsulation ############## ");
            Console.WriteLine(" #############################################\n ");
            /* Person press = new Person
             {
                 Age = 23,
                 FName = "Tom",
                 LName = "Ben",
                 Weight = 65,
                 Height = 174,

             };
             Console.WriteLine($" {press.FName} {press.LName} has  Age: {press.Age}");
             Console.WriteLine($" {press.FName} {press.LName} has  height {press.Height} and weight {press.Weight}");*/


            PersonHandler handler = new PersonHandler();

            Person pep1 = handler.CreatePerson(23, 165, 65, "Sara", "Jansson");
            Person pep2 = handler.CreatePerson(4, 185, 85, "Tom", "Hanksson");

            Console.WriteLine(handler.PersonStats(pep1));
            Console.WriteLine("-----------------------");
            Console.WriteLine(handler.PersonStats(pep2));


            Console.WriteLine(" ############################################# ");
            Console.WriteLine(" ############# 3.2) Inheritance ############## ");
            Console.WriteLine(" #############################################\n ");

            // F-8 (3.2- Inheritance) During development if all birds need a new attribute
            //      then it should be placed in the Bird class
            // F-9 (3.2- Inheritance) If all animals need the new attribute, 
            //      then it should be placed in the Animal Class


            Console.WriteLine(" ############################################# ");
            Console.WriteLine(" ############# 3.3) Polymorphism ############## ");
            Console.WriteLine(" #############################################\n ");

            // Create a list Animals in program.cs receiving animals.
            List<Animal> animals = new List<Animal>()
                {
              new Horse ("Fido", 23, 100, "Black"),
              new Dog ("LoLo", 5, 13, "Poodle"),
              new Hedgehog("Spiky", 2, 5, 45),
              new Worm("Centipid", 1, 0.5, 100),
              new Pelican("Amazon Bird", 12, 4, "Yellow"),
              new Dog("Charlie",9, 12, "German Shepherd" )
          };
            // Write out what animals are in the list with a foreach loop
            foreach (var ani in animals)
            {
                Console.WriteLine(value: ani);
            }
            Console.WriteLine("\n############################################# ");
            // Create a list for dogs
            List<Dog> dogs = new List<Dog>()
            {
                new Dog("Charlie",9, 12, "German Shepherd" ),
                new Dog("Toby", 4, 4, "Australian Terrier" ),
                new Dog("Max", 5, 6, "Dachshund" ),
                new Dog("Daisy", 9, 8, "German Dandie Dinmont" ),
                new Dog("Rosie", 6, 5, "Yorkshire Terrier" ),

                //new Horse("Cherry", 9, 54, "White")
                //F-7 (3.3- Polymorphism) 
                //      The Dog and Horse class are two Child classes of Animal 
                //      Class and we can not add a child class to another child class list
                //      The error we get is that we cant cont convert Horse class 
                //      to Dog class, so Horse can not be added to Dog list
                //F-8 (3.3- Polymorphism)
                //      If we want to add Horse and Dog in a list together 
                //      then the List shpuld be of Animal (Parent) type
            };

            // Print all Animals Stats () by a foreach loop.
            foreach (var anml in animals)
            {
                Console.WriteLine(anml.Stats());
            }
            Console.WriteLine("\n############################################# ");

            // F-11 (3.3- Polymorphism)
            //      Foreach loop checks each element in the animal list
            //      and runs the Stats () method.
            //      The Stats () method is compiled and a string of properties is returned,
            //      for the second and other elements in list the override modifier in Stat() method
            //      modifies the properties.

            //  Print Stats () method only for all dogs by a foreach on Animals
            foreach (var anml in animals)
            {
                if (anml is Dog)
                {
                    Console.WriteLine(anml.Stats());
                }
                // We can only get Dogs that are in animal List
                // but we can not access dogs list from Animal list
                // because these are two differnt lists
            }
            Console.WriteLine("\n############################################# ");
            //F-15 (3.3- Polymorphism): We can not access the new method from the dog class from the Animal list.
            //      Because the Animal list does not have access to the new method.
            //      One can only access the new method by casting from animal class to dog class
            //      then one can have a access to new method in the object.

            // Find a way to print out your new approach to death by a foreach of Animals.
            foreach (var dg in animals)
            {
                if (dg is Dog newDog)
                {
                    Console.WriteLine(newDog.Eats());
                }
            }
            Console.WriteLine("\n############################################# ");
            Console.WriteLine(" ############# 3.4) Polymorphism ############## ");
            Console.WriteLine(" #############################################\n ");

            List<UserError> userErrors = new List<UserError>
            {
                new NumericInputError(),
                new TextInputError(),
                new CharInputError(),
                new IntInputError(),
                new BooleanInputError()
            };

            foreach (var uer in userErrors)
            {
                Console.WriteLine(uer.UEMessage());
            }

            // F-11 (3.4- Polymorphism): It is important to master polymorphism, because it is one of the
            //      pillars of OOP, and it provides the ability to a class to have multiple implementations with the same name. 
            // F-12 (3.4- Polymorphism): Polymorphism allows to code that reduces coupling, duplication and
            //      increases reusability, and it also makes the code easier to read. With a good structure 
            //      the code becomes easy to understance and the code parts becomes avaliable for reuse.
            // F-13 (3.4- Polymorphism):Both the Abstract class and interface are used to achieve abstraction
            //      where one can declare the abstract methods. The difference between
            //      two are that an abstract class does not provide full abstraction while the Interface does
            //      An abstract class can be defined but the Interface member cant be defined
            //      using static, virtual or abstract.

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}