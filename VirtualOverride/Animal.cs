using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualOverride
{
    internal class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public bool IsHungry { get; set; }

        public Animal(string name, int age)
        {
            Name = name;
            Age = age;
            IsHungry = true;
        }

        //virtual methods can be overridden in inherited classes
        public virtual void MakeSounds()
        {

        }

        public virtual void Eat()
        {
            if (IsHungry)
            {
                Console.WriteLine($"{Name} is eating!");
            }
            else
            {
                Console.WriteLine($"{Name} is not hungry!");
            }
        }

        public virtual void Play()
        {
            Console.WriteLine($"{Name} is playing!");
        }
    }
}
