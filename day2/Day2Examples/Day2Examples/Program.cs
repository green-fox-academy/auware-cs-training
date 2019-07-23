using System;
using System.Linq;
using System.Collections.Generic;
using Day2Examples.Network;

namespace Day2Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            var error1 = new Database.Error();
            var error2 = new Error();

            Person[] people = new Person[]
                {
                    new Person { Name = "Petike", Age = 16 },
                    new Person("Sanyika", 47)
                };

            List<int> numbers = new List<int>();

            List<List<int>> sokList = new List<List<int>>();

            sokList.Add(new List<int> { 1, 2, 3 });
            sokList.Add(new List<int> { 1, 4 });

            sokList[0].Add(6);

            numbers.Add(2);
            numbers.Add(2);
            numbers.Add(3);
            numbers.Add(4);
            numbers.Add(3244);

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }

            var a = numbers[4];

            Dictionary<string, string> phoneBook = new Dictionary<string, string>();

            phoneBook.Add("Petike", "12325654");
            phoneBook.Add("Sanyika", "784937593");

            Console.WriteLine(phoneBook["Petike"]);

            Console.WriteLine("Hello World!");

            Person person1 = new Person("Petike", 15);
            Person person2 = new Person("Petike", 15);

            if(person1 == person2)
            {
                Console.WriteLine("They are the same");
            }
            else
            {
                Console.WriteLine("They are not the same");
            }

            Dictionary<Person, string> valami = new Dictionary<Person, string>();

            valami.Add(person1, "Test");

            Console.WriteLine(valami[person2]);

            var student = new Student();

            student.Name = "Lacika";
            student.Age = 45;

            student.Print();

            var teacher = new Teacher();

            teacher.Name = "Bela";
            teacher.Age = 60;
            teacher.NumberOfClasses = 20;

            teacher.Print();

            Person person11 = new Student();
            person11.Print();

            person11 = new Teacher();
            person11.Print();

            List<Person> otherPeople = new List<Person>
            {
                new Student(),
                new Student(),
                new Teacher(),
                new Student(),
                new Person()
            };

            foreach (var person in otherPeople)
            {
                person.Print();
            }

            object obj = 1;
            obj = "string";
            obj = new Person();
            obj = DateTime.Now;

            // void *

            obj = new Person("Moricka", 80);
            obj = 1;

            if (obj is Person p)
            {
                //Person p = (Person)obj;

                Console.WriteLine(p.Name);
            }

            List<object> superlista = new List<object>
            {
                1,
                "string",
                DateTime.Now,
                new Person()
            };

            // ArrayList == List<object>

            foreach (var item in superlista)
            {
                if(item is int n)
                {
                    n++;
                }

                if(item is Person p)
                {
                    p.Print();
                }
            }
        }
    }

    class Person
    {
        protected int mindegy;

        public string Name { get; set; }

        public int Age { get; set; }

        public int Height { get; set; }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public Person()
        {

        }

        public virtual void Print()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Age: " + Age);
        }

        public override bool Equals(object obj)
        {
            return obj is Person person &&
                   Name == person.Name;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Name);
        }
    }

    class Student : Person
    {
        public int ExamScore { get; set; }

        public DateTime SchoolStartedAt { get; set; }

        public Student()
        {
            mindegy = 56;
        }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Exam score: " + ExamScore);
        }
    }

    class Teacher : Person
    {
        public int NumberOfClasses { get; set; }

        public override void Print()
        {
            base.Print();
            Console.WriteLine("Number of classes: " + NumberOfClasses);
        }
    }
}
