using System;

namespace ValueAndReferenceTypeConsoleApp;
class Program
{
    static void Main(string[] args)
    {
        int theAnswer = 42;
        Console.WriteLine($"The answer before adding 1 and 2: {theAnswer}");
        AddOne(theAnswer);
        AddTwo(theAnswer);
        Console.WriteLine($"The answer after adding 1 and 2: {theAnswer}");
        Console.WriteLine();

        string fruit = "Apple";
        Console.WriteLine($"The fruit before ChangeFruit: {fruit}");
        ChangeFruit(fruit);
        Console.WriteLine($"The fruit after ChangeFruit: {fruit}");
        Console.WriteLine();

        Person janice = new Person("Janice");
        Console.WriteLine($"The person before ChangePerson: {janice.Name}");
        ChangePerson(janice);
        Console.WriteLine($"The person after ChangePerson: {janice.Name}");
        Console.WriteLine();

        Console.WriteLine($"The person before ChangeName: {janice.Name}");
        ChangeName(janice);
        Console.WriteLine($"The person after ChangeName: {janice.Name}");
    }

    private static void AddOne(int theAnswer)
    {
        theAnswer = theAnswer + 1;
        Console.WriteLine($"The answer inside addOne, after the operation: {theAnswer}");
    }
    private static void AddTwo(int theAnswer)
    {
        theAnswer = theAnswer + 2;
        Console.WriteLine($"The answer inside addTwo, after the operation: {theAnswer}");
    }
    private static void ChangeFruit( string fruit)
    {
        fruit = "Orange";
        Console.WriteLine($"The fruit inside ChangeFruit after the operation: {fruit}");
    }

    private static void ChangePerson(Person person)
    {
        person = new Person("Bob 'Bodysnatcher' Bobberson");
        Console.WriteLine($"The person inside ChangePerson after the operation: {person.Name}");
    }

    private static void ChangeName(Person person)
    {
        person.Name = "John";
        Console.WriteLine($"The person's name inside ChangeName after the operation: {person.Name}");
    }
}