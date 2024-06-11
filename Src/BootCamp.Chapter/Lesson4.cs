using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace BootCamp.Chapter
{
    internal class Lesson4
    {
            public static int getThenConvertInt(string message)
            {
            Console.WriteLine(message);
            var input = Console.ReadLine();
            int n;
            bool isNumber = int.TryParse(input, out _);
            if (!isNumber)
            {
                Console.WriteLine("\"" + input + "\"" + " is not a valid number.");
                return -1;
            }

            return int.Parse(input);
            }

            public static string getString(string message)
            {
                Console.WriteLine(message);
                var input = Console.ReadLine();
            if (String.IsNullOrEmpty(input))
            {
                Console.WriteLine($"{message} Name cannot be empty {input}");
                return "-";
            }
            return input;

            }

            public static float getStringConvertFloat(string message)
            {
                Console.WriteLine(message);
                var input = Console.ReadLine();
                bool isNumber = float.TryParse(input, out _);
                if (isNumber) {
                    return float.Parse(input);
                }
                else
                {
                    Console.WriteLine("\"" + input + "\"" + " is not a valid number.");
                    return -1;

                }
            }

            public static float calcBMI(float weight, float height)
            {

            if (weight <= 0 || height <= 0)
            {
                var reasons = "Failed calculating BMI. Reason:";
                if (weight <= 0) reasons += $"/nWeight cannot be equal or less than zero, but was {weight} ";
                if (height <= 0) reasons += $"/nHeight cannot be equal or less than zero, but was {height}" ;
                Console.WriteLine(reasons);
                return -1;
            }
                float BMI = ((float)(weight / (Math.Pow(height, 2))));
                return BMI;
            }
        }
    }

