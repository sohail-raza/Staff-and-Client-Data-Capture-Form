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
using MattioliWoodsTask;


namespace MattioliWoodsTask
{
    /// <summary>
    /// Interaction logic for ClientRegister.xaml
    /// ClientRegister.xaml is the view for the application when the client button has been pressed on the navigation bar.
    /// All successful queries are placed within the database table dbo.client (Server Explorer -> sohail-pc.mattioliWoodsTaskTest.dbo -> Tables -> Client -> Show Table Data)
    /// </summary>
    public partial class ClientRegister : Window
    {
        // instance of validation class that is used for functions relating to user control and inputs.
        Validation validationCheck = new Validation();
        // instance of the staff class that contains getter and setter functions for data storage and initialisation.
        Client clientMember = new Client();



        public ClientRegister()
        {
            InitializeComponent();

            //credits to https://snipplr.com/view/8314/html-uk-counties-select-box for the list of UK counties.
            //list of UK counties to populate a combo box that is used for selecting a county.
            List<string> counties = new List<string>();
            counties.Add("Bedfordshire");
            counties.Add("Berkshire");
            counties.Add("Bristol");
            counties.Add("Buckinghamshire");
            counties.Add("Cambridgeshire");
            counties.Add("Cheshire");
            counties.Add("City of London");
            counties.Add("Cornwall");
            counties.Add("Cumbria");
            counties.Add("Derbyshire");
            counties.Add("Devon");
            counties.Add("Dorset");
            counties.Add("Durham");
            counties.Add("East Riding of Yorkshire");
            counties.Add("East Sussex");
            counties.Add("Essex");
            counties.Add("Gloucestershire");
            counties.Add("Greater London");
            counties.Add("Greater Manchester");
            counties.Add("Hampshire");
            counties.Add("Herefordshire");
            counties.Add("Hertfordshire");
            counties.Add("Isle of Wight");
            counties.Add("Kent");
            counties.Add("Lancashire");
            counties.Add("Leicestershire");
            counties.Add("Lincolnshire");
            counties.Add("Merseyside");
            counties.Add("Norfolk");
            counties.Add("North Yorkshire");
            counties.Add("Northamptonshire");
            counties.Add("Northumberland");
            counties.Add("Nottinghamshire");
            counties.Add("Oxfordshire");
            counties.Add("Rutland");
            counties.Add("Shropshire");
            counties.Add("Somerset");
            counties.Add("South Yorkshire");
            counties.Add("Staffordshire");
            counties.Add("Suffolk");
            counties.Add("Surrey");
            counties.Add("Tyne and Wear");
            counties.Add("Warwickshire");
            counties.Add("West Midlands");
            counties.Add("West Sussex");
            counties.Add("West Yorkshire");
            counties.Add("Wiltshire");
            counties.Add("Worcestershire");
            counties.Add("Anglesey");
            counties.Add("Brecknockshire");
            counties.Add("Caernarfonshire");
            counties.Add("Carmarthenshire");
            counties.Add("Cardiganshire");
            counties.Add("Denbighshire");
            counties.Add("Flintshire");
            counties.Add("Glamorgan");
            counties.Add("Merioneth");
            counties.Add("Monmouthshire");
            counties.Add("Montgomeryshire");
            counties.Add("Pembrokeshire");
            counties.Add("Radnorshire");
            counties.Add("Aberdeenshire");
            counties.Add("Angus");
            counties.Add("Argyllshire");
            counties.Add("Ayrshire");
            counties.Add("Banffshire");
            counties.Add("Berwickshire");
            counties.Add("Buteshire");
            counties.Add("Cromartyshire");
            counties.Add("Caithness");
            counties.Add("Clackmannanshire");
            counties.Add("Dumfriesshire");
            counties.Add("Dunbartonshire");
            counties.Add("East Lothian");
            counties.Add("Fife");
            counties.Add("Inverness-shire");
            counties.Add("Kincardineshire");
            counties.Add("Kinross");
            counties.Add("Kirkcudbrightshire");
            counties.Add("Lanarkshire");
            counties.Add("Midlothian");
            counties.Add("Morayshire");
            counties.Add("Nairnshire");
            counties.Add("Orkney");
            counties.Add("Peeblesshire");
            counties.Add("Perthshire");
            counties.Add("Renfrewshire");
            counties.Add("Ross-shire");
            counties.Add("Roxburghshire");
            counties.Add("Selkirkshire");
            counties.Add("Shetland");
            counties.Add("Stirlingshire");
            counties.Add("Sutherland");
            counties.Add("West Lothian");
            counties.Add("Wigtownshire");
            counties.Add("Antrim");
            counties.Add("Armagh");
            counties.Add("Down");
            counties.Add("Fermanagh");
            counties.Add("Londonderry");
            counties.Add("Tyrone");

            // loops through the counties and adds them to a list that is then being used to populate the combo box.
            foreach (var county in counties)
            {
                clientCountyBox.Items.Add(county);
            }
            //default value so the combobox always has default data
            clientCountyBox.SelectedIndex = 0;


        }

