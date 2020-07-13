using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace MattioliWoodsTask
{

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// MainWindow.xaml is the default view for the application. (Staff register).
    /// All successful queries are placed within the database table dbo.staff. (Server Explorer -> sohail-pc.mattioliWoodsTaskTest.dbo -> Tables -> Staff -> Show Table Data)
    /// </summary>
    public partial class MainWindow : Window
    {
        // instance of validation class that is used for functions relating to user control and inputs.
        Validation validationCheck = new Validation();
        // instance of the staff class that contains getter and setter functions for data storage and initialisation.
        Staff staffMember = new Staff();

        public MainWindow()
        {

            InitializeComponent();
        }

        
        /// <summary>
        /// function to remove the default text field upon clicking the first name box. This ensures the user does not have to backspace default text.
        /// </summary>

        private void RemoveForenameText(object sender, RoutedEventArgs e)
        {
            validationCheck.FocusRemover(staffForenameBox.Text, "Forename", staffForenameBox);
        }

        /// <summary>
        /// function relating to the several forename specific requirements.
        /// A more thorough exaplanation of each function can be found in Validation.cs
        /// SpecialCharsChecker check to see if special characters are inserted. Hyphens are allowed since some names do have hyphens in them.
        /// NumberRestrictionValidator check to see if number characters are inserted.
        /// EmptyStringChecker checks if the string is empty if focus is lost to go back to the default value.
        /// </summary>

        private void ValidateForenameText(object sender, RoutedEventArgs e)
        {
            validationCheck.SpecialCharsChecker(staffForenameBox.Text, "Forename", staffForenameBox);
            validationCheck.NumberRestrictionValidator(staffForenameBox.Text, "Forename", staffForenameBox);
            validationCheck.EmptyStringChecker(staffForenameBox.Text, "Forename", staffForenameBox);

        }

        /// <summary>
        /// function to remove the default text field upon clicking the surname box. This ensures the user does not have to backspace default text.
        /// </summary>
        private void RemoveSurnameText(object sender, RoutedEventArgs e)
        {
            validationCheck.FocusRemover(staffSurnameBox.Text, "Surname", staffSurnameBox);

        }

        /// <summary>
        /// function relating to the several forename specific requirements.
        /// A more thorough exaplanation of each function can be found in Validation.cs
        /// SpecialCharsChecker check to see if special characters are inserted. Hyphens are allowed since some names do have hyphens in them.
        /// NumberRestrictionValidator check to see if number characters are inserted.
        /// EmptyStringChecker checks if the string is empty if focus is lost to go back to the default value.
        /// </summary>
        private void ValidateSurnameText(object sender, RoutedEventArgs e)
        {
            validationCheck.SpecialCharsChecker(staffSurnameBox.Text, "Surname", staffSurnameBox);
            validationCheck.NumberRestrictionValidator(staffSurnameBox.Text, "Surname", staffForenameBox);
            validationCheck.EmptyStringChecker(staffSurnameBox.Text, "Surname", staffSurnameBox);

        }

        /// <summary>
        /// Onclick function that will generate the staffMember instance and will begin setting up fields for further processing.
        /// In the case of a staffMember, a forename, surname and their date of birth is required for entry.
        /// The staffSubmitQuery then retrieves all of the set values and uses them as variables for a parametised query. 
        /// This is will be discussed in depth within the Validation.cs
        /// </summary>
        private void StaffSubmitData_Click(object sender, RoutedEventArgs e)
        {
            staffMember.setFirstName(staffForenameBox.Text);
            staffMember.setLastName(staffSurnameBox.Text);
            staffMember.setDob(dateOfBirthPicker.SelectedDate.ToString());
            validationCheck.SubmitQuery(staffMember.getFirstName(), staffMember.getLastName(), staffMember.getDob());
        }

        /// <summary>
        /// Displays the ClientRegister page.
        /// ClientRegister is required for instance generator as the ClientRegister is the page itself and an instance of it is created.
        /// A note on windows in WPF, height and width must be manually defined even if the ClientRegister has user defined proportions proprtions with the target page's XAML.
        /// MainWindow is closed once the target page has been opened.
        /// </summary>

        private void ClientBtn_Click(object sender, RoutedEventArgs e)
        {


            ClientRegister window = new ClientRegister();
            window.Show();
            window.Width = 400;
            window.Height = 800;
            this.Close();

        }


    }


}