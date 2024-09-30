using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICTPRG547_Assessment1_WyattCoff
{
    public class Address
    {
        // Constants for default values
        private const string DEF_STREET_NUM = "No Street Number Provided";
        private const string DEF_STREET_NAME = "No Street Name Provided";
        private const string DEF_SUBURB = "No Suburb Provided";
        private const string DEF_POSTCODE = "No Postcode Provided";
        private const string DEF_STATE = "No State Provided";

        // Public properties for address details
        public string StreetNum { get; set; }
        public string StreetName { get; set; }
        public string Suburb { get; set; }
        public string Postcode { get; set; }
        public string State { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Address"/> class with default values.
        /// </summary>
        public Address() : this(DEF_STREET_NUM, DEF_STREET_NAME, DEF_SUBURB, DEF_POSTCODE, DEF_STATE)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Address"/> class with the specified values.
        /// </summary>
        /// <param name="streetNum">The street number of the address.</param>
        /// <param name="streetName">The street name of the address.</param>
        /// <param name="suburb">The suburb of the address.</param>
        /// <param name="postcode">The postcode of the address.</param>
        /// <param name="state">The state of the address.</param>
        public Address(string streetNum, string streetName, string suburb, string postcode, string state)
        {
            StreetNum = streetNum;
            StreetName = streetName;
            Suburb = suburb;
            Postcode = postcode;
            State = state;
        }

        /// <summary>
        /// Returns a string that represents the current address.
        /// </summary>
        /// <returns>
        /// A string containing the address in the format StreetNum StreetName, Suburb, State Postcode.
        /// </returns>
        public override string ToString()
        {
            return $"{StreetNum} {StreetName}, {Suburb}, {State} {Postcode}";
        }
    }
}
