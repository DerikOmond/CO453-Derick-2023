using System;
using System.Security.Cryptography.X509Certificates;

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

        private void PrintHeader()
        {
            Console.WriteLine("\n=========================================================================================");
            Console.WriteLine("======== This consol app will allow you to convert between units of measurements ========");
            Console.WriteLine("========                             By Derick Omondi                            ========");
            Console.WriteLine("=========================================================================================\n");
            Console.ReadLine();
        }
        
        private void MilesToFeet()
        {
            InputMiles();
            ConvertMilesToFeet();
            OutputFeet();
        }

        private void FeetToMiles()
        {
            InputFeet();
            ConvertFeetToMiles();
            OutputMiles();
        }

        private void InputMiles()
        {
            Console.Write("No. of miles: ");
            String userInputMiles = Console.ReadLine();
            miles = Convert.ToDouble(userInputMiles);
        }

        
        private void ConvertMilesToFeet()
        {
            feet = miles * MILES_IN_FEET;
        }

        private void OutputFeet()
        {
            Console.WriteLine("Converted to feet: " + feet);
        }

        private void InputFeet()
        {
            Console.Write("No. of feet: ");
            String userInputFeet = Console.ReadLine();
            feet = Convert.ToDouble(userInputFeet);
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
