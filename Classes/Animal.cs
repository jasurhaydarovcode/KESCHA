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

        private int CalculateAgeDifference(int userAge, int animalAge)
        {
            return userAge - animalAge;
        }

        private void CalculateAgeDifferenceWithNoReturn(int userAge, int animalAge)
        {
            AgeDifference = userAge - animalAge;
        }
    }
}