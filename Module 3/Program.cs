using System;

class Octopus
{
    string name;
    public int Age = 24;
    static readonly int legs = 8;
    static readonly int eyes = 1;
    public readonly string Name;
    public readonly int Legs = 8;

    public Octopus(string name)
    {
        Name = name;
    }
}

class Program
{
    static void Main()
    {
        var o = new Octopus("Larry");
        Console.WriteLine("Age: " + o.Age);
        Console.WriteLine("Name: " + o.Name);
        Console.ReadLine();
    }
}
