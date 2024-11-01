﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICTPRG547_Assessment1_WyattCoff
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Test Address class
            Console.WriteLine("Testing Address Class:");
            var address = new Address("123", "Main St", "Adelaide", "5000", "SA");
            Console.WriteLine($"Address: {address.ToString()}");

            // Test Subject class
            Console.WriteLine("\nTesting Subject Class:");
            var subject = new Subject("COMP101", "Intro to Programming", 500m);
            Console.WriteLine($"Subject: {subject.ToString()}");

            // Test Enrollment class
            Console.WriteLine("\nTesting Enrollment Class:");
            var enrollment = new Enrollment(new DateTime(2024, 1, 15), Enrollment.GradeEnum.Pass, Enrollment.SemesterEnum.First, subject);
            Console.WriteLine($"Enrollment: {enrollment.ToString()}");

            // Modify Enrollment details
            Console.WriteLine("\nModifying Enrollment Details:");
            enrollment.DateEnrolled = new DateTime(2024, 2, 10);
            enrollment.Grade = Enrollment.GradeEnum.Fail;
            enrollment.Semester = Enrollment.SemesterEnum.Second;
            Console.WriteLine($"Updated Enrollment: {enrollment.ToString()}");

            // Test default constructor of Enrollment
            Console.WriteLine("\nTesting Enrollment Default Constructor:");
            var defaultEnrollment = new Enrollment();
            Console.WriteLine($"Default Enrollment: {defaultEnrollment.ToString()}");

            // Create a list of students
            List<Student> students = new List<Student>
            {
                new Student("Wyatt Coff", "WyattCoff@gmail.com", "1234567890", new Address("120", "Currie St", "Adelaide", "5000", "SA"), "0021", "Computer Science", new DateTime(2022, 4, 20)),
                new Student("Joe Smith", "JoeSmith@gmail.com", "1234567891", new Address("6", "Locker Bag", "Northbridge", "6865", "WA"), "0042", "Graphic Design", new DateTime(2023, 7, 1)),
                new Student("Connor Thorning", "ConnorThorning@gmail.com", "1234567892", new Address("120", "Currie St", "Adelaide", "5000", "SA"), "0021", "Computer Science", new DateTime(2022, 4, 20)),
                new Student("Yuri Icaro", "YuriIcaro@yahoo.com", "1234567893", new Address("01", "College St", "Liverpool", "2170", "NSW"), "0054", "Accounting", new DateTime(2021, 6, 30))
            };

            // Test ToString
            Console.WriteLine("\nTesting ToString for Students:");
            Console.WriteLine("Expected: Display all student details.");
            students.ForEach(student => Console.WriteLine(student.ToString()));

            // Test Equals
            Console.WriteLine("\nTesting Equals:");
            Console.WriteLine($"Expected: False (First and second student are not equal)");
            Console.WriteLine($"Actual: {students[0].Equals(students[1])}");
            Console.WriteLine($"Expected: True (First and third student are equal)");
            Console.WriteLine($"Actual: {students[0].Equals(students[2])}");

            // Test == and !=
            Console.WriteLine("\nTesting == and !=:");
            Console.WriteLine($"Expected: False (First and second student are not equal using ==)");
            Console.WriteLine($"Actual: {students[0] == students[1]}");
            Console.WriteLine($"Expected: True (First and third student are equal using ==)");
            Console.WriteLine($"Actual: {students[0] == students[2]}");
            Console.WriteLine($"Expected: True (First and second student are not equal using !=)");
            Console.WriteLine($"Actual: {students[0] != students[1]}");
            Console.WriteLine($"Expected: False (First and third student are equal using !=)");
            Console.WriteLine($"Actual: {students[0] != students[2]}");

            // Test GetHashCode
            Console.WriteLine("\nTesting GetHashCode:");
            Console.WriteLine($"Expected: Hash codes of first and third student should be the same");
            Console.WriteLine($"Actual HashCode of first student: {students[0].GetHashCode()}");
            Console.WriteLine($"Actual HashCode of third student: {students[2].GetHashCode()}");
            Console.WriteLine($"Expected: Hash codes of first and second student should be different");
            Console.WriteLine($"Actual HashCode of second student: {students[1].GetHashCode()}");

            // Change comparison parameter to studentID
            Console.WriteLine("\nTesting CompareTo (By StudentID):");
            Console.WriteLine("Expected: Students sorted by StudentID in ascending order.");
            Student.SetCompareParameter("studentID");
            students.Sort();
            students.ForEach(student => Console.WriteLine(student.ToString()));

            Console.ReadKey();

        }
    }
}