        /// <summary>
        /// Onclick function that will generate the staffMember instance and will begin setting up fields for further processing.
        /// In the case of a client, a forename, date of birth, address box, address box 2, city, county, post code is required for entry.
        /// The staffSubmitQuery then retrieves all of the set values and uses them as variables for a parametised query. 
        /// This is will be discussed in depth within the Validation.cs
        /// 
        /// Address line 2 is non mandatory and set to empty if the value is default to ensure the data could appear as empty in the database.
        /// This will eliminate the possibility of unnecessary data entering the address line 2 field.
        /// </summary>
        private void ClientSubmitData_Click(object sender, RoutedEventArgs e)
        {
            clientMember.setFirstName(clientForenameBox.Text);
            clientMember.setLastName(clientSurnameBox.Text);
            clientMember.setDob(dateOfBirthPicker.SelectedDate.ToString());
            clientMember.setAddressLine1(clientAddrBox1.Text);
            clientMember.setAddressLine2(clientAddrBox2.Text);
            clientMember.setCity(clientCityBox.Text);
            clientMember.setCounty(clientCountyBox.Text);
            clientMember.setPostCode(clientPostCodeBox.Text);

            if(clientMember.getAddressLine2().ToString() == "Address Line 2")
            {
                clientMember.setAddressLine2("");
            }

            validationCheck.SubmitQuery(clientMember.getFirstName(), clientMember.getLastName(), clientMember.getDob(), clientMember.getAddressLine1(),
                clientMember.getAddressLine2(), clientMember.getCity(), clientMember.getCounty(), clientMember.getPostCode());

        }

        /// <summary>
        /// function to remove the default text field upon clicking the first name box. This ensures the user does not have to backspace default text.
        /// </summary>
        private void RemoveForenameText(object sender, RoutedEventArgs e)
        {
            validationCheck.FocusRemover(clientForenameBox.Text, "Forename", clientForenameBox);

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
            validationCheck.SpecialCharsChecker(clientForenameBox.Text, "Forename", clientForenameBox);
            validationCheck.NumberRestrictionValidator(clientForenameBox.Text, "Forename", clientForenameBox);
            validationCheck.EmptyStringChecker(clientForenameBox.Text, "Forename", clientForenameBox);

        }

        /// <summary>
        /// function to remove the default text field upon clicking the surname box. This ensures the user does not have to backspace default text.
        /// </summary>
        private void RemoveSurnameText(object sender, RoutedEventArgs e)
        {
            validationCheck.FocusRemover(clientSurnameBox.Text, "Surname", clientSurnameBox);
        }

        /// <summary>
        /// function relating to the several surname specific requirements.
        /// A more thorough exaplanation of each function can be found in Validation.cs
        /// SpecialCharsChecker check to see if special characters are inserted. Hyphens are allowed since some names do have hyphens in them.
        /// NumberRestrictionValidator check to see if number characters are inserted.
        /// EmptyStringChecker checks if the string is empty if focus is lost to go back to the default value.
        /// </summary>
        private void ValidateSurnameText(object sender, RoutedEventArgs e)
        {
            validationCheck.SpecialCharsChecker(clientSurnameBox.Text, "Surname", clientSurnameBox);
            validationCheck.NumberRestrictionValidator(clientSurnameBox.Text, "Surname", clientSurnameBox);
            validationCheck.EmptyStringChecker(clientSurnameBox.Text, "Surname", clientSurnameBox);
        }


