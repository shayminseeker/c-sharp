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
p5.Age = -2;
p4.HappyBirthday();
List<Person> people = new List<Person>();
{
    people.Add(p1);
    people.Add(p2);
    people.Add(p3);
    people.Add(p4);
    people.Add(p5);

}
Person.GreetAll(people);
p1.ToString();
p2.IsOlderThan(p2);
