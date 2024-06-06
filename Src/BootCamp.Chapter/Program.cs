using System;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter an First Name: ");
            var firstName = Console.ReadLine();
            Console.WriteLine($"Please enter {firstName}'s Last Name: ");
            var lastName = Console.ReadLine();
            var fullName = firstName + " " + lastName;
            Console.WriteLine($"Please enter {fullName}'s age: ");
            var age = Console.ReadLine();
            Console.WriteLine($"Please enter {fullName}'s Weight (kg): ");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Please enter {fullName}'s Height (cm): ");
            double height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"{fullName}'s is {age} years old, his weight is {weight} and his height is {height} cm");

            Console.WriteLine($"{fullName}'s BMI is {BMI.GetBMI((height / 100), weight)}");
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