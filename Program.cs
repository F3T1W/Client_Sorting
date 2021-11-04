using System;
using System.Collections.Generic;
using System.Linq;

namespace ClientSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Patient> patient = new List<Patient>() {
                new Patient("Alex", "Mitchel", 21, "critical"),
                new Patient("Kate","Pupsvel", 18, "critical"),
                new Patient("Georgy", "Robbinson", 42, "normal"),
                new Patient("LG", "Company", 120, "normal"),
                new Patient("Mikky", "Mouse", 30, "critical")
            };

            FindByName(patient);
            FindBySurname(patient);
            Critical(patient);
            LessThan(patient);
        }
        
        public class Patient
        {
            public String Name;
            public String Surname;
            public int age;
            public String status;

            public Patient(string Name, string Surname, int age, string status)
            {
                this.Name = Name;
                this.Surname = Surname;
                this.age = age;
                this.status = status;
            }

            

            public Patient() 
            {

            }
            
        }

        static void FindByName(List<Patient> patient)
        {
            Console.Write("Enter Name: ");
            var input = Console.ReadLine();
            var result = patient.FirstOrDefault(x => x.Name == input);
            Console.WriteLine($"{result.Name} {result.Surname}");
        }

        static void FindBySurname(List<Patient> patient)
        {
            Console.Write("Enter Surname: ");
            var input = Console.ReadLine();
            var result = patient.FirstOrDefault(x => x.Surname == input);
            Console.WriteLine($"{result.Name} {result.Surname}");
        }

        static void Critical(List<Patient> patient)
        {
            Console.Write("Enter Status: ");
            var input = Console.ReadLine();
            if (input == "critical" || input == "normal")
            {
                foreach (var i in patient)
                {
                    if (i.status == input)
                    {
                        Console.WriteLine($"{i.Name} {i.Surname}");
                    }

                }
            }
        }

        static void LessThan(List<Patient> patient)
        {
            Console.Write("Enter Age: ");
            var input = Console.ReadLine();
            int a = Convert.ToInt32(input);

            foreach (var i in patient)
                {
                    if (i.age < a)
                    {
                        Console.WriteLine($"{i.Name} {i.Surname}");
                    }

                }                                                                                                   
        }
    }

    

    
}
