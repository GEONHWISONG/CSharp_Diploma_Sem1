using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1_Hashing
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Testing Address
            Address address1 = new Address(123, "Currie St", "Adelaide city", "5000", "Adelaide");
            Address address2 = new Address(123, "Currie St", "Adelaide city", "5000", "Adelaide");
            Address address3 = new Address(345, "Colley Tce", "Glenelg", "5045", "Adelaide");

            Console.WriteLine($"address1.Equals(address2) : {address1.Equals(address2)} (Expected : True)");
            Console.WriteLine($"address1.Equals(address3) : {address1.Equals(address3)} (Expected : False)");
            Console.WriteLine($"address1.GetHashCode() == address2.GetHashCode() : {address1.GetHashCode() == address2.GetHashCode()} (Expected : True)");
            Console.WriteLine($"address1.GetHashCode() != address3.GetHashCode() : {address1.GetHashCode() != address3.GetHashCode()} (Expected : True)");
            Console.WriteLine($"address1 HashCode : {address1.GetHashCode()} ");
            Console.WriteLine($"address2 HashCode : {address2.GetHashCode()} ");
            Console.WriteLine($"address3 HashCode : {address3.GetHashCode()} ");



            //Testing Subject
            Subject math = new Subject("math001", "math_basic", 3000);
            Subject history = new Subject("history001", "history_basic", 4000);
            Subject math2 = new Subject("math001", "math_basic", 3000);

            Console.WriteLine($"\nmath.Equals(math2) : {math.Equals(math2)} (Expected : True)");
            Console.WriteLine($"math.Equals(history) : {math.Equals(history)} (Expected : False)");
            Console.WriteLine($"math.GetHashCode() == math2.GetHashCode() : {math.GetHashCode() == math2.GetHashCode()} (Expected : True)");
            Console.WriteLine($"math.GetHashCode() != history.GetHashCode() : {math.GetHashCode() != history.GetHashCode()} (Expected : True)");

            Console.WriteLine($"math HashCode : {math.GetHashCode()} ");
            Console.WriteLine($"history HashCode : {history.GetHashCode()} ");
            Console.WriteLine($"math2 HashCode : {math2.GetHashCode()} ");

            // Testing Enrollment
            Enrollment enrollment1 = new Enrollment(DateTime.Now, "A", "Fall 2024", math);
            Enrollment enrollment2 = new Enrollment(DateTime.Now, "A", "Fall 2024", math);
            Enrollment enrollment3 = new Enrollment(DateTime.Now, "B+", "Fall 2024", history);

            Console.WriteLine($"\nenrollment1.Equals(enrollment2): {enrollment1.Equals(enrollment2)} (Expected: True)");
            Console.WriteLine($"enrollment1.Equals(enrollment3): {enrollment1.Equals(enrollment3)} (Expected: False)");
            Console.WriteLine($"enrollment1.GetHashCode() == enrollment2.GetHashCode(): {enrollment1.GetHashCode() == enrollment2.GetHashCode()} (Expected: True)");
            Console.WriteLine($"enrollment1.GetHashCode() != enrollment3.GetHashCode(): {enrollment1.GetHashCode() != enrollment3.GetHashCode()} (Expected: True)");

            Console.WriteLine($"enrollment1 HashCode : {enrollment1.GetHashCode()} ");
            Console.WriteLine($"enrollment2 HashCode : {enrollment2.GetHashCode()} ");
            Console.WriteLine($"enrollment3 HashCode : {enrollment3.GetHashCode()} ");

            // Testing Student
            Student student1 = new Student(1, "GEONHWI SONG", "geon.song@tafesa.com", "123-456-7890", address1, "Computer Science", DateTime.Now, enrollment1);
            Student student2 = new Student(1, "GEONHWI SONG", "geon.song@tafesa.com", "123-456-7890", address1, "Computer Science", DateTime.Now, enrollment1);
            Student student3 = new Student(2, "SOFIA VELASQUEZ", "sofia.velasquez@example.com", "098-765-4321", address3, "history", DateTime.Now, enrollment3);
            Console.WriteLine("\n" + student1.ToString());
            Console.WriteLine("\n");
            Console.WriteLine("\n" + student2.ToString());
            Console.WriteLine("\n");
            Console.WriteLine("\n" + student3.ToString());

            // Testing Student Equals method
            Console.WriteLine($"\nstudent1.Equals(student2): {student1.Equals(student2)} (Expected: True)");
            Console.WriteLine($"student1.Equals(student3): {student1.Equals(student3)} (Expected: False)");

            // Testing Student == operator
            Console.WriteLine($"student1 == student2: {student1 == student2} (Expected: True)");
            Console.WriteLine($"student1 != student3: {student1 != student3} (Expected: True)");

            // Testing Student GetHashCode
            Console.WriteLine($"student1.GetHashCode() == student2.GetHashCode(): {student1.GetHashCode() == student2.GetHashCode()} (Expected: True)");
            Console.WriteLine($"student1.GetHashCode() != student3.GetHashCode(): {student1.GetHashCode() != student3.GetHashCode()} (Expected: True)");

            // Testing Student CompareTo method
            Console.WriteLine($"student1.CompareTo(student2): {student1.CompareTo(student2)} (Expected: 0)");
            Console.WriteLine($"student1.CompareTo(student3) < 0: {student1.CompareTo(student3) < 0} (Expected: True)");
            Console.WriteLine($"student3.CompareTo(student1) > 0: {student3.CompareTo(student1) > 0} (Expected: True)");
            Console.ReadKey();

        }
    }
}
