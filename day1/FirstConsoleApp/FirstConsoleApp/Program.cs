using System;

namespace FirstConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            long b = 6;
            //float c = 5.6;
            double d = 5.8;

            double e = 0.1 + 0.2;

            ushort f;

            byte g;

            char character = 'ő';

            bool isEqualTo = Math.Abs(e - 0.3) < 0.0001;

            if (isEqualTo)
            {
                Console.WriteLine("It's true");
            }
            else
            {

            }

            if (true)
                Console.WriteLine("I'm true");
            Console.WriteLine("I'm sad");

            bool h = true;
            bool j = false;

            if (a == 0)
            {
                Console.WriteLine("false");
            }

            while (h)
            {
                // örökre futok
                h = false;
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);

                for (int y = 0; y < 6; y++)
                {
                    Console.WriteLine(y);
                }
            }

            long[] szamok = new long[] { 1, 2, 3, 4, 5 };

            szamok[0] = 5;
            szamok[1] = 5;
            szamok[2] = 5;
            szamok[3] = 5;
            szamok[4] = 5;

            Array.Sort(szamok);

            //szamok = new int[a];

            for (int i = 0; i < szamok.Length; i++)
            {
                Console.WriteLine(szamok[i]);
            }

            var alma = 5;

            foreach (var item in szamok)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Hello World!");

            string name = "Petike";

            Console.WriteLine(name);

            var sum = Sum(1, 2);
            var sum2 = Sum(1, 2, 3);


            DayOfWeek dayOfWeek = DayOfWeek.Monday;
            // int dayOfWeek = 0;

            Console.WriteLine(dayOfWeek);
            Console.WriteLine((DayOfWeek)((int)DayOfWeek.Monday + (int)DayOfWeek.Tuesday));

            DayOfWeek dayOfWeek2 = (DayOfWeek)10000;
            // int dayOfWeek2 = 10000;

            Console.WriteLine(dayOfWeek2);

            Person petike = new Person();

            petike.Name = "Petike";
            petike.Age = 123;
            petike.Height = 190;

            PrintPerson(petike);

            petike.PrintPerson();

            var sanyika = new Person("sanyika", 40, 160);

            sanyika.PrintPerson();

            sanyika.Age = -3;

            sanyika.PrintPerson();

            //int szam;

            string line = Console.ReadLine();

            if(int.TryParse(line, out int number))
            {
                Console.WriteLine("Sikerult a szamot beolvasni:" + number);
            }
            else
            {
                Console.WriteLine("Please provide a valid number");
            }

            int szam = 5;
            int masikSzam = szam;

            masikSzam = masikSzam + 1;

            Console.WriteLine(szam);

            var person = new Person("bela", 1);
            var person2 = new Person("ildi", 2);

            person2.Age = person.Age;
            Person anotherPerson = person;

            anotherPerson.Age = anotherPerson.Age + 1;

            Console.WriteLine(person.Age);
            Console.WriteLine(person2.Age);

            var person3 = person.Clone();

            person3.Age = 45;

            DateTime now = DateTime.UtcNow;

            DateTime tomorrow = now.AddDays(1);

            Console.WriteLine(now);
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }

        static int Sum(int a, int b, int c)
        {
            return a + b;
        }

        static void PrintPerson(Person person)
        {
            Console.WriteLine("Name: " + person.Name);
            Console.WriteLine("Age: " + person.Age);
            Console.WriteLine("Height: " + person.Height);
        }

        static void PrintPersonShirtSize(Person person)
        {
            Console.WriteLine("Name: " + person.Name);
            if (person.Height > 180)
            {
                Console.WriteLine("T-shirt size: XL");
                return;
            }

            Console.WriteLine("T-shirt size: L");
        }
    }

    enum DayOfWeek
    {
        Monday,
        Tuesday,
        Wednesday,
        A4323
    }
}
