using static System.Console;

namespace KESCHA.Classes
{
    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int AgeDifference { get; set; }

        public Animal()
        {
            Name = "No name";
            Age = 0;
            AgeDifference = 0;
        }

        public Animal(string name, int age)
        {
            Age = age;
            Name = name;
        }

        public Animal(
            string name,
            int userAge,
            int animalAge)
        {
            Name = name;
            // AgeDifference = CalculateAgeDifference(userAge, animalAge);
            CalculateAgeDifferenceWithNoReturn(userAge, animalAge);
        }

        public void PrintAgeDifference()
        {
            WriteLine($"The difference between your age and {Name}'s age is {AgeDifference} years.");
        }

        public void CompareAges(int userAge)
        {
            if (userAge > Age)
            {
                WriteLine("You are older!");
            }
            else if (userAge == Age)
            {
                WriteLine("You and Kescha are the same age!");
            }
            else
            {
                WriteLine("You are younger!");
            }
        }

        public void TellAboutFriends(string userName, int userAge)
        {
            WriteLine("\nLet me tell you about my friends.");

            string[] friendsNames = { "Asliddin", "Sarvinoz", userName };
            int[] friendsAges = { 16, 19, userAge };

            for (int i = 0; i < friendsNames.Length; i++)
            {
                WriteLine($"{friendsNames[i]} is {friendsAges[i]} years old!");
            }
        }

        public void CalculateAgeDifferenceWithNoReturn(int userAge)
        {
            AgeDifference = userAge - Age;
        }

        public int CalculateAgeDifference(int userAge, int animalAge)
        {
            return userAge - animalAge;
        }

        public void Greet(string userName)
        {
            if (userName == "")
            {
                userName = "Unknown Person";
            }
            WriteLine($"Hello, {userName}!");
        }

        private void CalculateAgeDifferenceWithNoReturn(int userAge, int animalAge)
        {
            AgeDifference = userAge - animalAge;
        }
    }
}