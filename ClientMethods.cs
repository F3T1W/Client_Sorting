using System;
using System.Collections.Generic;
using System.Linq;

namespace ClientSort;

public class Patient(string name, string surname, int age, string status)
{
    private readonly string _name = name;
    private readonly string _surname = surname;
    private readonly int _age = age;
    private readonly string _status = status;

    public static void FindByName(List<Patient> patient)
    {
        Console.Write("Enter Name: ");
        string input = Console.ReadLine();
        foreach (Patient i in patient.Where(i => i._name == input))
        {
            Console.WriteLine(i._name + " " + i._surname);
        }
    }
    
    public static void FindBySurname(List<Patient> patient)
    {
        Console.Write("Enter Name: ");
        string input = Console.ReadLine();
        foreach (Patient i in patient.Where(i => i._surname == input))
        {
            Console.WriteLine(i._name + " " + i._surname);
        }
    }

    public static void Critical(List<Patient> patient)
    {
        Console.Write("Enter Status: ");
        string input = Console.ReadLine();
        if (input != "critical" && input != "normal")
        {
            return;
        }

        foreach (Patient i in patient.Where(i => i._status == input))
        {
            Console.WriteLine($"{i._name} {i._surname}");
        }
    }

    public static void LessThan(List<Patient> patient)
    {
        Console.Write("Enter Age: ");
        string input = Console.ReadLine();
        int a = Convert.ToInt32(input);

        foreach (Patient i in patient.Where(i => i._age < a))
        {
            Console.WriteLine($"{i._name} {i._surname}");
        }
    }
}
