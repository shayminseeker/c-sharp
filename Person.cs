using System;
using System.Collections.Generic;

namespace ConsoleApp2;

public class Person
{
    public string Name { get; set; }
private static int _nextId;
    readonly int Id;
private int _age;
public int Age
    {
        get {return _age;} 
        set
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("Age cannot be negative.");
           
        }
    }

   

    public string Introduce()
    {
        return $"My name is {Name} and I'm {Age} years old";
    }

    // constructor
    public Person(string name, int age)
    {
        Name = name;
        _age = age;
        Id = _nextId;
        _nextId++;
        
    }
    public string HappyBirthday()
    {
        Age++;
        return $"Happy Birthday, Congrats on {Age} years of living!";
    }

    public static void GreetAll(List<Person> people)
    {
        foreach (var person in people)
        {
            Console.WriteLine(person.Introduce());
        }
    }

    public override string ToString()
    {
        return $"{Name}, {Age}";
    }

    public bool IsOlderThan(Person other)
    {
        if (other == null) throw new ArgumentNullException(nameof(other));
        return this.Age > other.Age;
    }

    public virtual bool Equals(object? obj)
    {
        return base.Equals(obj);
    }

     public Person Copy()
    {
        Person Pcopy = new Person(this.Name, this.Age);
        Pcopy.Person();
        return Pcopy;
    }


}
