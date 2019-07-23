# Object Oriented Programming

## Materials & Resources

### Materials

| Material                                                                                                                                                                  |                               Time |
| :------------------------------------------------------------------------------------------------------------------------------------------------------------------------ | ---------------------------------: |
| [Inheritance, What? 'n Why?](https://www.youtube.com/watch?v=18f41HX2gHk)                                                                                                 |                               5:28 |
| [Inheritance Example with Cats 'n Dogs](https://www.youtube.com/watch?v=EiBCF7rYRtI)                                                                                      |                              14:07 |
| [Properties](https://www.youtube.com/watch?v=7jD_T04XfpE)                                                                                                                 |                              10:51 |
| [Encapsulation](https://www.youtube.com/watch?v=6Ez3eNGZnCk)                                                                                                              |                              12:53 |
| [Overriding](https://www.youtube.com/watch?v=yGQxNb077bA)                                                                                                                 |                               8:38 |
| [Access modifiers](https://www.youtube.com/watch?v=-pcbDvUh4e0)                                                                                                           |                               2:57 |
| [Using Properties](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/using-properties)                                                 |                         ~8min read |
| [Getting started with WinForms](https://www.guru99.com/c-sharp-windows-forms-application.html)                                                                            | Till "Tree and PictureBox control" |
| [Calculator with WinForms](https://www.youtube.com/watch?v=W6vJ_c9Mt6A&t=299s)                                                                                            |                              40:00 |
| [Double buffering](https://docs.microsoft.com/en-us/dotnet/framework/winforms/advanced/double-buffered-graphics)                                                          |                        ~10min read |
| [Using double buffering](https://docs.microsoft.com/en-us/dotnet/framework/winforms/advanced/how-to-reduce-graphics-flicker-with-double-buffering-for-forms-and-controls) |                         ~5min read |
| [Events overview](https://docs.microsoft.com/en-us/dotnet/framework/winforms/events-overview-windows-forms)                                                               |                         ~5min read |
| [Handling and raising events](https://docs.microsoft.com/en-us/dotnet/standard/events/index)                                                                              |     Till "Raising multiple events" |

## Material Review

### C# specific features

- What are static members?
- What is a namespace and why are we using them?
- What are generic methods?
- What are the most useful generic collections?

### Inheritance

- What is inheritance?
  - What's the difference between the 'is-a' and 'has-a' relationship?
  - Why is inheritance useful?
  - What is the usage of the `base` keyword?
- What are the access modifiers and what are the default accessibility levels?
- Why do we need properties and what are auto properties?
- When do you need to use the `override` keyword?
- How to safely cast a variable from one type to another?
- What's the `object` type?

### WinForms

- What are WinForms?
- What's a Form?
- How to create a new window?
- What are controls?
  - What are the most commonly used controls?
- What is a delegate?
- What is an event?
- What is event handling?

## Workshop

### Example of inheritance

```csharp
public class Person
{
    private string name;
    private int age;

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }
}

public class Student : Person
{
    private string classroom;

    public Student(string name, int age, string classroom) : base(name, age)
    {
        this.classroom = classroom;
    }
}

```

### Example of properties

```csharp
public class Person
{
    private string name;

    // regular property
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    // auto property, note that you don't have to add `private int age`,
    // it's created automatically in the background
    public int Age { get; set; }

    public Person(string name, int age)
    {
        this.name = name;
        this.Age = age;
    }
}

```

### Exercises: Inheritance

- [Green Fox Organization](../workshop/inheritance/green-fox/cs.md)
- [Gardener](../workshop/inheritance/garden-app/README.md)

### Exercises: WinForms

- [License Plate](../workshop/winforms/licence-plate-validator/cs.md)
- [Guessing game](../workshop/winforms/guessing-game/cs.md)
- [Todo Application](../workshop/winforms/todo-app/cs.md)
