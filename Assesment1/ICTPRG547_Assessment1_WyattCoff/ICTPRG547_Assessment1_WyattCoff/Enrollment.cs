using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICTPRG547_Assessment1_WyattCoff
{
    public class Enrollment
    {
        // Constants for default values
        private const SemesterEnum DEFAULT_SEMESTER = SemesterEnum.NotProvided;
        private const GradeEnum DEFAULT_GRADE = GradeEnum.NotProvided;
        private static readonly Subject DEFAULT_SUBJECT = new Subject();

        // Instance variables
        private DateTime? dateEnrolled;
        private GradeEnum grade;
        private SemesterEnum semester;
        private Subject subject;

        /// <summary>
        /// Initializes a new instance of the Enrollment class with default values.
        /// </summary>
        public Enrollment()
        {
            dateEnrolled = null;
            grade = DEFAULT_GRADE;
            semester = DEFAULT_SEMESTER;
            subject = DEFAULT_SUBJECT;
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
            this.dateEnrolled = dateEnrolled;
            this.grade = grade;
            this.semester = semester;
            this.subject = subject;
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
        /// Gets or sets the date the student enrolled in the subject.
        /// </summary>
        public DateTime? DateEnrolled { get; set; }

        /// <summary>
        /// Gets or sets the grade received for the subject.
        /// </summary>
        public GradeEnum Grade { get; set; }

        /// <summary>
        /// Gets or sets the semester during which the subject was enrolled in.
        /// </summary>
        public SemesterEnum Semester { get; set; }

        /// <summary>
        /// Gets or sets the subject the student enrolled in.
        /// </summary>
        public Subject Subject { get; set; }

        /// <summary>
        /// Returns a string that contains the current enrollment.
        /// </summary>
        /// <returns>
        /// A string containing the date of enrollment, grade, semester, and subject.
        /// </returns>
        public override string ToString()
        {
            return $"Enrolled on: {DateEnrolled}, Grade: {Grade}, Semester: {Semester}, Subject: {Subject}";
        }
    }
}

