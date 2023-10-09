// See https://aka.ms/new-console-template for more information
using ConsoleApp1;


Animal animal = new Animal("snake",0,0);
animal.Makesound();
animal.Animaldetails();

Console.WriteLine();
Cat cat = new Cat("cat", 2, 2);
cat.Animaldetails();
cat.Makesound();

Console.WriteLine();

Cow cow = new Cow("cow", 2, 2);
cow.Animaldetails();
cow.Makesound();
Console.WriteLine();

Fly fly = new Fly("fly", 2, 4);
fly.Animaldetails();
fly.Makesound();
Console.WriteLine();