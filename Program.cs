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
WriteLine("Sizning yoshingiz Kesshani yoshidan {0} ga farq qiladi.", ageDiffernce);

WriteLine($"Kesha sizdan katta: {keschasAge > age}");
WriteLine($"Siz keshadan kattasiz: {keschasAge < age}");
WriteLine($"Siz Kessha bilan tengsiz: {keschasAge == age}");
WriteLine($"Siz Kesshadan kattasiz yoki tengsiz: {keschasAge <= age}");
WriteLine($"Kessha siz bilan teng emas: {keschasAge != age}");
