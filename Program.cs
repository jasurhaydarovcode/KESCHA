using System;
using static System.Console;

Write("Enter your name: ");
string name = ReadLine();
string greating = $"Hello {name}";
WriteLine(greating);

Write("Enter your age: ");
int age = Convert.ToInt32(ReadLine());

int keschasAge = 4;
int ageDiffernce = age - keschasAge;
WriteLine("Kescha's age: {0}", ageDiffernce);