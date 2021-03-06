﻿using System;
using System.Collections.Generic;

namespace GradeBook
{



    class Program
    {
        static void Main(string[] args)
        {
            var book = new Book("Tyler's Grade Book");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.5);
            var stats = book.GetStatistics();

            Console.WriteLine($"The average grade is {stats.High:n1}");
            Console.WriteLine($"The highest grade is {stats.Low:n1}");
            Console.WriteLine($"The lowest grade is {stats.Average:n1}");
        }
    }
}
