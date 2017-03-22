using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DRUSdomaci
{
    
    class TempConverter
    {
        double valD; /// korisceno u TryParse
        int valInt;

        public TempConverter(){}

        public string userInput = Console.ReadLine();
        public TempConverter(string userInput)
        {
            this.userInput = userInput;
        }


        //conversion from Fahrenheit to Celsious -- Deduct 32, then multiply by 5, then divide by 9
        public double FahrenheitToCelsius(string userInput) 
        {
           
           double celsius = 0;
           if(double.TryParse(userInput, out valD) || int.TryParse(userInput, out valInt))
           {
                celsius = (Convert.ToDouble(userInput) - 32) * 5 / 9;
                Console.WriteLine("Temperature in Celsius is: " + celsius + " degree!");
           }
           
           else
           {
               Console.WriteLine("Please enter a number!");
           }
           return celsius;
           
        }

        //conversion from Celsious to Fahrenheit-- T(°F) = T(°C) × 9/5 + 32
       public double CelsiusToFahrenheit(string userInput)
       {
          
           double fahrenheit = 0;
           if(double.TryParse(userInput, out valD) || int.TryParse(userInput, out valInt))
           {
               Console.WriteLine(userInput);
               fahrenheit = Convert.ToDouble(userInput) * 1.8 + 32;
               Console.WriteLine("Temperature in Fahrenheit is: " + fahrenheit + " degree!");
           }
           
           else
           {
               Console.WriteLine("Please enter a number!");
           }

           return fahrenheit;
       }


      
    }


}
           
           