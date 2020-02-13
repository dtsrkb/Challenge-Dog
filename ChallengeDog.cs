using System;

namespace Challenge_Dog
{
    public enum Gender
        {
            Male,
            Female
        }

    public class Dog
    {
        public string Name;
        public string Owner;
        public int Age;
        public Gender Gender;
        public Dog(string name, string owner, int age, Gender gender)
        {
            this.Name = name;
            this.Owner = owner;
            this.Age = age;
            this.Gender = gender;
        }

        public void Bark (int barks)
        {
            for(int i = 0; i < barks; i++)
            {
                Console.Write("Woof!");
            }

            Console.WriteLine("");
        }

        public string GetTag ()
        {
            string tag = "";

            if(this.Gender == 0 && this.Age == 1)
            {
                tag = $"If lost, call {Owner}. His name is {Name} and he is {Age} year old.";
            }
            else if (this.Gender == 0 && this.Age != 1)
            {
                tag = $"If lost, call {Owner}. His name is {Name} and he is {Age} years old.";
            }

            if(this.Gender == (Gender)1 && this.Age == 1)
            {
                tag = $"If lost, call {Owner}. Her name is {Name} and she is {Age} year old.";
            }
            else if (this.Gender == (Gender)1 && this.Age != 1)
            {
                tag = $"If lost, call {Owner}. Her name is {Name} and she is {Age} years old.";
            }

            return tag;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog puppy = new Dog("Orion", "Shawn", 1, Gender.Male);  
            puppy.Bark(3);
            Console.WriteLine(puppy.GetTag()); 

            Dog myDog = new Dog("Lileu", "Dale", 4, Gender.Female);  
            myDog.Bark(1);
            Console.WriteLine(myDog.GetTag());
        }
    }
}
