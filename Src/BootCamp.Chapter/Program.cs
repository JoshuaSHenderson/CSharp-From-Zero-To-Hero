using System;
using System.Collections.Generic;
using System.IO;
using Console = System.Console;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var weight = Lesson4.getThenConvertInt("Enter Weight");
            var height = Lesson4.getThenConvertInt("Enter Height");
            var name = Lesson4.getString("Enter Name");

            var BMI = Lesson4.calcBMI(weight, height);



            //Console.WriteLine("Please enter an First Name: ");
            //var firstName = Console.ReadLine();
            //Console.WriteLine($"Please enter {firstName}'s Last Name: ");
            //var lastName = Console.ReadLine();
            //var fullName = firstName + " " + lastName;
            //Console.WriteLine($"Please enter {fullName}'s age: ");
            //var age = Console.ReadLine();
            //Console.WriteLine($"Please enter {fullName}'s Weight (kg): ");
            //double weight = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"Please enter {fullName}'s Height (cm): ");
            //double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{name}'s ,weight is {weight} height is {height} cm BMI is {BMI}");

            //Console.WriteLine($"{fullName}'s BMI is {BMI.GetBMI((height / 100), weight)}");
        }



        // BMIformula = weight (lb) / [height (in)]2 x 703
        public class BMI
        {
            public static double GetBMI(double height, double weight)
            {
                return (weight / (Math.Pow(height, 2)));
            }
        }


    }
}