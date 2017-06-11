using System;
using System.Collections.Generic;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayTitle();

            // var firstName = GetFirstName();
            // GreetUser(firstName);

            // var age = GetAge();

            // Person currentUser = new Person(firstName, age);
            // currentUser.DisplayInfo();

            // DemoList();
        }

        static void DisplayTitle()
        {
            // type inference
            var title = "Hello, World!";
            Console.WriteLine(title);

            // static types
            // title = 123;

            // Compile error: 
            // Cannot implicitly convert type 'int' to 'string'
        }

        static string GetFirstName()
        {
            Console.WriteLine("What is your first name?");
            var firstName = Console.ReadLine();

            return firstName;

            // return type
            // return 123;

            // Compile error: 
            // Cannot implicitly convert type 'int' to 'string'
        }

        static void GreetUser(string firstName)
        {
            // string interpolation
            Console.WriteLine($"Hi, {firstName}!");
        }

        static int? GetAge()
        {
            Console.WriteLine("How old are you?");
            var ageInput = Console.ReadLine();

            // var age = int.Parse(ageInput);
            
            // Runtime error if not a number:
            // Input string was not in a correct format.

            int age;
            if (int.TryParse(ageInput, out age))
            {
                Console.WriteLine($"Age: {age}");
                return age;
            }
            else
            {
                Console.WriteLine($"Error: '{ageInput}' is not a number!");
                return null;
            }
        }

        static void DemoList()
        {
            List<string> skills = new List<string>();

            Console.WriteLine("What are your skills? (Enter blank line to end list.)");
            string skill = Console.ReadLine();

            while (!string.IsNullOrWhiteSpace(skill))
            {
                skills.Add(skill);
                skill = Console.ReadLine();
            }

            Console.WriteLine($"You have {skills.Count} skill{(skills.Count == 1 ? "" : "s")}!");
        }
    }

    class Person
    {
        string firstName;
        public string FirstName
        {
            get
            {
                return firstName;
            }
            set
            {
                firstName = value;
            }
        }

        int? age;
        public int? Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public Person(string firstName, int? age)
        {
            this.firstName = firstName;
            this.age = age;
        }

        public Person(string firstName)
        {
            this.firstName = firstName;
        }

        public void DisplayInfo()
        {
            if (Age.HasValue)
            {
                Console.WriteLine($"Person Info: {FirstName} is {Age} years old.");
            }
            else
            {
                Console.WriteLine($"Person Info: {FirstName} is of unknown age.");
            }
        }
    }

    public enum Roles
    {
        Organizer = 1,
        Member = 2
    }

    public enum Colors
    {
        Red = 0xFF0000,
        Green = 0x00FF00,
        Blue = 0x0000FF
    }
}