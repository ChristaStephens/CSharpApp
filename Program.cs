using System;

enum Zodiac
{
    aquarius = 0,
    pisces = 1,
    aries = 2,
    taurus = 3,
    gemini = 4,
    cancer = 5,
    leo = 6,
    virgo = 7,
    libra = 8,
    scorpio = 9,
    sagittarius =10,
    capricorn = 11,

}
namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Nice to meet you " + name);
            Console.WriteLine("Pick a number between 0-12."); // loop here to have user try to put a number between 0-12
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(name + " based on this number your zodiac may be " + num);
        Console.WriteLine(Zodiac.aquarius); // for reference https://www.tutorialsteacher.com/codeeditor?cid=cs-4DtLXp
        }
    }
}
