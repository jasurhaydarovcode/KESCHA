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
            int animalAge
        )
        {
            Name = name;
            AgeDifference = userAge - animalAge;
        }
    }
}