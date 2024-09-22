using System;

namespace ICTPRG547_Assessment1_WyattCoff
{
    public class Enrollment
    {
        // Constants for default values
        private const SemesterEnum DEFAULT_SEMESTER = SemesterEnum.NotProvided;
        private const GradeEnum DEFAULT_GRADE = GradeEnum.NotProvided;
        private static readonly Subject DEFAULT_SUBJECT = new Subject();

        // Public properties for enrollment details
        public DateTime? DateEnrolled { get; set; }
        public GradeEnum Grade { get; set; }
        public SemesterEnum Semester { get; set; }
        public Subject Subject { get; set; }

        /// <summary>
        /// Initializes a new instance of the Enrollment class with default values.
        /// </summary>
        public Enrollment() : this(DateTime.MinValue, DEFAULT_GRADE, DEFAULT_SEMESTER, new Subject())
        {
        }

        /// <summary>
        /// Initializes a new instance of the Enrollment class with the specified date, grade, semester, and subject.
        /// </summary>
        /// <param name="dateEnrolled">The date the student enrolled in the subject.</param>
        /// <param name="grade">The grade received for the subject.</param>
        /// <param name="semester">The semester during which the subject was enrolled in.</param>
        /// <param name="subject">The subject the student enrolled in.</param>
        public Enrollment(DateTime dateEnrolled, GradeEnum grade, SemesterEnum semester, Subject subject)
        {
            DateEnrolled = dateEnrolled;
            Grade = grade;
            Semester = semester;
            Subject = subject;
        }

        /// <summary>
        /// Defines the possible semesters a student can enroll in.
        /// </summary>
        public enum SemesterEnum
        {
            NotProvided,
            First,
            Second
        }

        /// <summary>
        /// Defines the possible grades a student can receive.
        /// </summary>
        public enum GradeEnum
        {
            NotProvided,
            Fail,
            Pass
        }

        /// <summary>
        /// Returns a string that contains the current enrollment.
        /// </summary>
        /// <returns>
        /// A string containing the date of enrollment, grade, semester, and subject.
        /// </returns>
        public override string ToString()
        {
            string enrolledDate = DateEnrolled.HasValue && DateEnrolled != DateTime.MinValue ? DateEnrolled.Value.ToShortDateString() : "Not Enrolled";
            return $"[Date Enrolled: {enrolledDate}, Grade: {Grade}, Semester: {Semester}, Subject: {Subject}]";
        }

    }
}


