using System;
using System.Collections.Generic;

namespace HospitalConsoleApp
{
    class Program
    {
        static List<Patient> patients = new List<Patient>();

        static void Main(string[] args)
        {
            int choice;

            do
            {
                Console.WriteLine("\n--- Hospital Management ---");
                Console.WriteLine("1. Add Patient");
                Console.WriteLine("2. View Patients");
                Console.WriteLine("3. Update Patient");
                Console.WriteLine("4. Delete Patient");
                Console.WriteLine("0. Exit");
                Console.Write("Enter choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1: AddPatient(); break;
                    case 2: ViewPatients(); break;
                    case 3: UpdatePatient(); break;
                    case 4: DeletePatient(); break;
                    case 0: Console.WriteLine("Goodbye!"); break;
                    default: Console.WriteLine("Invalid choice!"); break;
                }

            } while (choice != 0);
        }

        static void AddPatient()
        {
            Console.Write("Enter Patient Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            patients.Add(new Patient(name, age));
            Console.WriteLine("Patient added successfully.");
        }

        static void ViewPatients()
        {
            if (patients.Count == 0)
            {
                Console.WriteLine("No patients found.");
                return;
            }

            Console.WriteLine("\n--- Patient List ---");
            for (int i = 0; i < patients.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {patients[i].Name}, Age: {patients[i].Age}");
            }
        }

        static void UpdatePatient()
        {
            ViewPatients();

            Console.Write("Enter patient number to update: ");
            int index = Convert.ToInt32(Console.ReadLine()) - 1;

            if (index < 0 || index >= patients.Count)
            {
                Console.WriteLine("Invalid index!");
                return;
            }

            Console.Write("Enter new name: ");
            patients[index].Name = Console.ReadLine();

            Console.Write("Enter new age: ");
            patients[index].Age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Patient updated.");
        }

        static void DeletePatient()
        {
            ViewPatients();

            Console.Write("Enter patient number to delete: ");
            int index = Convert.ToInt32(Console.ReadLine()) - 1;

            if (index < 0 || index >= patients.Count)
            {
                Console.WriteLine("Invalid index!");
                return;
            }

            patients.RemoveAt(index);
            Console.WriteLine("Patient removed.");
        }
    }

    class Patient
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Patient(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
