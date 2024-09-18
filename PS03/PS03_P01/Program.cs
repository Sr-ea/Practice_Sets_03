using System;

    namespace PS03_P01
    {
        internal class Program
        {
            static void Main(string[] args)
            {
            //Create a function that computes the area of a triangle using Heron’s formula
            Console.Write("Enter length of side 1:");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Enter length of side 2:");
            double b = double.Parse(Console.ReadLine());

            Console.Write("Enter length of side 3:");
            double c = double.Parse(Console.ReadLine());

            double area = ComputeArea(a, b, c);

            Console.WriteLine($"The area of the triangle is: {area}");
             
            }

            static double ComputeArea(double a, double b, double c)
            {
                double s = (a + b + c) / 2;
                double area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

                return area;
            }
        }
    }
 