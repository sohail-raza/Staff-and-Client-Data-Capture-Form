using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MattioliWoodsTask
{
    /// <summary>
    /// Client variables and associated getters and setters for processing in other parts of the application.
    /// </summary>
    class Client
    {
        /// <summary>
        /// client related variables. Clients are required to give home address details as well as their date of birth, first and last name.
        /// </summary>
        private string firstName;
        private string lastName;
        private string dob;
        private string addressLine1;
        private string addressLine2;
        private string city;
        private string county;
        private string postCode;

        /// <summary>
        /// Function to retrieve the first name of a client
        /// </summary>
        /// <returns>Client first name</returns>
        public string getFirstName()
        {
            return firstName;
        }

        /// <summary>
        /// Sets the first name of a client.
        /// </summary>
        /// <param name="FirstName">first name to set</param>
        public void setFirstName(string FirstName)
        {
            firstName = FirstName;
        }
        /// <summary>
        /// Function to retrieve the last name of a client
        /// </summary>
        /// <returns>Client last name</returns>
        public string getLastName()
        {
            return lastName;
        }

        /// <summary>
        /// Function to set the last name of a client
        /// </summary>
        /// <param name="LastName">last name to set</param>
        public void setLastName(string LastName)
        {
            lastName = LastName;
        }

        /// <summary>
        /// Function to get the date of birth of a client
        /// </summary>
        /// <returns>Client date of birth</returns>
        public string getDob()
        {
            return dob;
        }

        /// <summary>
        /// Function to set the date of birth of a client
        /// </summary>
        /// <param name="Dob">Client data of birth to set</param>
        public void setDob(string Dob)
        {
            dob = Dob;
        }

        /// <summary>
        /// Function to get the first address line of a client
        /// </summary>
        /// <returns>Client first address line</returns>
        public string getAddressLine1()
        {
            return addressLine1;
        }
        /// <summary>
        /// Function to set the first address line of a client
        /// </summary>
        /// <param name="AddressLine1">Client first address to set</param>
        public void setAddressLine1(string AddressLine1)
        {
            addressLine1 = AddressLine1;
        }
        /// <summary>
        /// Function to get the second address line of a client
        /// </summary>
        /// <returns>Client non mandatory second address</returns>
        public string getAddressLine2()
        {
            return addressLine2;
        }
        /// <summary>
        /// Function to set the second address line of a client
        /// </summary>
        /// <param name="AddressLine2">second address line to set</param>
        public void setAddressLine2(string AddressLine2)
        {
            addressLine2 = AddressLine2;
        }

        /// <summary>
        /// Function to get the city address line of a client
        /// </summary>
        /// <returns>Client city to get</returns>
        public string getCity()
        {
            return city;
        }
        /// <summary>
        /// Function to set the city address line of a client
        /// </summary>
        /// <param name="City">Function to set the city of a client</param>
        public void setCity(string City)
        {
            city = City;
        }

        /// <summary>
        /// Function to get the county address line of a client
        /// </summary>
        /// <returns>returns the county</returns>
        public string getCounty()
        {
            return county;
        }
        /// <summary>
        /// Function to set the county address line of a client 
        /// </summary>
        /// <param name="County">county of a client</param>
        public void setCounty(string County)
        {
            county = County;
        }
        /// <summary>
        /// Function to get a clients post code 
        /// </summary>
        /// <returns>returns the post code of a client</returns>
        public string getPostCode()
        {
            return postCode;
        }
        /// <summary>
        ///  Function to set the post code of a client
        /// </summary>
        /// <param name="PostCode">post code of a client</param>
        public void setPostCode(string PostCode)
        {
            postCode = PostCode;
        }

    }
}
