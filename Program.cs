namespace CshrpAssignment1
{
    using System;

    public class Program
    {
        static void Main()
        {


            Console.WriteLine("Enter patient information:");
            Console.WriteLine("First Name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Last Name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Weight (in KG):");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Height (in CM):");
            double height = Convert.ToDouble(Console.ReadLine());


            Patient patient = new Patient(firstName, lastName, weight, height);
            patient.PatientDetails();

        }
    }

}