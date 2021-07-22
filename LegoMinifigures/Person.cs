using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegoMinifigures
{
    class Person
    {
      
        public string Head { get; set; }
        public string Legs { get; set; }
        public string Name { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public void SetName (string name)
        {
            Console.WriteLine($"Lego person's name is {name}");
        }

        public void SpecialAttack(string name)
        {
            Console.WriteLine($"{name} attacked villages and destroyed everything");
        }

    }
}
