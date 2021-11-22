
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    namespace ClientSort
    {
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

            public static void FindByName(List<Patient> patient)
            {
                Console.Write("Enter Name: ");
                var input = Console.ReadLine();
                foreach (var i in patient)
                {
                    if (i.Name == input)
                    {
                        Console.WriteLine(i.Name + " " + i.Surname);
                    }
                }
            }
        
            public static void FindBySurname(List<Patient> patient)
            {
                Console.Write("Enter Name: ");
                var input = Console.ReadLine();
                foreach (var i in patient)
                {
                    if (i.Surname == input)
                    {
                        Console.WriteLine(i.Name + " " + i.Surname);
                    }
                }
            }

            public static void Critical(List<Patient> patient)
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

            public static void LessThan(List<Patient> patient)
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






