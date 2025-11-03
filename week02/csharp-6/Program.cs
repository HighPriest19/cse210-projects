using System;

class Program
{
    static void Main()
    {
        // Create a new person object
        Person person1 = new Person();
        person1._givenName = "Joseph";
        person1._familyName = "Smith";
        person1.ShowWesternName();
        person1.ShowEasternName();

        Console.WriteLine();

        Person person2 = new Person();
        person2._givenName = "Emma";
        person2._familyName = "Smith";
        person2.ShowWesternName();
        person2.ShowEasternName();
    }
}

class Person
{
    public string _givenName;
    public string _familyName;

    public void ShowWesternName()
    {
        Console.WriteLine($"{_givenName} {_familyName}");
    }

    public void ShowEasternName()
    {
        Console.WriteLine($"{_familyName}, {_givenName}");
    }
}