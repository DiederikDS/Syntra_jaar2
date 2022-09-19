using ExceptieIntroOefening1.Classes;
using System.Drawing;

Animal horse = new Animal();
horse.Name = "Charlie";
horse.Color = Color.White;
horse.LegCount = 4;

try
{
    horse.GetAge();
}
catch (Exception)
{

    Console.WriteLine($"{horse.Name} does not have a known date of birth");
}

Console.ReadKey();

Animal Cat = new Animal();
Cat.Name = "Tom";
Cat.Color = Color.SandyBrown;

try
{
    Cat.LegCount = 1;
}
catch (LegCountException)
{

    Console.WriteLine("LegCount must be higher than 1");
}
