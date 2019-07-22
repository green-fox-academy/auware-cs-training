using System;

namespace FirstConsoleApp
{
    public class Person
    {
        private string name;
        private int age;
        //private int height;

        // Auto property
        public int Height { get; set; }

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                if (value < 0) return;

                age = value;
            }
        }

        //public int getAge()
        //{
        //    return age;
        //}

        //public void setAge(int value)
        //{
        //    if (value < 0) return;

        //    age = value;
        //}

        public Person()
        {
            Console.WriteLine("Runs automatically for every new person");

            age = 18;
        }

        public Person(string name, int age, int height)
        {
            this.name = name;
            this.age = age;
            Height = height;
        }


        public Person(string name, int age) : this(name, age, 180)
        {
            //this.name = name;
            //this.age = age;
            //height = 180;
        }

        public void PrintPerson()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Height: " + Height);
        }

        public static void PrintAll()
        {
            // can't do
            //this.name;
            //PrintPerson();
            Console.WriteLine("List of people...");
        }

        public Person Clone()
        {
            return new Person(name, age, Height);
        }
    }
}
