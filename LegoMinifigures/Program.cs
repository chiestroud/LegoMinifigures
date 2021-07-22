using System;

namespace LegoMinifigures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your name");
            var name = Console.ReadLine();
            var legoPerson = new Person(name);
            legoPerson.SetName(name);

            Console.WriteLine("Do you want to see your special abilities? Yes or No?");
            var answer = Console.ReadLine();
            if (answer.ToLower() == "yes")
            {
                legoPerson.SpecialAttack(name);
            }
            else
            {
                Console.WriteLine("I think you are too nice.");
            }

            var newHair = new Clothes();
            Console.WriteLine("Do you want special clothes?");
            var clothesAnswer = Console.ReadLine();
            if (clothesAnswer.ToLower() == "yes")
            {
                newHair.getHair(name);
            } 
            else
            {
                Console.WriteLine($"Goodbye {name}. You are fired.");
            }

        }
    }
}
