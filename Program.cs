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
WriteLine("Sizning yoshingiz Kesshani yoshidan shunchaga farq qiladi: {0}", ageDiffernce);

WriteLine($"Siz keshadan kattasiz: {ageDiffernce > 0}");
WriteLine($"Kessha sizdan katta: {keschasAge > age}");
WriteLine($"Kessha bilan yoshingiz teng: {keschasAge == age}");
WriteLine($"Kesshani yoshi siz bilan bir xil emas: {keschasAge != age}");