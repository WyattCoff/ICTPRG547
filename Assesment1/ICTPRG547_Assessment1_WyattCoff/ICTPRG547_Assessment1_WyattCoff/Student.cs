using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICTPRG547_Assessment1_WyattCoff
{
    /// <summary>
    /// Represents a student with relevant details such as StudentID, Program, and DateRegistered.
    /// Inherits from the Person class.
    /// </summary>
    public class Student : Person, IComparable<Student>
    {
        // Constants for default values
        private const string DEFAULT_STUDENT_ID = "No Student ID Provided";
        private const string DEFAULT_PROGRAM = "No Program Provided";
        private static readonly DateTime DEFAULT_DATE_REGISTERED = DateTime.MinValue;

        // Default comparison parameter for sorting
        private static string compareParameter = "date";

        /// <summary>
        /// Default constructor initializing default values for StudentID, Program, and DateRegistered.
        /// </summary>
        public Student()
        {
            StudentID = DEFAULT_STUDENT_ID;
            Program = DEFAULT_PROGRAM;
            DateRegistered = DEFAULT_DATE_REGISTERED;
        }

        /// <summary>
        /// Constructor initializing the student with specific values.
        /// </summary>
        /// <param name="name">The name of the student.</param>
        /// <param name="email">The email of the student.</param>
        /// <param name="phoneNumber">The phone number of the student.</param>
        /// <param name="address">The address of the student.</param>
        /// <param name="studentID">The unique identifier of the student.</param>
        /// <param name="program">The academic program the student is enrolled in.</param>
        /// <param name="dateRegistered">The date when the student was registered.</param>
        public Student(string name, string email, string phoneNumber, Address address, string studentID, string program, DateTime dateRegistered)
            : base(name, email, phoneNumber, address)
        {
            StudentID = studentID;
            Program = program;
            DateRegistered = dateRegistered;
        }

        /// <summary>
        /// Gets or sets the student's ID.
        /// </summary>
        public string StudentID { get; set; }

        /// <summary>
        /// Gets or sets the student's program.
        /// </summary>
        public string Program { get; set; }

        /// <summary>
        /// Gets or sets the date the student was registered.
        /// </summary>
        public DateTime DateRegistered { get; set; }

        /// <summary>
        /// Determines whether the specified student is equal to the current student.
        /// </summary>
        /// <param name="obj">The object to compare with the current student.</param>
        /// <returns>True if the specified object is equal to the current student otherwise, false.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }

            Student other = (Student)obj;
            return this.StudentID == other.StudentID && this.Program == other.Program && this.DateRegistered == other.DateRegistered;
        }

        /// <summary>
        /// Returns a hash code for this student based on the StudentID, Program, and DateRegistered properties.
        /// </summary>
        /// <remarks>
        /// This method generates a hash code using the StudentID, Program, and DateRegistered for equality comparisons.
        /// This ensures that if two students are considered equal by the Equals method, they will also have the same hash code.
        /// </remarks>
        /// <returns>An integer hash code representing the student, based on the StudentID, Program, and DateRegistered.</returns>
        public override int GetHashCode()
        {
            unchecked
            {
                int hash = 53;
                hash = hash * 37 + (StudentID?.GetHashCode() ?? 0);
                hash = hash * 37 + (Program?.GetHashCode() ?? 0);
                hash = hash * 37 + DateRegistered.GetHashCode();
                return hash;
            }
        }

        /// <summary>
        /// Determines whether two student objects are equal.
        /// </summary>
        /// <param name="left">The first student to compare.</param>
        /// <param name="right">The second student to compare</param>
        /// <returns>True if the two students are equal otherwise, false.</returns>
        public static bool operator ==(Student left, Student right)
        {
            if (ReferenceEquals(left, right))
                return true;

            if (((object)left == null) || ((object)right == null))
                return false;

            return left.Equals(right);
        }

        /// <summary>
        /// Determines whether two student objects are not equal.
        /// </summary>
        /// <param name="left">The first student to compare.</param>
        /// <param name="right">The second student to compare.</param>
        /// <returns>True if the two students are not equal otherwise, false.</returns>
        public static bool operator !=(Student left, Student right)
        {
            return !(left == right);
        }

        /// <summary>
        /// Returns a string that represents the current student.
        /// </summary>
        /// <returns>A string containing the student's name, email, student ID, program, and registration date.</returns>
        public override string ToString()
        {
            return $"[Student Name: {Name}, Student Email: {Email}, Student ID: {StudentID}, Program: {Program}, Date Registered: {DateRegistered}]";
        }

        /// <summary>
        /// Sets the parameter for comparing students, either by student ID or registration date.
        /// </summary>
        /// <param name="parameter">The comparison parameter, either "studentID" or "date".</param>
        public static void SetCompareParameter(string parameter)
        {
            compareParameter = parameter;
        }

        /// <summary>
        /// Compares the current student object to another student based on the comparison parameter.
        /// </summary>
        /// <param name="other">The student to compare.</param>
        /// <returns>A value that shows the relative order of the students being compared.</returns>
        public int CompareTo(Student other)
        {
            switch (compareParameter)
            {
                case "studentID":
                    return this.StudentID.CompareTo(other.StudentID);
                case "date":
                default:
                    return this.DateRegistered.CompareTo(other.DateRegistered);
            }
        }
    }
}
