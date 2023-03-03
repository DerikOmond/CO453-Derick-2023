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
            ConvertUnitValues("miles", "feet");
            OutputDistance(miles, "miles", feet, "feet");
        }

        private void FeetToMiles()
        {
            PromptUser("feet", "miles");
            feet = InputDistance("Enter the number of feet: ");
            ConvertUnitValues("feet", "miles");
            OutputDistance(feet, "feet", miles, "miles");
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
        
        private void ConvertUnitValues(String unit1, String unit2)
        {
            if(unit1.Equals("miles") && unit2.Equals("feet")
            {
                feet = miles * MILES_IN_FEET;
            }
            
            if(unit1.Equals("feet") && unit2.Equals("miles"))
            {
                miles = feet / MILES_IN_FEET;
            }
            
        }

        private void OutputDistance(double originalDistanceValue, string originalUnit, double newDistanceValue, string newUnit)
        {
            Console.WriteLine($"{originalDistanceValue} {originalUnit} is equivelent to {newDistanceValue} {newUnit}\n"$);
        }
    }
}