        /// <summary>
        /// function to remove the default text field upon clicking the address box. This ensures the user does not have to backspace default text.
        /// </summary>
        private void RemoveAddr1BoxText(object sender, RoutedEventArgs e)
        {
            validationCheck.FocusRemover(clientAddrBox1.Text, "Address Line 1", clientAddrBox1);

        }

        /// <summary>
        /// function relating to the several address box 1 specific requirements.
        /// A more thorough exaplanation of each function can be found in Validation.cs
        /// SpecialCharsChecker check to see if special characters are inserted.
        /// EmptyStringChecker checks if the string is empty if focus is lost to go back to the default value.
        /// </summary>
        private void ValidateAddr1BoxText(object sender, RoutedEventArgs e)
        {
            validationCheck.SpecialCharsChecker(clientAddrBox1.Text, "Address Line 1", clientAddrBox1);
            validationCheck.EmptyStringChecker(clientAddrBox1.Text, "Address Line 1", clientAddrBox1);

        }

        /// <summary>
        /// function to remove the default text field upon clicking the address box 2. This ensures the user does not have to backspace default text.
        /// </summary>
        private void RemoveAddr2BoxText(object sender, RoutedEventArgs e)
        {
            validationCheck.FocusRemover(clientAddrBox2.Text, "Address Line 2", clientAddrBox2);
        }

        /// <summary>
        /// function relating to the several address box 2 specific requirements.
        /// A more thorough exaplanation of each function can be found in Validation.cs
        /// SpecialCharsChecker check to see if special characters are inserted.
        /// EmptyStringChecker checks if the string is empty if focus is lost to go back to the default value.
        /// </summary>
        private void ValidateAddr2BoxText(object sender, RoutedEventArgs e)
        {
            validationCheck.SpecialCharsChecker(clientAddrBox2.Text, "Address Line 2", clientAddrBox2);
            validationCheck.EmptyStringChecker(clientAddrBox2.Text, "Address Line 2", clientAddrBox2);
        }

        /// <summary>
        /// function to remove the default text field upon clicking the city box. This ensures the user does not have to backspace default text.
        /// </summary>
        private void RemoveCityBoxText(object sender, RoutedEventArgs e)
        {
            validationCheck.FocusRemover(clientCityBox.Text, "Town/City", clientCityBox);
        }

        /// <summary>
        /// function relating to the several city specific requirements.
        /// A more thorough exaplanation of each function can be found in Validation.cs
        /// SpecialCharsChecker check to see if special characters are inserted.
        /// EmptyStringChecker checks if the string is empty if focus is lost to go back to the default value.
        /// </summary>
        private void ValidateCityBoxText(object sender, RoutedEventArgs e)
        {
            validationCheck.SpecialCharsChecker(clientCityBox.Text, "Town/City", clientCityBox);
            validationCheck.EmptyStringChecker(clientCityBox.Text, "Town/City", clientCityBox);
        }

        /// <summary>
        /// function to remove the default text field upon clicking the post code box. This ensures the user does not have to backspace default text.
        /// </summary>
        private void RemovePostCodeBoxText(object sender, RoutedEventArgs e)
        {
            validationCheck.FocusRemover(clientPostCodeBox.Text, "Post Code", clientPostCodeBox);
        }

        /// <summary>
        /// Function that will check the post code and will enforce the post code is not left empty if unfocused.
        /// The function also ensures the post code is no larger than 8 digits as this is the limit for UK post codes
        /// </summary>
        private void ClientPostCodeLengthCheck(object sender, RoutedEventArgs e)
        {
            validationCheck.LengthValidation(clientPostCodeBox.Text, 8, "Post Code", clientPostCodeBox);
        }

        private void StaffBtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow window = new MainWindow();
            window.Show();
            window.Width = 400;
            window.Height = 800;
            this.Close();
        }

        /// <summary>
        /// Gets the county from the county list. A list of these counties can be observed in  ClientRegister.Xaml.cs
        /// </summary>
        private void ClientCountyBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            clientMember.setCounty(clientCountyBox.SelectedValue.ToString());
        }

    }
}
