using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part1_Hashing
{
    /// <summary>
    /// Represents an address with street number, street name, suburb, postcode, and state.
    /// </summary>
    public class Address
    {
        /// <summary>
        /// Gets or sets the street number, Name, suburb, postcode and state.
        /// </summary>
        public int StreetNum { get; set; }
        public string StreetName { get; set; }
        public string Suburb { get; set; }
        public string Postcode { get; set; }
        public string State { get; set; }

        /// <summary>
        /// Initializes a new instance of the Class Address (constoructor)
        /// </summary>
        /// <param name="streetNum"></param>
        /// <param name="streetName"></param>
        /// <param name="suburb"></param>
        /// <param name="postcode"></param>
        /// <param name="state"></param>
        public Address(int streetNum, string streetName, string suburb, string postcode, string state)
        {
            this.StreetNum = streetNum;
            this.StreetName = streetName;
            this.Suburb = suburb;
            this.Postcode = postcode;
            this.State = state;
            

        }
        /// <summary>
        /// Determines whether the specified object is equal to the current address.
        /// </summary>
        /// <param name="obj">The object to compare with the current address.</param>
        /// <returns>if the specified object is equal to the current address return true otherwise false</returns>
        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (ReferenceEquals(obj, this))
                return true;
            if (obj.GetType() != GetType())
                return false;

            Address other = (Address)obj;

            return this.StreetNum == other.StreetNum &&
                this.StreetName == other.StreetName &&
                this.Suburb == other.Suburb &&
                this.Postcode == other.Postcode &&
                this.State == other.State;

        }

        /// <summary>
        /// default hash function.
        /// </summary>
        /// <returns>A hash code for the current address.</returns>
        public override int GetHashCode()
        {
            return StreetNum.GetHashCode() ^ StreetName.GetHashCode() ^ Suburb.GetHashCode() ^ Postcode.GetHashCode() ^ State.GetHashCode();
        }
        /// <summary>
        /// Determines whether two address instances are equal.
        /// </summary>
        /// <param name="address1">The first address to compare.</param>
        /// <param name="address2">The second address to compare.</param>
        /// <returns>if the addresses are equal true otherwise false</returns>
        public static bool operator ==(Address address1, Address address2)
        {
            
            return object.Equals(address1, address2);
        }
        /// <summary>
        /// Determines whether two address instances are not equal.
        /// </summary>
        /// <param name="address1">The first address to compare</param>
        /// <param name="address2">The second address to compare</param>
        /// <returns></returns>
        public static bool operator != (Address address1, Address address2)
        {
            return !(address1 == address2);
        }

        /// <summary>
        /// Returns a string that represents the current address.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "SteetNumber : " + StreetNum + " // Street Name : " + StreetName + " // Suburb : " + Suburb + " // Postcode : " + Postcode + " // State : " + State; 
        }
    }
    }
