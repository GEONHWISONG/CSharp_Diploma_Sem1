using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1_Hashing
{
    /// <summary>
    /// Represents a subject with a code, name, and cost.
    /// </summary>
    public class Subject
    {
        /// <summary>
        /// Gets or sets the subject code, name and cost.
        /// </summary>
        public string SubjectCode { get; set; }
        public string SubjectName { get; set; }
        public double Cost { get; set; }

        /// <summary>
        /// Initializes a new instance of the Class Subject. (Constructor)
        /// </summary>
        /// <param name="subjectCode"></param>
        /// <param name="subjectName"></param>
        /// <param name="cost"></param>
        public Subject(string subjectCode, string subjectName, double cost)
        {
            this.SubjectCode = subjectCode;
            this.SubjectName = subjectName;
            this.Cost = cost;
        }
        /// <summary>
        /// Determines whether the specified object is equal to the current subject.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (ReferenceEquals(obj, this))
                return true;
            if (obj.GetType() != GetType())
                return false;

            Subject other = (Subject)obj;

            return this.SubjectCode == other.SubjectCode &&
                this.SubjectName == other.SubjectName &&
                this.Cost == other.Cost;


        }
        /// <summary>
        /// Default Hash function.
        /// </summary>
        /// <returns>A hash code for the current subject. </returns>
        public override int GetHashCode()
        {
            return this.SubjectCode.GetHashCode() ^ this.SubjectName.GetHashCode() ^ this.Cost.GetHashCode();

        }

        /// <summary>
        /// Returns a string that represents the current subject.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "Subject Code : " + SubjectCode + " // Subject Name : " + SubjectName + " // Cost : $" + Cost;
        }
    }
}
