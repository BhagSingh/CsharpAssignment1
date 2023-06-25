using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CshrpAssignment1

{

    // Public Class Patient 
    public class Patient
    {


        // Get Set Method 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Weight { get; set; } // in KG
        public double Height { get; set; } // in Centimeters



        public Patient(string firstName, string lastName, double weight, double height)
        {
            FirstName = firstName;
            LastName = lastName;
            Weight = weight;
            Height = height;

        }
        //  Method to Calculate Blood Presssure
        public string CalBP(int systolic, int diastolic)
        // In this method we are using If else statements to calculate Blood Pressure.
        {
            if (systolic >= 120 && systolic <= 129 && diastolic < 80)
                return "ELEVATED";
            else if (systolic >= 130 && systolic <= 139 || diastolic >= 80 && diastolic <= 89)
                return "HIGH BLOOD PRESSURE (HYPERTENSION) STAGE 1";
            else if (systolic >= 140 && systolic <= 180 || diastolic >= 90 && diastolic <= 120)
                return "HIGH BLOOD PRESSURE (HYPERTENSION) STAGE 2";
            else if (systolic > 180 || diastolic > 120)
                return "HYPERTENSIVE CRISIS (consult your doctor immediately)";
            else
                return "NORMAL";
        }
        // Method to calculate Body Mass Index 
        public double CalBMI()
        {
            double heightInM = Height / 100;
            return Weight / (heightInM * heightInM);
        }

        public void PatientDetails()
        {
            Console.WriteLine("Patient Deatails:");
            Console.WriteLine("Patient's Full Name : " + FirstName + " " + LastName);
            Console.WriteLine("Weight(KG): " + Weight + " KG");
            Console.WriteLine("Height(CM): " + Height + " CM");
            Console.WriteLine("Test Results");
            Console.WriteLine("Patient's Blood Pressure: " + CalBP(120, 80));
            Console.WriteLine("Body Mass Index(BMI): " + CalBMI());
            Console.WriteLine("BMI Status: " + GetBMIStatus());

        }


        //Overweight => If the BMI is 25.0 or more
        //Normal(In the healthy range) => If the BMI is between 18.5 and 24.9 
        //Underweight => otherwise(if not overweight and not normal)
        private string GetBMIStatus()
        {
            double bmi = CalBMI();
            if (bmi >= 25.0)
                return "Overweight";
            else if (bmi >= 18.5 && bmi <= 24.9)
                return "Normal (In the healthy range)";
            else
                return "Underweight";
        }
    }
}
