using System;
using System.Collections.Generic;
using System.Linq; 

namespace lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student> {
                new Student {FirstName = "Jamie", LastName = "Lannister", Classification = "Senior", Major = "General Business", GPA = 1.72},
                new Student {FirstName = "Cersei", LastName = "Lannister", Classification = "Senior", Major = "Computer Information Systems", GPA = 3.02},
                new Student {FirstName = "Daenerys", LastName = "Targaryen", Classification = "Junior", Major = "Marketing", GPA = 4.00},
                new Student {FirstName = "Jon", LastName = "Snow", Classification = "Freshman", Major = "Marketing", GPA = 4.00},
                new Student {FirstName = "Arya", LastName = "Stark", Classification = "Senior", Major = "Computer Information Systems", GPA = 3.70},
                new Student {FirstName = "Davos", LastName = "Seaworth", Classification = "Freshman", Major = "Computer Information Systems", GPA = 1.50},
                new Student {FirstName = "Tyrion", LastName = "Lannister", Classification = "Sophomore", Major = "Accounting", GPA = 2.80},
                new Student {FirstName = "Robert", LastName = "Baratheon", Classification = "Sophomore", Major = "Economics", GPA = 3.50},
                new Student {FirstName = "Khal", LastName = "Drogo", Classification = "Junior", Major = "General Business", GPA = 3.00},
                new Student {FirstName = "Jorah", LastName = "Mormont", Classification = "Junior", Major = "Economics", GPA = 1.00},
            };

            // Write your queries here
            // LINQ operations on "List<Student>" (Query "Student" objects directly with LINQ, w/out using a database)(wk4 LINQ Code Video & LINQDemo folder files)
        // Query 1  --moved comment over for readability
            Console.WriteLine("\n---Query 1 Query Syntax---");
            var query1 = from s in students // Specify data source
                        where s.GPA < 2.0 // filter data
                        select s; // return value   

            foreach (var s in query1) // Displays Query Syntax return values
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("\n---Query 1 Method Syntax---");
            var query1MS = students.Where(s => s.GPA < 2.0);
            foreach (var s in query1MS)
            {
                Console.WriteLine(s);
            }

        // Query 2
            Console.WriteLine("\n---Query 2 Query Syntax---");
            var query2 = from s in students // Specify data source
                        where s.GPA >= 2.0 && s.GPA <= 3.0 // filter data
                        select s; // return value
            foreach (var s in query2)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("\n---Query 2 Method Syntax---");
            var query2MS = students.Where(s => s.GPA >= 2.0 && s.GPA <= 3.0); // Could also chain 2 where clauses in place of &&
            foreach (var s in query2MS)
            {
                Console.WriteLine(s);
            }

        // Query 3
            Console.WriteLine("\n---Query 3 Query Syntax---");
            var query3 = from s in students // Specify data source
                        where s.GPA == 4.0 // Filter data
                        select s.LastName; // Returns only LastName
            foreach (var s in query3)
            {
                Console.WriteLine(s); // Displays only LastName
            }

            Console.WriteLine("\n---Query 3 Method Syntax---");
            var query3MS = students.Where(s => s.GPA == 4.0);
            foreach (var s in query3MS)
            {
                Console.WriteLine(s.LastName); // Displays only LastName
            }

        // Query 4
            Console.WriteLine("\n---Query 4 Query Syntax---");
            var query4 = from s in students
                        orderby s.GPA descending // Order GPA Highest to Lowest
                        select s;
            foreach (var s in query4)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("\n---Query 4 Method Syntax---");
            var query4MS = students.OrderByDescending(s => s.GPA);
            foreach (var s in query4MS)
            {
                Console.WriteLine(s);
            }

        // Query 5 Return students with LastName starts with "L" and sorts by GPA low to high 
            // Chain "Where" clause, "StartsWith", and "OrderBy" 
            Console.WriteLine("\n--Select students with last name that begins with the letter \"L\" and sort them by GPA from lowest to highest--");
            Console.WriteLine("\n---Query 5 Query Syntax---");
            var query5 = from s in students
                        where s.LastName.StartsWith("L") // Returns "empty collection" instead of Null if letter not found, order clause performs on "empty collection, foreach clause does not execute "empty collections"
                        orderby s.GPA // Performs on "empty collection" from "where" clause(if letter not found from above)
                        select s; // Returns "empty collection" 
            foreach (var s in query5) // Does not execute if "empty collection" (doesn't try to access properties of non-existent objects b/c elements Do Not Exist, so no NullReferenceException)
            {
                Console.WriteLine(s);
            }

            Console.WriteLine("\n---Query 5 Method Syntax---");
            var query5MS = students.Where(s => s.LastName.StartsWith("L")).OrderBy(s => s.GPA); // Returns "empty values" instead of Null
            foreach (var s in query5MS) // Does not execute if "empty collection"
            {
                Console.WriteLine(s);
            }
        }
    }
}    