using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DRUSdomaci
{
    class Program
    {

        static void Main(string[] args)
        {

            string userChoice = "T";
           do
           {
            Console.WriteLine("Convert from Celsious to Fhrenheit!");
            Console.WriteLine("To convert  Fhrenheit to Celsious  enter A");
            Console.WriteLine("To convert Celsious to Fhrenheit enter E");
            Console.WriteLine("To exit enter E");
            userChoice = Console.ReadLine();
            
            
                if (userChoice == "A")
                {

                    Console.WriteLine("Please enter Fhrenheit degrees you want to convert . ");
                    string userInput = Console.ReadLine();

                    TempConverter cel = new TempConverter(userInput);
                    cel.FahrenheitToCelsius(userInput);
                   //5 Console.ReadLine();
                }

                else if (userChoice == "B")
                {
                    Console.WriteLine("Please enter Celsious degrees you want to convert . ");
                    string userInput = Console.ReadLine();

                    TempConverter fhr = new TempConverter(userInput);
                    fhr.CelsiusToFahrenheit(userInput);
                   // Console.ReadLine();
                }
                else if (userChoice == "E")
                {

                }

                else
                {
                    Console.WriteLine("Please enter A or B or E.");
                    Console.ReadKey();
                }
            } while (userChoice != "E");

            //********************
        }  
    
    }

}

