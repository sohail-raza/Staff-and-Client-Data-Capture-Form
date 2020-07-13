using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MattioliWoodsTask
{
    /// <summary>
    /// Staff variables and associated getters and setters for processing in other parts of the application.
    /// </summary>
    class Staff
    {
        /// <summary>
        /// strings to store the first name, last name and date of birth
        /// </summary>
        private string firstName;
        private string lastName;
        private string dob;

        /// <summary>
        /// Function to get the first name of a staff member. 
        /// </summary>
        /// <returns>staff member first name</returns>
        public string getFirstName()
        {
            return firstName;
        }
        /// <summary>
        /// Function to set the first name of a staff member.
        /// </summary>
        /// <param name="FirstName">first name to set for a staff member</param>
        public void setFirstName(string FirstName)
        {
            firstName = FirstName;
        }
        /// <summary>
        /// Function to get the last name of a staff member. 
        /// </summary>
        /// <returns>staff member last name</returns>
        public string getLastName()
        {
            return lastName;
        }
        /// <summary>
        /// Function to set the last name of a staff member.
        /// </summary>
        /// <param name="LastName">last name to set for a staff member</param>
        public void setLastName(string LastName)
        {
            lastName = LastName;
        }
        /// <summary>
        /// Function to get the date of birth of a staff member.
        /// </summary>
        /// <returns>date of birth of a staff member</returns>
        public string getDob()
        {
            return dob;
        }
        /// <summary>
        /// Function to set the date of birth of a staff member.
        /// </summary>
        /// <param name="Dob">date of birth to set for a staff member</param>
        public void setDob(string Dob)
        {
            dob = Dob;
        }





    }
}
