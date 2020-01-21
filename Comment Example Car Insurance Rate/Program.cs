using System;
using static System.Console;

namespace Comment_Example_Car_Insurance_Rate
{
    /// <summary>
    /// The main class, contains the methods that decide the Auto insurance rate base on the users vehicle.
    /// It uses the console to collect information about the type, age, and color to decide the rate.
    /// 
    /// Developed by Ben G. as an example about commenting
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            double totalRate = 50; //Total Rate will be give at the end
            WriteLine("Welcome to GC command line insurance adjustmant!");

            totalRate += AutoType();
            totalRate += AutoColor();

            //TODO: get user year of manufacture
            totalRate += AutoYear(0);

            WriteLine("Your monthly rate will be {0:C}", totalRate);
        }

        /// <summary>
        /// Automobile Input
        /// Takes the users automobile type and caluculate how this changes the users insurance rate
        /// </summary>
        /// <returns>A double that is an addition to the insurance rate. Expected values are positives.</returns>
        public static double AutoType()
        {
            //Examples of using a comment to add something to the Task list
            //TODO: write AutoType method 
            //HACK: Try to put some code here

            string type;
            double rate = 0; // insurance rate adjustment 
            bool loop = true; //flag that keeps loop running until valid input is given
            
            /*
             * Repeats if there is invalid input given
             */
            while(loop)
            {
                WriteLine("Enter vehicle type (Car, Van, or Truck");
                type = ReadLine();
                type = type.ToLower();//accounts for capitliaztion
                if (type == "car")
                {
                    rate = 25;
                    loop = false; //stops loop
                } else if (type == "truck")
                {
                    rate = 41.3;
                    loop = false; //stops loop
                } else if (type == "van")
                {
                    rate = 33.4;
                    loop = false; //stops loop
                }
                else
                {
                    WriteLine("invalid input");
                }

            }
            



            return 0; //HACK: remove placeholder value
        }

        /// <summary>
        /// Automobile Color Input
        /// Takes the users automobile color using the console gives the rate adjustment based on that.
        /// </summary>
        /// <returns>a double that represents a change to the insurance rate. Rate will only change if red ($65.37) or black($25.60) for the color was entered</returns>
        public static double AutoColor()
        {
            //TODO: complete Auto Color
            return 0; //HACK: Remove placeholder
        }

        /// <summary>
        /// Automobile Year
        /// Takes the users year of automobile manufacture from the console and gives the rate adjustment based on that.
        /// </summary>
        /// <param name="year"> 4 diget int that represents the year of manufacture</param>
        /// <returns>a double that is the rate adjusment based on the year, +$20 per a year old</returns>
        public static double AutoYear(int year)
        {
            //TODO: complete Auto Year
            return 0; //HACK: Remove placeholder
        }


    }
}
