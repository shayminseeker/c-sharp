using System.Runtime.CompilerServices;

namespace ConsoleApp2;

public class Person
{
    public string Name {get; set;}
    public int Age
    {
        get { return Age; }
        set
        {
            if(Age < 0)
            {
                throw new ArgumentOutOfRangeException("Age cannot be negative.");
            }
        }
    }
    public bool IsAdult {
        get
        {
            if(Age >= 18)
            {
                return true;
            }
        }    
        
    }


public string Introduce()
    {
        return Console.WriteLine("My name is elmo and im 3 years old");
    }
//constructor
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
        
    }

    public string HappyBirthday()
    {
        Age++;
        return Console.WriteLine($"Happy Birthday, Congrats on {Age} years of living!");

    }

    static void GreetAll(List<Person> people)
    {
        foreach(string people in Person)
        {
            Introduce(people);
        }

    }

    public override string ToString()
    {
        return Console.WriteLine($"{Name}, {Age}");
    }

    public bool IsOlderThan(Person other)
    {
        if(Person < other)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
