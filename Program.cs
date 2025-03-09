using System;
using KESCHA.Classes;
using static System.Console;

namespace KESCHA
{
    class Program
    {
        static void Main()
        {
            Animal kescha = new Animal(name: "Kescha", age: 3);

            Write("Enter your name: ");
            string userName = ReadLine();
            kescha.Greet(userName);

            Write("Enter your age: ");
            string ageAsString = ReadLine();

            WriteLine("Converting your age to an integer...");
            int userAge = Convert.ToInt32(ageAsString);
            WriteLine($"Successfully converted! Your age: {userAge}");

            kescha.CalculateAgeDifferenceWithNoReturn(userAge);
            kescha.PrintAgeDifference();
            kescha.CompareAges(userAge);
            kescha.TellAboutFriends(userName, userAge);

            // Check Info
            // WriteLine(kescha.Name);
            // WriteLine(kescha.Age);
        }
    }
}