using System;
using System.Collections.Generic;

namespace HospitalConsoleApp
{
    public class PatientManager
    {
        private List<Patient> patients = new List<Patient>();

        public void AddPatient()
        {
            Console.Write("Enter Patient Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            patients.Add(new Patient(name, age));
            Console.WriteLine("Patient added successfully.");
        }

        public void ViewPatients()
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

        public void UpdatePatient()
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

        public void DeletePatient()
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
}
