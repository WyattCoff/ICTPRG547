using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICTPRG547_Assessment1_WyattCoff
{
    public class Subject
    {
        // Constants for default values
        private const string DEFAULT_SUBJECT_CODE = "No Subject Code Provided";
        private const string DEFAULT_SUBJECT_NAME = "No Subject Name Provided";
        private const decimal DEFAULT_COST = 0;

        // Instance variables for subject details, initialized with default values
        private string subjectCode;
        private string subjectName;
        private decimal cost;

        /// <summary>
        /// Initializes a new instance of the <see cref="Subject"/> class with default values.
        /// </summary>
        public Subject() : this(DEFAULT_SUBJECT_CODE, DEFAULT_SUBJECT_NAME, DEFAULT_COST)
        {
            // No additional logic required.
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="Subject"/> class with the specified subject code, subject name, and cost.
        /// </summary>
        /// <param name="subjectCode">The subject code for the academic subject.</param>
        /// <param name="subjectName">The subject name for the academic subject.</param>
        /// <param name="cost">The cost of the academic subject.</param>
        public Subject(string subjectCode, string subjectName, decimal cost)
        {
            this.subjectCode = subjectCode;
            this.subjectName = subjectName;
            this.cost = cost;
        }

        /// <summary>
        /// Gets or sets the subject code of the subject.
        /// </summary>
        public string SubjectCode
        {
            get { return subjectCode; }
            set { subjectCode = value; }
        }


        /// <summary>
        /// Gets or sets the subject name of the subject.
        /// </summary>
        public string SubjectName
        {
            get { return subjectName; }
            set { subjectName = value; }
        }

        /// <summary>
        /// Gets or sets the cost of the subject.
        /// </summary>
        public decimal Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        /// <summary>
        /// Returns a string that contains the current subject, displaying the subject code, subject name, and cost.
        /// </summary>
        /// <returns>
        /// A string containing the subject's details, including the subject code, name, and cost.
        /// </returns>
        public override string ToString()
        {
            return $"Subject Code: {SubjectCode}, Subject Name: {SubjectName}, Cost: {Cost.ToString("C")}";
        }
    }
}
