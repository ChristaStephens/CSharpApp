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
    sagittarius = 10,
    capricorn = 11,

}
namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            string finish;
            do
            {

                Console.WriteLine("Enter your name");
                string name = Console.ReadLine();
                Console.WriteLine("Nice to meet you " + name);
                Console.WriteLine("Pick a number between 0-12."); // loop here to have user try to put a number between 0-12
                int num = int.Parse(Console.ReadLine());
                if (num >= 1 && num <= 12)
                {

                    Console.WriteLine(name + " based on this number your zodiac may be " + num);
                }
                else

                {
                    Console.WriteLine("Pick a number between 0-12 " + name);
                }
                // Console.WriteLine(Zodiac.aquarius); // for reference https://www.tutorialsteacher.com/codeeditor?cid=cs-4DtLXp

                Console.WriteLine("Would you like enter another number " + name + "?" + " Please enter Yes or No.");

                finish = Console.ReadLine();

            } while (finish.ToLower() != "no");
            Console.WriteLine("Thank you for using the Home Calculator!");
        }
    }
}
