using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using ICTPRG547_Assessment1_WyattCoff;

namespace ICTPRG547_Assessment1_WyattCoff.Tests
{
    [TestFixture]
    public class UtilityTests
    {
        public Student[] students;

        [OneTimeSetUp]
        public void SetUp()
        {
            // Initialize an array of 10 Student objects for testing purposes
            students = new Student[]
            {
                new Student("Wyatt Coff", "WyattCoff@gmail.com", "1234567890", new Address("120", "Currie St", "Adelaide", "5000", "SA"), "0021", "Computer Science", new DateTime(2022, 4, 20)),
                new Student("Joe Smith", "JoeSmith@gmail.com", "1234567891", new Address("6", "Locker Bag", "Northbridge", "6865", "WA"), "0042", "Graphic Design", new DateTime(2023, 7, 1)),
                new Student("Connor Thorning", "ConnorThorning@gmail.com", "1234567892", new Address("120", "Currie St", "Adelaide", "5000", "SA"), "0021", "Computer Science", new DateTime(2022, 4, 20)),
                new Student("Yuri Icaro", "YuriIcaro@yahoo.com", "1234567893", new Address("01", "College St", "Liverpool", "2170", "NSW"), "0054", "Accounting", new DateTime(2021, 6, 30)),
                new Student("Alex Jones", "AlexJones@gmail.com", "1234567894", new Address("45", "Main St", "Sydney", "2000", "NSW"), "0030", "Business", new DateTime(2020, 2, 15)),
                new Student("Alice Walker", "AliceWalker@gmail.com", "1234567895", new Address("12", "Green St", "Melbourne", "3000", "VIC"), "0055", "Arts", new DateTime(2019, 3, 11)),
                new Student("Robert Brown", "RobertBrown@gmail.com", "1234567896", new Address("98", "Kings Rd", "Brisbane", "4000", "QLD"), "0060", "Law", new DateTime(2020, 8, 22)),
                new Student("Emma White", "EmmaWhite@gmail.com", "1234567897", new Address("56", "High St", "Perth", "6000", "WA"), "0070", "Medicine", new DateTime(2018, 5, 15)),
                new Student("Chris Green", "ChrisGreen@gmail.com", "1234567898", new Address("10", "Lakeview Dr", "Canberra", "2600", "ACT"), "0080", "Engineering", new DateTime(2021, 1, 19)),
                new Student("Sophie Blue", "SophieBlue@gmail.com", "1234567899", new Address("34", "River Rd", "Hobart", "7000", "TAS"), "0090", "Music", new DateTime(2020, 11, 10))
            };
        }

        [Test]
        public void TestLinearSearch_Found()
        {
            // Expected outcome: The linear search should find the student and return true.
            bool isFound = Utility.LinearSearchArray(students, students[0]);
            Assert.IsTrue(isFound);  // Should return true for a found student
        }
        [Test]
        public void TestLinearSearch_NotFound()
        {
            // Expected outcome: The linear search should not find the student and return false.
            var nonExistentStudent = new Student("NonExistent", "nonexistent@example.com", "0000000000", new Address(), "9999", "NonExistingProgram", DateTime.MinValue);
            bool isFound = Utility.LinearSearchArray(students, nonExistentStudent);
            Assert.IsFalse(isFound);  // Should return false for a non-existent student
        }

        [Test]
        public void TestBinarySearch_Found()
        {
            // Expected outcome: The binary search should find the student after sorting the array.
            Utility.BubbleSortAscending(students);

            // Find the student with StudentID: 0042 
            Student studentToFind = students.First(s => s.StudentID == "0042");

            // Test finding an existing student (Student ID: 0042)
            int index = Utility.BinarySearchArray(students, studentToFind);

            // Ensure that the returned index points to the correct student
            Assert.AreEqual(studentToFind, students[index]);
        }

        [Test]
        public void TestBinarySearch_NotFound()
        {
            // Expected outcome: The binary search should not find the student, so the index should be -1.
            Utility.BubbleSortAscending(students);

            var nonExistentStudent = new Student("NonExistent", "nonexistent@example.com", "0000000000", new Address(), "9999", "NonExistingProgram", DateTime.MinValue);
            int index = Utility.BinarySearchArray(students, nonExistentStudent);
            Assert.AreEqual(-1, index);  // Should return -1 for not found
        }

        [Test]
        public void TestBubbleSortAscending()
        {
            // Expected outcome: After sorting in ascending order, students should be arranged by StudentID in ascending order.
            Utility.BubbleSortAscending(students);

            // Verify sorting
            for (int i = 0; i < students.Length - 1; i++)
            {
                Assert.LessOrEqual(students[i].StudentID, students[i + 1].StudentID);
            }
        }

        [Test]
        public void TestBubbleSortDescending()
        {
            // Expected outcome: After sorting in descending order, students should be arranged by StudentID in descending order.
            Utility.BubbleSortDescending(students);

            // Verify sorting
            for (int i = 0; i < students.Length - 1; i++)
            {
                Assert.GreaterOrEqual(students[i].StudentID, students[i + 1].StudentID);
            }
        }
    }
}


