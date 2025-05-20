using System;

namespace HospitalConsoleApp
{
    class Program
    {
        static PatientManager patientManager = new PatientManager();

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
                    case 1: patientManager.AddPatient(); break;
                    case 2: patientManager.ViewPatients(); break;
                    case 3: patientManager.UpdatePatient(); break;
                    case 4: patientManager.DeletePatient(); break;
                    case 0: Console.WriteLine("Goodbye!"); break;
                    default: Console.WriteLine("Invalid choice!"); break;
                }

            } while (choice != 0);
        }
    }
}
