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

        // Instance variables for address details
        private string streetNum;
        private string streetName;
        private string suburb;
        private string postcode;
        private string state;

        /// <summary>
        /// Initializes a new instance of the <see cref="Address"/> class with default values.
        /// </summary>
        public Address()
        {
            streetNum = DEF_STREET_NUM;
            streetName = DEF_STREET_NAME;
            suburb = DEF_SUBURB;
            postcode = DEF_POSTCODE;
            state = DEF_STATE;
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
            this.streetNum = streetNum;
            this.streetName = streetName;
            this.suburb = suburb;
            this.postcode = postcode;
            this.state = state;
        }

        /// <summary>
        /// Gets or sets the street number of the address.
        /// </summary>
        public string StreetNum { get; set; }

        /// <summary>
        /// Gets or sets the street name of the address.
        /// </summary>
        public string StreetName { get; set; }

        /// <summary>
        /// Gets or sets the suburb of the address.
        /// </summary>
        public string Suburb { get; set; }

        /// <summary>
        /// Gets or sets the postcode of the address.
        /// </summary>
        public string Postcode { get; set; }

        /// <summary>
        /// Gets or sets the state of the address.
        /// </summary>
        public string State { get; set; }

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


