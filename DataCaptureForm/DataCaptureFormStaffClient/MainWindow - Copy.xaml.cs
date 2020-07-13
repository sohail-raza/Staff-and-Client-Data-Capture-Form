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

namespace MattioliWoodsTask
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void removeStaffForenameText(object sender, RoutedEventArgs e)
        {
            if (staffForenameBox.Text == "Forename")
                staffForenameBox.Text = "";
        }

        private void removeStaffSurnameText(object sender, RoutedEventArgs e)
        {
            if (staffSurnameBox.Text == "Surname")
                staffSurnameBox.Text = "";
        }

        private void removestaffDOBBoxText(object sender, RoutedEventArgs e)
        {
            if (staffDOBBox.Text == "Date of Birth")
                staffDOBBox.Text = "";
        }

        private void staffSubmitData_Click(object sender, RoutedEventArgs e)
        {
            //getUserDetails();
            staffSubmitQuery();
        }

        private void getUserDetails()
        {
            //TO DO: SQL Injection attack prevention
            string firstName = staffForenameBox.Text;
            string lastName = staffSurnameBox.Text;
            string dob = staffDOBBox.Text;
        }




        private void staffSubmitQuery()
        {


            //TO DO: CREATE THE DATABASE FOR THE CLIENT MACHINE. CHECK IF DATABASE ALREADY EXISTS ON MACHINE
            /*
            string FirstName = staffForenameBox.Text;
            string Surname = staffSurnameBox.Text;
            string Dob = staffDOBBox.Text;

            string conn = "datasource=127.0.0.1;port=3306;username=root;password=;database=mattiolitasktestdb";
            string query = "INSERT INTO staff(firstname,surname,dateofbirth) VALUES(@firstname,@surname,@dateofbirth)";
            MySqlConnection databaseConnection = new MySqlConnection(conn);
            databaseConnection.Open();
            MySqlCommand command = new MySqlCommand(query, databaseConnection);
            command.CommandTimeout = 60;

            command.Parameters.AddWithValue("@firstName", staffForenameBox.Text);
            command.Parameters.AddWithValue("@surname", staffSurnameBox.Text);
            command.Parameters.AddWithValue("@dateofbirth", staffDOBBox.Text);
            command.ExecuteNonQuery();

            databaseConnection.Close();
            */

            SqlConnection conn = new SqlConnection(@"Data Source=SOHAIL-PC;Initial Catalog=mattioliWoodsTaskTest;Integrated Security=True;Pooling=False");
            SqlCommand command;

            conn.Open();
            //TODO: bound checking
            string firstName = staffForenameBox.Text.ToString();
            string lastName = staffSurnameBox.Text.ToString();
            string dob = staffDOBBox.Text.ToString();

            if (firstName != "" || lastName != "" || dob != "")
                if (firstName != "Forename" || lastName != "Surname" || dob != "Date of Birth")


                {
                command = new SqlCommand("INSERT INTO staff(firstname,surname,dateofbirth) VALUES (@firstname,@surname,@dateofbirth)", conn);
                command.Parameters.AddWithValue("@firstName", firstName);
                command.Parameters.AddWithValue("@surname", lastName);
                command.Parameters.AddWithValue("@dateofbirth", lastName);
                command.ExecuteNonQuery();
                MessageBox.Show("Query Success");


            }
            else
            {
                MessageBox.Show("Query failed");
            }
            conn.Close();

        }



    }


}