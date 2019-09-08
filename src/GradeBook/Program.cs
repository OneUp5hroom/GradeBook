using System;
using System.Collections.Generic;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new DiskBook("Scott's Grade Book");
            book.GradeAdded += OnGradeAdded;

            Console.WriteLine("Please enter Grades for Scott, Q to quit");
            EnterGrades(book);

            var stats = book.GetStatistics();

            Console.WriteLine($"The lowest grade is {stats.Low}");
            Console.WriteLine($"The highest grade is {stats.High}");
            Console.WriteLine($"The average grade is {stats.Average}");
            Console.WriteLine($"The letter grade is {stats.Letter}");
        }

        private static void EnterGrades(Book book)
        {
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "q" || input == "Q")
                {
                    break;
                }
                var grade = 0.0;
                if (double.TryParse(input, out grade))
                {
                    try
                    {
                        book.AddGrade(grade);
                    }
                    catch (ArgumentException ex)
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
        }

        static void OnGradeAdded(object sender, EventArgs e)
        {
          Console.WriteLine("A Grade was Added");  
        }
    }
}
