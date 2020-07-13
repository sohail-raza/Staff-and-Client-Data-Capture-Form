using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace MattioliWoodsTask
{
    /// <summary>
    /// This class exists to store various functions that are used across the scope of the program.
    /// These functions are useful for bounds checking, visual elements and data processing itself.
    /// </summary>
    class Validation
    {
        /// <summary>
        /// This function is tied to the WPF "GotFocus" event which fires when a user presses on a control.
        /// Controls can be anything ranging from a user pressing into a textbox to type or selecting a date on a date picker.
        /// In many cases for this program, the focus remover function is used to remove default text on a textbox.
        /// focus remover compared textbox input to a target string (e.g "Forename") and will then proceed to set the location to empty
        /// The target string is needed because otherwise any user input would disappear if the user pressed on the same control again.
        /// </summary>
        /// <param name="focusedString"> the default text on focused event. Typically is a .Text value from a textbox</param>
        /// <param name="targetString"> the string which focusedString is being compared to</param>
        /// <param name="location">location in which the new variable result should be stored</param>

        public void FocusRemover(string focusedString, string targetString, TextBox location)
        {

            if (string.Equals(focusedString, targetString, StringComparison.CurrentCultureIgnoreCase))
            {
                focusedString = "";
                location.Text = focusedString;
            }
        }

        /// <summary>
        /// this function will limit numbers in a field. 
        /// This is completed by checking if any of the values within an input string (name) contain a digit
        /// if a match is found and there are digits, a message box appears and a string resets the text within focused location.
        /// </summary>
        /// <param name="name">input string. Typically used for names as names should not contain numbers.</param>
        /// <param name="resetString">string that will replace the input string in case there is a match. Typically used for a default field value e.g "Post Code"</param>
        /// <param name="Location">output location the resetString</param>
        public void NumberRestrictionValidator(string name, string resetString, TextBox Location)
        {
            if (name.Any(char.IsDigit))
            {
                MessageBox.Show("Numbers are not permitted in a name");
                Location.Text = resetString;
            }

        }

        /// <summary>
        /// this function will limit letters in a field. 
        /// This is completed by checking if any of the values within an input string (name) contain a letter
        /// if a match is found and there are letters, a message box appears and a string resets the text within focused location.
        /// </summary>
        /// <param name="name">input string</param>
        /// <param name="resetString">string that will replace the input string in case there is a match</param>
        /// <param name="Location">output location the resetString</param>
        public void LetterRestrictionValidator(string name, string resetString, TextBox Location)
        {
            if (name.Any(char.IsLetter))
            {
                MessageBox.Show("Letters are not allowed in a date");
                Location.Text = resetString;
            }
        }
        /// <summary>
        /// This function is a bounds checker that will take in a focused string, a minimum bound limit of 0 to ensure the user does not try skipping the field and a location for the replacement text in case there is a match.
        /// </summary>
        /// <param name="focusedString">input string</param>
        /// <param name="maxBound">maximum input length variable</param>
        /// <param name="resetString">string that will replace the input string in case there is a match</param>
        /// <param name="location">output location the resetString</param>
        public void LengthValidation(string focusedString, int maxBound, string resetString, TextBox location)
        {
            if (focusedString.Length > maxBound || focusedString.Length == 0)
            {
                MessageBox.Show("Please supply a valid" + " " + resetString);
                location.Text = resetString;
            }
        }
        /// <summary>
        /// This function checks for special characters and does not allow them to be in an input string.
        /// The regex in this function matches commonly used special characters.
        /// </summary>
        /// <param name="unfocusedString">input string. This string is named unfocused string because this function is typically used on a LostFocus event</param>
        /// <param name="resetString">string that will replace the input string in case there is a match.</param>
        /// <param name="location">output location the resetString</param>
        public void SpecialCharsChecker(string unfocusedString, string resetString, TextBox location)
        {
            Regex specialCharsExp = new Regex("[*'\",_&!.#'%,@]");
            if (Regex.IsMatch(unfocusedString, specialCharsExp.ToString()))
            {
                MessageBox.Show("No special characters!");
                location.Text = resetString;
            }
        }

        /// <summary>
        /// Function that will check if a text field is left empty and will refill it. This is typically used on a LostFocus event as a way to 
        /// </summary>
        /// <param name="unfocusedString">input string. This string is named unfocused string because this function is typically used on a LostFocus event</param>
        /// <param name="originalString">string that will replace the input string in case there is a match.</param>
        /// <param name="location">output location the resetString</param>
        public void EmptyStringChecker(string unfocusedString, string originalString, TextBox location)
        {
            if (unfocusedString == "")
                location.Text = originalString;
        }

        /// <summary>
        /// Function that opens a connection with a given connection string and passes a parametised query (to prevent SQL injection attacks).
        /// Parametised queries are prepared beforehand and can be swapped in with variables.
        /// Comparisons are made to see if the default text is not used (as we do not want this information in the database) or if the fields are empty.
        /// Once the query has been processed, the connection to the database is closed. This is to ensure there are no unintended consequences if multiple instances of this function are fired.
        /// </summary>
        /// <param name="firstName">first name gathered from the corresponding get function</param>
        /// <param name="lastName">last name gathered from corresponding get</param>
        /// <param name="dob">date of birth gathered from the corresponding get</param>
        public void SubmitQuery(string firstName, string lastName, string dob)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=SOHAIL-PC;Initial Catalog=mattioliWoodsTaskTest;Integrated Security=True;Pooling=False");
            SqlCommand command;

            conn.Open();

            if (firstName == "" || lastName == "" || dob == "" ||
                 firstName == "Forename" || lastName == "Surname" || dob == "Date of Birth")
            {
                MessageBox.Show("Please enter some values");
                conn.Close();

                return;
            }
            else
            {
                command = new SqlCommand("INSERT INTO staff(firstname,surname,dateofbirth) VALUES (@firstname,@surname,@dateofbirth)", conn);
                command.Parameters.AddWithValue("@firstName", firstName);
                command.Parameters.AddWithValue("@surname", lastName);
                command.Parameters.AddWithValue("@dateofbirth", dob);
                command.ExecuteNonQuery();
                MessageBox.Show("Query Success");
                conn.Close();
            }

        }
        /// <summary>
        /// overload for client.cs. This is functionally the same as the original SubmitQuery but has been overloaded to accept more data.
        /// Function that opens a connection with a given connection string and passes a parametised query (to prevent SQL injection attacks).
        /// Parametised queries are prepared beforehand and can be swapped in with variables.
        /// Comparisons are made to see if the default text is not used (as we do not want this information in the database) or if the fields are empty.
        /// Once the query has been processed, the connection to the database is closed. This is to ensure there are no unintended consequences if multiple instances of this function are fired.
        /// </summary>
        /// <param name="firstName">first name gathered from the corresponding get function</param>
        /// <param name="lastName">first name gathered from the corresponding get function</param>
        /// <param name="dob">first name gathered from the corresponding get function</param>
        /// <param name="addressLine1">address line 1 name gathered from the corresponding get function</param>
        /// <param name="addressLine2">address line 2 name gathered from the corresponding get function</param>
        /// <param name="city">city name gathered from the corresponding get function</param>
        /// <param name="county">county name gathered from the corresponding get function</param>
        /// <param name="postCode">post code name gathered from the corresponding get function </param>
        public void SubmitQuery(string firstName, string lastName, string dob, string addressLine1, string addressLine2, string city, string county, string postCode)
        {


            SqlConnection conn = new SqlConnection(@"Data Source=SOHAIL-PC;Initial Catalog=mattioliWoodsTaskTest;Integrated Security=True;Pooling=False");
            SqlCommand command;

            conn.Open();

            if (firstName == "" || lastName == "" || dob == "" || addressLine1 == "" || city == "" || postCode == "" ||
               firstName == "Forename" || lastName == "Surname" || dob == "Date of Birth" || addressLine1 == "Address Line 1" || city == "Town/City" || postCode == "Post Code")
            {
                MessageBox.Show("Please enter some values");
                conn.Close();

                return;
            }
            else
            {
                command = new SqlCommand("INSERT INTO client(firstname,surname,dateofbirth,addressLine1,addressLine2,city,county,postCode) VALUES (@firstname,@surname,@dateofbirth,@addressLine1,@addressLine2,@city,@county,@postCode)", conn);
                command.Parameters.AddWithValue("@firstName", firstName);
                command.Parameters.AddWithValue("@surname", lastName);
                command.Parameters.AddWithValue("@dateofbirth", dob);
                command.Parameters.AddWithValue("@addressLine1", addressLine1);
                command.Parameters.AddWithValue("@addressLine2", addressLine2);
                command.Parameters.AddWithValue("@city", city);
                command.Parameters.AddWithValue("@county", county);
                command.Parameters.AddWithValue("@postCode", postCode);
                command.ExecuteNonQuery();
                MessageBox.Show("Query Success");
                conn.Close();
            }
        }




    }

}
