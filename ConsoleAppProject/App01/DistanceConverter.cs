using System;
using System.Security.Cryptography.X509Certificates;
using System.Transactions;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Derek version 0.1
    /// </author>
    public class DistanceConverter
    {
        private const int MILES_IN_FEET = 5280;

        private double miles;
        private double feet;

        public void Run()
        {
            PrintHeader();

            MilesToFeet();
            
            FeetToMiles();

            Console.ReadLine();
        }

        
        
        private void MilesToFeet()
        {
            PromptUser("miles", "feet");
            miles = InputDistance("Enter the number of miles: ");
            ConvertMilesToFeet();
            OutputFeet();
        }

        private void FeetToMiles()
        {
            PromptUser("feet", "miles");
            feet = InputDistance("Enter the number of feet: ");
            ConvertFeetToMiles();
            OutputMiles();
        }

        private void PrintHeader()
        {
           Console.WriteLine("\n=========================================================================================");
           Console.WriteLine("======== This consol app will allow you to convert between units of measurements ========");
           Console.WriteLine("========                             By Derick Omondi                            ========");
           Console.WriteLine("=========================================================================================\n");
           Console.ReadLine();    
        }

        private void PromptUser(string unit1, string unit2)
        {
            Console.WriteLine("You are converting from " + unit1 + " into " + unit2 + ".");
        }   

        private double InputDistance(String prompt)
        {
            Console.Write(prompt);
            String userInputNum = Console.ReadLine();
            return Convert.ToDouble(userInputNum);
        }

        
        private void ConvertMilesToFeet()
        {
            feet = miles * MILES_IN_FEET;
        }

        private void OutputFeet()
        {
            Console.WriteLine("Converted to feet: " + feet);
        }

        private void ConvertFeetToMiles()
        {
            miles = feet / MILES_IN_FEET;
        }

        private void OutputMiles()
        {
            Console.WriteLine("converted to miles: " + miles);
        }

    }
}
