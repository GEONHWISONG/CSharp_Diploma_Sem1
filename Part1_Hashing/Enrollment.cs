using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1_Hashing
{
    /// <summary>
    /// Represents an enrollment with date, grade, semester, and associated subject.
    /// </summary>
    public class Enrollment
    {
        /// <summary>
        /// Gets or sets the date, grade, semester and subject of enrollment.
        /// </summary>
        public DateTime DateEnrolled { get; set; }
        public string Grade { get; set; }
        public string Semester { get; set; }
        public Subject Subject { get; set; }


        /// <summary>
        /// Initializes a new instance of the Class Enrollment (constructor)
        /// </summary>
        /// <param name="dateEnrolled"></param>
        /// <param name="grade"></param>
        /// <param name="semester"></param>
        /// <param name="subject"></param>
        public Enrollment(DateTime dateEnrolled, string grade, string semester, Subject subject)
        {
            this.DateEnrolled = dateEnrolled;
            this.Grade = grade;
            this.Semester = semester;
            this.Subject = subject;

        }
        /// <summary>
        /// Determines whether the specified object is equal to the current enrollment
        /// </summary>
        /// <param name="obj">The object to compare with the current enrollment</param>
        /// <returns>if the specified object is equal to the current enrollment True, otherwise False</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (ReferenceEquals(obj, this))
                return true;
            if (obj.GetType() != GetType())
                return false;

            Enrollment other = (Enrollment)obj;

            return this.DateEnrolled == other.DateEnrolled &&
                this.Grade == other.Grade &&
                this.Semester == other.Semester &&
                this.Subject == other.Subject;


        }
        /// <summary>
        /// 
        /// default hash function
        /// </summary>
        /// <returns>A hash code for the current enrollment.</returns>
        public override int GetHashCode()
        {
            return this.Grade.GetHashCode() ^ this.Semester.GetHashCode() ^ this.Subject.GetHashCode();

        }

        /// <summary>
        /// Determines whether two enrollment instances are equal.
        /// </summary>
        /// <param name="enrollment1">The first enrollment to compare.</param>
        /// <param name="enrollment2">The second enrollment to compare.</param>
        /// <returns></returns>
        public static bool operator ==(Enrollment enrollment1, Enrollment enrollment2)
        {

            return object.Equals(enrollment1, enrollment2);
        }
        /// <summary>
        /// Determines whether two enrollment instances are not equal.
        /// </summary>
        /// <param name="enrollment1">The first enrollment to compare</param>
        /// <param name="enrollment2">The second enrollment to compare</param>
        /// <returns></returns>
        public static bool operator !=(Enrollment enrollment1, Enrollment enrollment2)
        {
            return !(enrollment1 == enrollment2);
        }
        /// <summary>
        /// 
        /// Returns a string that represents the current enrollment.
        /// </summary>
        /// <returns>string that represents the current enrollment.</returns>
        public override string ToString()
        {
            return "DateEnrolled = " + DateEnrolled  + " // Grade : " + Grade + " // Semester : " + Semester + " // Subject : " + Subject;
        }
    }
}
