// See https://aka.ms/new-console-template for more information
using ConsoleApp2;

Person p1 = new Person("John Doe", 12);
Person p2 = new Person("George Washington", 120);
Person p3 = new Person("Sasuke Uchiha", 18);
Person p4 = new Person("Lucas Norton", 17);
Person p5 = new Person("Jack Richardson", 77);
//
p1.Introduce();
p2.Introduce();
p3.Introduce();
p4.Introduce();
p5.Introduce();
// p5.Age = -2;
p4.HappyBirthday();


p1.ToString();
p2.IsOlderThan(p2);
//OOP Assignment
Student s1 = new Student("Alice", 20);
Student s2 = new Student("Bob", 22);
Student s3 = new Student("Charlie", 25);
//student 1
s1.AddGrade(85.5);
s1.AddGrade(50.2);
s1.AddGrade(100.0);
//student 2
s2.AddGrade(100.0);
s2.AddGrade(63.4);
s2.AddGrade(100.0);
//student 3
s3.AddGrade(72.3);
s3.AddGrade(88.8);
s3.AddGrade(91.5);
s1.Copy();
s2.Introduce();

List<Person> people = new List<Person>();
{
    people.Add(p1);
    people.Add(p2);
    people.Add(p3);
    people.Add(p4);
    people.Add(p5);
    people.Add(s1);
    people.Add(s2);
    people.Add(s3);
    

}
p1.Equals(p2);

Person.GreetAll(people);
