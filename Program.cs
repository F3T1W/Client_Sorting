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
                new Patient("Alex", "Mitchelg", 21, "critical"),
                new Patient("Kate","Pupsvel", 18, "critical"),
                new Patient("Kateline","Pupsvel", 18, "critical"),
                new Patient("Georgy", "Robbinson", 42, "normal"),
                new Patient("LG", "Company", 120, "normal"),
                new Patient("Mikky", "Mouse", 30, "critical") };

                Patient.FindByName(patient);
                Patient.FindBySurname(patient);
                Patient.Critical(patient);
                Patient.LessThan(patient);
            }
        
    }
}
