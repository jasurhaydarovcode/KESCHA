using System;
using KESCHA.Classes;
using static System.Console;

class Program
{
    static void Main()
    {
        Write("Enter your name: ");
        string name = ReadLine();
        WriteLine($"Hello, {name}!");

        Write("Enter your age: ");
        string ageAsString = ReadLine();
        WriteLine("Converting your age to an integer...");

        int age = Convert.ToInt32(ageAsString);
        WriteLine($"Successfully converted! Your age: {age}");

        Animal kescha = new Animal(name: "Kescha", userAge: age, animalAge: 3);

        // WriteLine(kescha.Name);
        // WriteLine(kescha.Age);

        WriteLine($"The difference between your age and Kescha's age is {kescha.AgeDifference} years.");

        if (age > kescha.Age)
        {
            WriteLine("You are older!");
        }
        else if (age == kescha.Age)
        {
            WriteLine("You and Kescha are the same age!");
        }
        else
        {
            WriteLine("You are younger!");
        }

        WriteLine("\nLet me tell you about my friends.");

        string[] friendsNames = { "Asliddin", "Sarvinoz", name };
        int[] friendsAges = { 16, 19, age };

        for (int i = 0; i < friendsNames.Length; i++)
        {
            WriteLine($"{friendsNames[i]} is {friendsAges[i]} years old!");
        }
    }
}
