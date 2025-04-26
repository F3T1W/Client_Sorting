using System.Collections.Generic;

namespace ClientSort;

internal static class Program
{
    private static void Main(string[] args)
    {
        var patient = new List<Patient>() {
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
