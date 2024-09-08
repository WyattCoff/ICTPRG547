using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace ICTPRG547_Assessment1_WyattCoff
{
    public class Person
    {
        // Constants for default values
        private const string DEFAULT_NAME = "No Name Provided";
        private const string DEFAULT_EMAIL = "No Email Provided";
        private const string DEFAULT_PHONE_NUMBER = "No Phone Number Provided";
        private static readonly Address DEFAULT_ADDRESS = new Address();

        // Instance variables for person details
        private string name;
        private string email;
        private string phoneNumber;
        private Address address;

        /// <summary>
        /// Default constructor that initializes a person with default values.
        /// </summary>
        public Person()
        {
            name = DEFAULT_NAME;
            email = DEFAULT_EMAIL;
            phoneNumber = DEFAULT_PHONE_NUMBER;
            address = DEFAULT_ADDRESS;
        }

        /// <summary>
        /// Initializes a new instance of the Person class with the specified name, email, phone number, and address.
        /// </summary>
        /// <param name="name">The name of the person.</param>
        /// <param name="email">The email address of the person.</param>
        /// <param name="phoneNumber">The phone number of the person.</param>
        /// <param name="address">The address of the person.</param>
        public Person(string name, string email, string phoneNumber, Address address)
        {
            this.name = name;
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.address = address;
        }

        /// <summary>
        /// Gets or sets the name of the person.
        /// </summary>
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        /// <summary>
        /// Gets or sets the email address of the person.
        /// </summary>
        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        /// <summary>
        /// Gets or sets the phone number of the person.
        /// </summary>
        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        /// <summary>
        /// Gets or sets the address of the person.
        /// </summary>
        public Address Address
        {
            get { return address; }
            set { address = value; }
        }

        /// <summary>
        /// Returns a string that represents the current person.
        /// </summary>
        /// <returns>A string containing the person's name, email, phone number, and address.</returns>
        public override string ToString()
        {
            return $"[Name: {Name}, Email: {Email}, Phone Number: {PhoneNumber}, Address: {Address}]";
        }
    }
}


