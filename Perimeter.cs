// using System;

// namespace Perimeter
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             string finish;
//             do
//             {
//             Console.WriteLine("Hello Friend! Welcome to the Home Calculator!");
//             Console.WriteLine("Please enter your name:");
//             string name = Console.ReadLine();

//             Console.WriteLine("Thank you " + name + "!" + "\r\n");
//             Console.WriteLine("Let's get to your room, what is the name of your room?");
//             string room = Console.ReadLine();
//             Console.WriteLine("Awesome " + name + "!"+" Let's get to measuring your " + room + "." + "\r\n");

//             Console.WriteLine("Enter the length:");
//             double length = double.Parse(Console.ReadLine());
//             Console.WriteLine("Enter the width:");
//             double width = double.Parse(Console.ReadLine());

//             double pm =  2 *(width + length);
//             double area = length * width;
//             Console.WriteLine("The area of " + room + " is " + area + ".");
//             Console.WriteLine("The perimeter of " + room + " is " + pm + "." + "\r\n");

//             Console.WriteLine("Would you like to measure another room " + name + "?" + " Please enter Yes or No.");

//             finish = Console.ReadLine();


//             } while(finish.ToLower() != "no");
//             Console.WriteLine("Thank you for using the Home Calculator!");
//         }
//     }
// }
