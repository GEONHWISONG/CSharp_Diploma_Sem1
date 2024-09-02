using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Part1_Hashing
{
    /// <summary>
    /// Represents a student, inheriting from the Person class, with additional properties like StudentID, Program, DateRegistered, and Enrollment.
    /// </summary>
    public class Student : Person, IComparable<Student>
    {
        /// <summary>
        /// Gets or sets the student ID, program, dateregistered and enrollment of Student.
        /// </summary>
        public int StudentID { get; set; }
        public string Program { get; set; }

        public DateTime DateRegistered { get; set; }

        public Enrollment Enrollment { get; set; }
        /// <summary>
        /// Initializes a new instance of the Class Student
        /// </summary>
        /// <param name="studentID"></param>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="address"></param>
        /// <param name="program"></param>
        /// <param name="dateRegistered"></param>
        /// <param name="enrollment"></param>
        public Student(int studentID, string name, string email, string phoneNumber, Address address, string program, DateTime dateRegistered, Enrollment enrollment)
            :base(name,email,phoneNumber,address)
        {
            this.StudentID = studentID;
            this.Program = program;
            this.DateRegistered = dateRegistered;
            this.Enrollment = enrollment;
        }
        /// <summary>
        /// Compares the current student with another student based on their StudentID.
        /// </summary>
        /// <param name="other">The other student to compare with.</param>
        /// <returns></returns>
        /// <exception cref="ArgumentNullException"></exception>
        public int CompareTo(Student other)
        {
            if (other == null)
                throw new ArgumentNullException("other");
            

            return this.StudentID.CompareTo(other.StudentID);
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current student.  
        /// </summary>
        /// <param name="obj">The object to compare with the current student</param>
        /// <returns>if the specified object is equal to the current student True otherwise False</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (ReferenceEquals(obj, this))
                return true;
            if (obj.GetType() != GetType())
                return false;

            Student other = (Student)obj;

            return this.StudentID == other.StudentID &&
                this.Name == other.Name &&
                this.Email == other.Email &&
                this.PhoneNumber == other.PhoneNumber &&
                this.Address == other.Address &&
                this.Program == other.Program &&
                this.DateRegistered == other.DateRegistered &&
                this.Enrollment == other.Enrollment;

        }
        /// <summary>
        /// default hash function.
        /// </summary>
        /// <returns>A hash code for the current student.</returns>
        public override int GetHashCode()
        {
            return base.GetHashCode() ^ this.StudentID.GetHashCode();
        }

        /// <summary>
        /// Determines whether two student instances are equal.
        /// </summary>
        /// <param name="student1">The first student to compare</param>
        /// <param name="student2">The second student to compare</param>
        /// <returns></returns>
        public static bool operator == (Student student1, Student student2)
        {   
            return object.Equals(student1, student2);
        }
        /// <summary>
        /// Determines whether two student instances are not equal.
        /// </summary>
        /// <param name="student1">>The first student to compare</param>
        /// <param name="student2">The second student to compare></param>
        /// <returns>if the students are not equal True, otherwise False</returns>
        public static bool operator != (Student student1, Student student2)
        {
            return !(student1 == student2);
        }

        /// <summary>
        /// Returns a string that represents the current student.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "\nStudent Id: " + StudentID + "\nName: " + Name + "\nEmail: " + Email + "\nPhoneNumber : " + PhoneNumber + "\nAddress : " + Address +
                "\nRegistered date : " + DateRegistered +"\nEnrollment" + Enrollment;
        }

        
    }
}
