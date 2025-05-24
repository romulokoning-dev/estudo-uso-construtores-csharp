using System;

class Person
{
    public string name;
    public int age;
    public string carreer;
    public Person(string Name, int Age, string Carreer)
    {
        name = Name;
        age = Age;
        carreer = Carreer;
    }

    public void Presentation()
    {
        Console.WriteLine($"Hello, my name is {name} im {age} years old and im {carreer}");
    }
}


class Program
{
    static void Main()
    {
       Person p1 = new Person("Maria",10, "student");
        p1.Presentation();
        Person p2 = new Person("Pedro",20, "Mainteiner");
        p2.Presentation();
       
    }
}
