# Getting started with Visual Studio, C# Control Flow, OO Basics

On the first day you will get familiar with the Visual Studio IDE and the basics of C#.

### Environment

 - Make sure that Microsoft Visual Studio Community Edition or Microsoft Visual Studio for Mac is installed on your machine
 - Download the Community edition from [here](https://visualstudio.microsoft.com/downloads)
 - You can follow [this](https://docs.microsoft.com/en-us/visualstudio/install/install-visual-studio?view=vs-2019) installation guide
 - Install the **.NET desktop development** workload

### Materials

| Material                                                                                  |                                               Time |
|:------------------------------------------------------------------------------------------|---------------------------------------------------:|
|[Project and Solution](https://docs.microsoft.com/en-us/visualstudio/ide/solutions-and-projects-in-visual-studio?view=vs-2019)| - |
|[.NET Framework](https://www.guru99.com/net-framework.html)| - |
|[C# Basics](https://www.youtube.com/watch?v=lisiwUZJXqQ&t=2062s) |until 45:06 |
|[Methods & Using Functions](https://www.youtube.com/watch?v=QwygwfqOHsI) | 17:07 |
|[Debugging in VisualStudio](https://www.youtube.com/watch?v=7ab4z9u7Q_I) | 16:15 |
|[Classes and Objects](https://www.youtube.com/watch?v=FCjoioi6xvM)|4:33|
|[Object Oriented Programming Basics](https://www.youtube.com/watch?v=0K2EsvAz5Pg)|8:08|
|[Fields](https://www.youtube.com/watch?v=jcHBfa36gz0)|3:44|
|[Constructor](https://www.youtube.com/watch?v=MyWBU6IKl5U)|6:19|
|[Static vs Non Static](https://www.youtube.com/watch?v=86ymhq54V5k)|13:33|
|[This keyword](https://www.youtube.com/watch?v=m8hRUP1WL28)|2:28|

## Material Review

### .NET

- What is a project?
- What is a solution?
- What is the .NET framework?

### Expressions & Control flow

- How can you get input from the user via command line?
- How do you get the total number of elements of an Array?
- How do you sort the elements of an Array?
- What is code duplication?
  - Why is code duplication undesirable?
  - How can you reduce code duplication?

### Encapsulation

- What is encapsulation?
    - How do you create a new type?
    - What's a field?
    - What's a method?
    - What are members?
- How do you create a new instance?
- Why do you need a constructor?
- When do you have to use the `this` keyword?

## Workshop

### User input (scanner)

```csharp
namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello user what is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("Hello, " + name);
            Console.WriteLine("How old are you? ");

            string age = Console.ReadLine();
            Console.WriteLine(age + " is a nice age");

            Console.ReadLine();

        }
    }
}

```

### Loops

```csharp
using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("while loop");
            int a = 0;
            while (a < 10)
            {
                Console.WriteLine(a++);
            }

            Console.WriteLine("\n\n do while loop:");
            int b = 0;
            do
            {
                Console.WriteLine(b++);
            } while (b < 10);

            Console.WriteLine("\n\n for loop:");
            for(int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }
    }
}

```

### Conditionals

```csharp
using System;

namespace GreenFox
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 13;

            if (a == 13)
            {
                // this block will run
                Console.WriteLine("Yaaay! The value of the \"a\" variable is 13");
            }

            if (a == 8)
            {
                // this block will NOT run
                Console.WriteLine("Yaaay! The value of the \"a\" variable is 8");
            }


            int b = 20;

            if (b < 10)
            {
                // this block will NOT run
                Console.WriteLine("Yaaay! The value of the \"b\" variable is lower than 10");
            }
            else
            {
                // this block will run
                Console.WriteLine("Yaaay! The value of the \"b\" variable is higher than 10");
            }


            int c = 15;

            if (c < 10)
            {
                // this block will NOT run
                Console.WriteLine("Yaaay! The value of the \"b\" variable is lower than 10");
            }
            else if (c < 20)
            {
                // this block will run
                Console.WriteLine("Yaaay! The value of the \"b\" variable is higher than 10 but less then 20");
            }
            else
            {
                // this block will NOT run
                Console.WriteLine("Yaaay! The value of the \"b\" variable is higher than 10");
            }


            bool thirsty = true;
            bool hungry = false;

            if (thirsty && hungry)
            {
                Console.WriteLine("Lunch time!");
            }
            else if (thirsty || hungry)
            {
                Console.WriteLine("Snack time!");
            }
            else
            {
                Console.WriteLine("No food for you, little fatty.");
            }

            Console.ReadLine();
        }
    }
}

```

### Object Orientation

```csharp
using System;

namespace GreenFox
{
    class Program
    {
        public class Human
        {
            public string Name;
            public int Age;
            public int IQ;

            public Human(string name, int age, int iq)
            {
                Name = name;
                Age = age;
                IQ = iq;
            }

            public bool IsSmart()
            {
                return IQ > 100;
            }

            public bool IsNameLess()
            {
                return Name == "unkown" || Name == "";
            }

            public void BeSmarter()
            {
                IQ += 20;
            }
        }

        static void Main(string[] args)
        {
            var human = new Human("John", 37, 95);

            Console.WriteLine("Is our human nameless? " + human.IsNameLess());
            Console.WriteLine("Our human is {0} and he is {1} old", human.Name, human.Age);
            Console.WriteLine("Is our human smart: " + human.IsSmart());

            human.BeSmarter();
            Console.WriteLine("Is our human smart now? " + human.IsSmart());

            Console.ReadLine();
        }
    }
}

```

#### Exercises: Control Flow

- [FavoriteNumber](../workshop/expressions-and-control-flow/favorite-number/FavoriteNumber.cs)
- [Swap](../workshop/expressions-and-control-flow/swap/Swap.cs)
- [Bmi](../workshop/expressions-and-control-flow/bmi/Bmi.cs)
- [SecondsInADay](../workshop/expressions-and-control-flow/seconds-in-a-day/SecondsInADay.cs)
- [AnimalsAndLegs](../workshop/expressions-and-control-flow/animals-and-legs/AnimalsAndLegs.cs)
- [AverageOfInput](../workshop/expressions-and-control-flow/average-of-input/AverageOfInput.cs)
- [ConditionalVariableMutation](../workshop/expressions-and-control-flow/conditional-variable-mutation/ConditionalVariableMutation.cs)
- [PrintEven](../workshop/expressions-and-control-flow/print-even/PrintEven.cs)
- [CountFromTo](../workshop/expressions-and-control-flow/count-from-to/CountFromTo.cs)
- [FizzBuzz](../workshop/expressions-and-control-flow/fizz-buzz/FizzBuzz.cs)
- [DrawTriangle](../workshop/expressions-and-control-flow/draw-triangle/DrawTriangle.cs)
- [DrawPyramid](../workshop/expressions-and-control-flow/draw-pyramid/DrawPyramid.cs)
- [DrawDiamond](../workshop/expressions-and-control-flow/draw-diamond/DrawDiamond.cs)
- [GuessTheNumber](../workshop/expressions-and-control-flow/guess-the-number/GuessTheNumber.cs)
- [ParametricAverage](../workshop/expressions-and-control-flow/parametric-average/ParametricAverage.cs)

#### Exercises: Strings

- [Simple Replace](../workshop/data-structures/simplereplace/SimpleReplace.cs)
- [Url Fixer](../workshop/data-structures/urlfixer/UrlFixer.cs)
- [Takes Longer](../workshop/data-structures/takeslonger/TakesLonger.cs)
- [Todo Print](../workshop/data-structures/todoprint/TodoPrint.cs)
- [Reverse](../workshop/data-structures/reverse/Reverse.cs)

### Arrays

```c#
using System;

namespace Example
{
    class Program
    {
        public static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 3, 8 };

            // Print the second element of the array
            Console.WriteLine(numbers[1]);

            // Print all the array elements
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            Console.ReadLine();
        }
    }
}

```

#### Exercises: Arrays

- [Double items](../workshop/arrays/double-items/DoubleItems.cs)
- [Colors](../workshop/arrays/colors/Colors.cs)
- [Append a](../workshop/arrays/append-a/AppendA.cs)
- [Swap elements](../workshop/arrays/swap-elements/SwapElements.cs)
- [Sum all elements](../workshop/arrays/sum-all/SumAll.cs)
- [Reverse list](../workshop/arrays/reverse/Reverse.cs)

### Functions

```csharp
using System;

namespace Example
{
    class Program
    {
        public static void GreetingFunction()
        {
            Console.WriteLine("hello");
        }

        public static void Main(string[] args)
        {
            GreetingFunction();
            Console.ReadLine();
        }
    }
}

```

#### Exercises: Functions

- [Summing](../workshop/functions/sum/Sum.cs)
- [Factorial](../workshop/functions/factorio/Factorio.cs)
- [Find part of an integer](../workshop/functions/subint/SubInt.cs)
- [Unique](../workshop/functions/unique/Unique.cs)
- [Anagram](../workshop/functions/anagram/README.md)
- [Palindrome builder](../workshop/functions/palindrome-builder/README.md)
- [Palindrome searcher](../workshop/functions/palindrome-searcher/README.md)
- [Sort that list](../workshop/functions/bubble/Bubble.cs)

#### Exercises: Object orientation

- [Post-it](../workshop/oo/post-it/cs.md)
- [BlogPost](../workshop/oo/blog-post/README.md)
- [Animal](../workshop/oo/animal/README.md)
- [Pokemon](../workshop/oo/pokemon/Pokemon.cs), [Main](../workshop/oo/pokemon/Program.cs)
- [Fleet of Things](../workshop/oo/fleet-of-things/FleetOfThings.cs), [Fleet](../workshop/oo/fleet-of-things/Fleet.cs), [Thing](../workshop/oo/fleet-of-things/Thing.cs)
- [Petrol Station](../workshop/oo/petrol-station/cs.md)
- [Blog](../workshop/oo/blog/README.md)
- [Pirates](../workshop/oo/pirates/cs.md)
