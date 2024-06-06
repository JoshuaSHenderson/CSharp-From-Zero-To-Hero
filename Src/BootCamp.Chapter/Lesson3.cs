using System;
using System.Collections.Generic;
using System.Text;

namespace BootCamp.Chapter
{
    internal class Lesson3
    {
            public static int getThenConvertInt(string message)
            {
            Console.WriteLine(message);
            var input = Console.ReadLine();
                return int.Parse(input);
            }

            public static string getString(string message)
            {
                Console.WriteLine(message);
                var input = Console.ReadLine();
                return input;

            }

            public static float getStringConvertFloat(string message)
            {
            Console.WriteLine(message);
            var input = Console.ReadLine();
                return float.Parse(input);
            }

            public static float calcBMI(float weight, float height)
            {
                float BMI = ((float)(weight / (Math.Pow(height, 2))));
                return BMI;
            }
        }
    }

