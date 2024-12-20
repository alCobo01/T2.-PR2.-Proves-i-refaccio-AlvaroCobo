﻿using System;

namespace T2_PR2_ClassLibrary
{
    public class MyFunctions
    {
        public static bool IsUnderZero(double value)
        {
            return value <= 0;
        }

        public static double CalculateArea(double width, double height)
        {
            return width * height;
        }

        public static double CalculateCircumference(double radius)
        {
            return 2 * Math.PI * radius;
        }

        public static void PrintAreaMessage(double area)
        {
            const string MissatgeAreaMesDe50 = "L'àrea és més gran de 50",
                MissatgeAreaEntre20i50 = "L'àrea és entre 20 i 50",
                MissatgeAreaMenorOigualA20 = "L'àrea és menor o igual a 20";

            switch (area)
            {
                case > 50:
                    Console.WriteLine(MissatgeAreaMesDe50);
                    break;
                case > 20:
                    Console.WriteLine(MissatgeAreaEntre20i50);
                    break;
                default:
                    Console.WriteLine(MissatgeAreaMenorOigualA20);
                    break;
            }
            Console.WriteLine();
        }

    }
}
