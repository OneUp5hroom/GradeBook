﻿using System;
using System.Collections.Generic;

namespace GradeBook
{

    class Program
    {
        static void Main(string[] args)
        {
            var book = new book();

            var grades = new List<double>() { 12.7, 10.3, 6.11, 4.1 };
            grades.Add(56.1);

            double result = 0;
            foreach (double number in grades) 
            {
                result += number;
            }
            result = result / grades.Count;

            System.Console.WriteLine($"The average grade is {result:N1}");
        }
    }
}