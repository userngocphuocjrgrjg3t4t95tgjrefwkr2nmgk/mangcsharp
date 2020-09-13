﻿using System;

namespace doinhietdo
{
    class Program
    {
        public static double CelsiusToFahrenheit(double celsius)
        {
            double fahrenheit = (9.0 / 5) * celsius + 32;
            return fahrenheit;
        }

        public static double FahrenheitToCelsius(double fahrenheit) 
        {
            double celsius = (5.0 / 9) * (fahrenheit - 32);
            return celsius;
        } 


        static void Main(string[] args)
        {
            double fahrenheit;
            double celsius;
            int choice;

            do
            {
                Console.WriteLine("Menu.");
                Console.WriteLine("1. Fahrenheit to Celsius");
                Console.WriteLine("2. Celsius to Fahrenheit");
                Console.WriteLine("0. Exit");
                Console.WriteLine("Enter your choice: ");
                choice = Int32.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: 
                    break;
                    case 2: 
                    break;
                    case 0:
                        Environment.Exit(0);
                        break;
                }
            } while (choice != 0);

            Console.WriteLine("Enter fahrenheit: ");
            fahrenheit = Double.Parse(Console.ReadLine());
            Console.WriteLine("Fahrenheit to Celsius: " + FahrenheitToCelsius(fahrenheit));

            Console.WriteLine("Enter Celsius: ");
            celsius = Double.Parse(Console.ReadLine());
            Console.WriteLine("Celsius to Fahrenheit: " + CelsiusToFahrenheit(celsius));
        }

    }
}