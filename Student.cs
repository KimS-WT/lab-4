using System;

namespace lab4
{
    public class Student
    {
        public int StudentId {get; set;}
        public string FirstName {get; set;} = string.Empty;
        public string LastName {get; set;} = string.Empty;
        public string Classification {get; set;} = string.Empty;
        public string Major {get; set;} = string.Empty;
        public double GPA {get; set;}

        public override string ToString()
        {
            return $"{FirstName} {LastName} {GPA:F2} GPA"; // Code from LINQDemo MadScientist.cs & GPA:F2 shows 2 decimal places including 0's
        }
    }
}