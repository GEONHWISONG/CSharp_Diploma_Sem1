using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Part1_Hashing
{/// <summary>
 /// Represents a person with a name, email, phone number, and address.
 /// </summary>
    public class Person
    {
        /// <summary>
        /// 
        /// Gets or sets the name, email, phoneNumber and address of the person.
        /// </summary>
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public Address Address { get; set; }

        /// <summary>
        /// Initializes a new instance of the Class person (Constructor)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="email"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="address"></param>
        public Person(string name, String email, string phoneNumber, Address address)
        {
            this.Name = name;
            this.Email = email;               
            this.PhoneNumber = phoneNumber;
            this.Address = address;

        }
        /// <summary>
        /// Determines whether the specified object is equal to the current person.
        /// </summary>
        /// <param name="obj">The object to compare with the current person</param>
        /// <returns>if the specified object is equal to the current person True, otherwise False</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (ReferenceEquals(obj, this))
                return true;
            if (obj.GetType() != GetType())
                return false;

            Person other = (Person)obj;

            return this.Name == other.Name &&
                this.Email == other.Email &&
                this.PhoneNumber == other.PhoneNumber &&
                this.Address == other.Address;


        }
        /// <summary>
        /// 
        /// default hash function.
        /// </summary>
        /// <returns>A hash code for the current person.</returns>
        public override int GetHashCode()
        {
            return this.Name.GetHashCode() ^ this.Email.GetHashCode() ^ this.PhoneNumber.GetHashCode() ^ this.Address.GetHashCode();

        }
    }
}
