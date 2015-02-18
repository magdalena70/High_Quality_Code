﻿using System;

namespace Methods
{
    class Methods
    {
        /// <summary>
        /// Method calculates triangle's area
        /// </summary>
        /// <param name="a">First side of triangle</param>
        /// <param name="b">Second side of triangle</param>
        /// <param name="c">Third side of triangle</param>
        /// <returns>Returns double area</returns>
        static double CalcTriangleArea(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Sides should be positive.");
            }

            if (a >= c + b ||
                b >= c + a ||
                c >= a + b)
            {
                throw new ArithmeticException("Invalid triangle.");
            }
            double s = (a + b + c) / 2;
            double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            return area;
        }

        /// <summary>
        /// Convert int digit to string name of digit
        /// </summary>
        /// <param name="number">Number in range [0..9]</param>
        /// <returns>Returns string name of digit</returns>
        static string NumberToDigit(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: throw new ArgumentOutOfRangeException("Number should be in range [0..9].");
            }
        }

        /// <summary>
        /// Method finds max number in array
        /// </summary>
        /// <param name="elements">Array of integers</param>
        /// <returns>Returns max integer in array</returns>
        static int FindMax(params int[] elements)
        {
            if (elements == null || elements.Length == 0)
            {
                throw new ArgumentNullException("elements");
            }

            var maxElement = elements[0];
            for (int i = 1; i < elements.Length; i++)
            {
                if (elements[i] > maxElement)
                {
                    maxElement = elements[i];
                }
            }
            return maxElement;
        }

        /// <summary>
        /// Method prints formatted numbers
        /// </summary>
        /// <param name="number">input numbers</param>
        /// <param name="format">string number format </param>
        static void PrintAsNumber(object number, string format)
        {
            if (format == "f")
            {
                Console.WriteLine("{0:f2}", number);
            }
            else if (format == "%")
            {
                Console.WriteLine("{0:p0}", number);
            }
            else if (format == "r")
            {
                Console.WriteLine("{0,8}", number);
            }
            else
            {
                throw new ArgumentException("Incorrect string format.");
            }
        }

        /// <summary>
        /// Method calculates the distance between two points in a coordinate system
        /// </summary>
        /// <returns>Returns double distance, bool isHorizontal, bool isVertical</returns>
        static double CalcDistance(double x1, double y1, double x2, double y2, 
            out bool isHorizontal, out bool isVertical)
        {
            isHorizontal = false;
            isVertical = false;
            if ((y1 == y2) && (x1 == x2))
            {
                return 0;
            }

            if (y1 == y2)
            {
                isHorizontal = true;
            }

            if (x1 == x2)
            {
                isVertical = true;
            }

            double distance = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1));
            return distance;
        }

        /// <summary>
        /// Test class Methods and class Student
        /// </summary>
        static void Main()
        {
            Console.WriteLine(CalcTriangleArea(3, 4, 5));
            
            Console.WriteLine(NumberToDigit(5));
            
            Console.WriteLine(FindMax(5, -1, 3, 2, 14, 2, 3));
            
            PrintAsNumber(1.3, "f");
            PrintAsNumber(0.75, "%");
            PrintAsNumber(2.30, "r");

            bool horizontal, vertical;
            Console.WriteLine(CalcDistance(3, -1, 3, 2.5, out horizontal, out vertical));
            Console.WriteLine("Horizontal? " + horizontal);
            Console.WriteLine("Vertical? " + vertical);

            Student peter = new Student() { FirstName = "Peter", LastName = "Ivanov" };
            peter.OtherInfo = "From Sofia, born at 17.03.1992";

            Student stella = new Student() { FirstName = "Stella", LastName = "Markova" };
            stella.OtherInfo = "From Vidin, gamer, high results, born at 03.11.1993";

            Console.WriteLine("{0} older than {1} -> {2}",
                peter.FirstName, stella.FirstName, peter.IsOlderThan(stella));
        }
    }
}
