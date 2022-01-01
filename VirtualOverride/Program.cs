// See https://aka.ms/new-console-template for more information
using VirtualOverride;

Animal dog = new Dog("Sif", 15);
Console.WriteLine($"{dog.Name} is {dog.Age} years old.");
dog.MakeSounds();
dog.Play();
dog.Eat();
