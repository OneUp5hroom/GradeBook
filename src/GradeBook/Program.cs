using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Scott's Grade Book");
            Console.WriteLine("Please enter Grades for Scott, Q to quit");
            while(true)
            {
                var input = Console.ReadLine();
                if (input == "q" || input == "Q")
                {
                    break;
                }
                var grade = 0.0;
                if (double.TryParse(input, out grade)) {
                    try{
                        book.AddGrade(grade);
                    }
                    catch(ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    finally
                    {
                        Console.WriteLine("**");
                    }
                    
                } 
                else 
                {
                    Console.WriteLine($"What the heck was that crap? you think {input} looks like a grade?");
                }
            };

            var stats = book.GetStatistics();

            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average}");
            Console.WriteLine($"The letter grade is {stats.Letter}");
        }
    }
}
