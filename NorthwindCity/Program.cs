using NorthwindCity.DbModels;
using System;
using System.Collections.Generic;
using System.Linq;
using static System.Console;

namespace NorthwindCity
{
    class Program
    {
        private static readonly northwindContext _context = new northwindContext();
        static void Main(string[] args)
        {
            var customers = _context.Customers.ToList();

            var city = customers
                .Select(c => c.City)
                .Distinct();

            WriteLine(string.Join(", ", city));

            Write("\nEnter the name of a city: ");
            string input = ReadLine().ToLower();

            var filteredCompany = customers.Where(c => c.City.ToLower() == input);
            foreach (var com in filteredCompany)
            {
                WriteLine($"{com.Company}");
            }
        }
    }
}
