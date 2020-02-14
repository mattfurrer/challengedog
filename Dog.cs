using System;

namespace challengedog
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog puppy = new Dog("Orion", "Shawn", 1, Gender.Male);  // create object instance
            puppy.Bark(3); // output: Woof!Woof!Woof!
            Console.WriteLine(puppy.GetTag()); // output: If lost, call Shawn. His name is Orion and he is 1 year old.

            Dog myDog = new Dog("Lileu", "Dale", 4, Gender.Female);  // create object instance
            myDog.Bark(1); // output: Woof!
            Console.WriteLine(myDog.GetTag()); // output: If lost, call Dale. Her name is Lileu and she is 4 years old.
        }
    
        public class Dog {
        public Dog (string name, string owner, int age, Gender gender) {
            this.name = name;
            this.owner = owner;
            this.age = age;
            this.gender = gender;
        }

        public void Bark (int n) {
            for (int i = 0; i < n; i++) {
                Console.WriteLine("Woof!");
            }
        }

        public string GetTag() {
            if(this.gender == Gender.Male) {
                return "If lost, call " + this.owner + ". His name is " + this.name + " and he is " + this.age + " years old.";
            } else {
                return "If lost, call " + this.owner + ". Her name is " + this.name + " and she is " + this.age + " years old.";
            }
        }

        public string name;
        public string owner;
        public int age;
        public Gender gender;



    }

    public enum Gender {
        Male,
        Female
    }
}
    }

    
