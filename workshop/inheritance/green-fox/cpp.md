# Green Fox inheritance exercise

## Person

Create a `Person` class with the following members:
 -  `name`: the name of the person
 -  `age`: the age of the person (whole number)
 -  `gender`: the gender of the person (male / female)

And the following member functions:
 -  `introduce()`: prints out "Hi, I'm `name`, a `age` year old `gender`."
 -  `getGoal()`: prints out "My goal is: Live for the moment!"

And the following constructors:
 -  `Person(name, age, gender)`
 -  `Person()`: sets `name` to Jane Doe, `age` to 30, `gender` to female

## Student

Create a `Student` class that has the same members and functions as the `Person` class, and has the following additional
 -  members:
     -  `previousOrganization`: the name of the student’s previous company / school
     -  `skippedDays`: the number of days skipped from the course
 -  functions:
     -  `getGoal()`: prints out "My goal is: Be a junior software developer."
     -  `introduce()`: "Hi, I'm `name`, a `age` year old `gender` from `previousOrganization` who skipped `skippedDays` days from the course already."
     -  `skipDays(numberOfDays)`: increases `skippedDays` by `numberOfDays`

The `Student` class has the following constructors:
 -  `Student(name, age, gender, previousOrganization)`: beside the given parameters, it sets `skippedDays` to 0
 -  `Student()`: sets `name` to Jane Doe, `age` to 30, `gender` to female, `previousOrganization` to The School of Life, `skippedDays` to 0

## Mentor

Create a `Mentor` class that has the same members and functions as the `Person` class, and has the following additional
 -  members:
     -  `level`: the level of the mentor (junior / intermediate / senior)
 -  functions:
     -  `getGoal()`: prints out "My goal is: Educate brilliant junior software developers."
     -  `introduce()`: "Hi, I'm `name`, a `age` year old `gender` `level` mentor."

The `Mentor` class has the following constructors:
 -  `Mentor(name, age, gender, level)`
 -  `Mentor()`: sets `name` to Jane Doe, `age` to 30, `gender` to female, `level` to intermediate

## Sponsor

Create a `Sponsor` class that has the same members and functions as the `Person` class, and has the following additional
 -  members:
     -  `company`: name of the company
     -  `hiredStudents`: number of students hired
 -  functions:
     -  `introduce()`: "Hi, I'm `name`, a `age` year old `gender` who represents `company` and hired `hiredStudents` students so far."
     -  `hire()`: increase `hiredStudents` by 1
     -  `getGoal()`: prints out "My goal is: Hire brilliant junior software developers."

The `Sponsor` class has the following constructors:
 -  `Sponsor(name, age, gender, company)`: beside the given parameters, it sets `hiredStudents` to 0
 -  `Sponsor()`: sets `name` to Jane Doe, `age` to 30, `gender` to female, `company` to Google and `hiredStudents` to 0

## Cohort

Create a `Cohort` class that has the following
 -  members:
     -  `name`: the name of the cohort
     -  `students`: a vector of `Student`s
     -  `mentors`: a vector of `Mentor`s
 -  functions:
     -  `addStudent(Student*)`: adds the given `Student` to `students` vector
     -  `addMentor(Mentor*)`: adds the given `Mentor` to `mentors` vector
     -  `info()`: prints out "The `name` cohort has `students.size()` students and `mentors.size()` mentors."

The `Cohort` class has the following constructors:
 -  `Cohort(name)`: beside the given parameter, it sets `students` and `mentors` as empty lists

## Test input

```c++
int main()
{
    std::vector<Person*> people;

    Person mark("Mark", 46, Gender::MALE);
    people.push_back(&mark);
    Person jane;
    people.push_back(&jane);
    Student john("John Doe", 20, Gender::MALE, "BME");
    people.push_back(&john);
    Student student;
    people.push_back(&student);
    Mentor gandhi("Gandhi", 148, Gender::MALE, Level::SENIOR);
    people.push_back(&gandhi);
    Mentor mentor;
    people.push_back(&mentor);
    Sponsor sponsor;
    people.push_back(&sponsor);
    Sponsor elon("Elon Musk", 46, Gender::MALE, "SpaceX");
    people.push_back(&elon);

    student.skipDays(3);

    for (int i = 0; i < 5; i++) {
        elon.hire();
    }

    for (int i = 0; i < 3; i++) {
        sponsor.hire();
    }

    for(Person* person : people) {
        person->introduce();
        person->getGoal();
    }

    Cohort awesome = Cohort("AWESOME");
    awesome.addStudent(&student);
    awesome.addStudent(&john);
    awesome.addMentor(&mentor);
    awesome.addMentor(&gandhi);
    awesome.info();

    return 0;
}
```

## Test output

```
Hi, I'm Mark, a 46 year old male.
My goal is: Live for the moment.
Hi, I'm Jane Doe, a 30 year old female.
My goal is: Live for the moment.
Hi, I'm John Doe, a 20 year old male from BME who skipped 0 days from the course already.
My goal is: Be a junior software developer.
Hi, I'm Jane Doe, a 30 year old female from The School of Life who skipped 3 days from the course already.
My goal is: Be a junior software developer.
Hi, I'm Gandhi, a 148 year old male senior mentor.
My goal is: Educate brilliant junior software developers.
Hi, I'm Jane Doe, a 30 year old female intermediate mentor.
My goal is: Educate brilliant junior software developers.
Hi, I'm Jane Doe, a 30 year old female who represents Google and hired 3 students so far.
My goal is: Hire brilliant junior software developers.
Hi, I'm Elon Musk, a 46 year old male who represents SpaceX and hired 5 students so far.
My goal is: Hire brilliant junior software developers.
The AWESOME cohort has 2 students and 2 mentors.
```
