using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalInterface
{
    class Animal
    {
        public string Name { get; set; }

    }

    interface INoisy
    {
        string MakeSound();
    }

    class AnimalUtility
    {
       public static void DoSomething(INoisyAnimal a)
        {
            Console.WriteLine("{0} says \"{1}\"", a.Name, a.MakeSound());
            
        }
    }

    interface INoisyAnimal : INoisy
    {
        string Name { get; }
    }

    class Bear : Animal, INoisyAnimal
    {
        public Bear()
        {
            Name = "Bear";
        }
        public string MakeSound()
        {
            return "Roar!";
        }

    }
    class Eagle : Animal, INoisyAnimal
    {
        public Eagle()
        {
            Name = "Eagle";
        }

        public string MakeSound()
        {
            return "Squak!";
        }


    }
    class Chicken : Animal, INoisyAnimal
    {
        public Chicken()
        {
            Name = "Chicken";
        }
        public string MakeSound()
        {
            return "chicken noisy!";
        }

    }

    class Program
    {
        static string Thing { get; set; }
        static void Main(string [] args)
        {
            AnimalUtility.DoSomething(new Bear());
            AnimalUtility.DoSomething(new Eagle());
            AnimalUtility.DoSomething(new Chicken());

            // Debug.Assert(new Bear().Name == "Bear", "This is not a bear");
            Console.ReadLine();
        }
        
    }
}
