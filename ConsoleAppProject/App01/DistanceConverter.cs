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
        public void Run()
        {
            PrintHeader();
        }

        public void PrintHeader()
        {
            Console.WriteLine("=========================================================================================");
            Console.WriteLine("=========This consol app will allow you to convert between units of measurements=========");
            Console.WriteLine("=========================================================================================");
            Console.ReadLine();
        }
    }
}
