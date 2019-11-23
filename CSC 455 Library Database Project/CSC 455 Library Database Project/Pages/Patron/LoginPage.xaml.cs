using System;
using System.Data;
using CSC_455_Library_Database_Project.Connection;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using CSC_455_Library_Database_Project.Pages;
using System.Windows.Input;
using MySql.Data.MySqlClient;

namespace CSC_455_Library_Database_Project
{

    public partial class LoginPage : Page
    {
        //stand up container Window which is passed to each page
        private Window _container = null;
        //Standup new connector class as class property should always be named _connection
        private Connector _connection = new Connector();
        public LoginPage(Window MainWindow)
        {
            //Must always do this to satisfy the Windows Fondation Presentation Gods
            InitializeComponent();
            //Set container object to the MainWindow Object, page content can be changed be setting the "Content" property to a Page Object
            _container = MainWindow;
            

        }

        private void Login_button_Click(object sender, RoutedEventArgs e)
        {
            //should always set cursur to wait cursor when executing a database query to provide feedback
            _container.Cursor = Cursors.Wait;

            //build queryString
            string queryString = "Select Card_No, Password From Borrowers Where Card_No=@cardNum and Password=@password";

            //add sql parameters
            _connection.addParameter("@cardNum", MySqlDbType.VarChar, 30, this.txtUserName.Text);
            _connection.addParameter("@password", MySqlDbType.VarChar, 30, this.txtPassword.Password);
            var ds = _connection.GetDataSet(queryString);

            //Always clear parameters after executing query
            _connection.ClearParameters();

            if (ds.Tables[0].Rows.Count == 1)
            {
                //If login succesful, take user to main patron page
                //The new pages are instantiated and passed the container object
                Page mainPage = new PatronPage(_container, txtUserName.Text);
                //To change what page is currently displayed, set the container object's "Content" property to a page object
                _container.Content = mainPage;
                //should always reset cursor back to arrow after processing is complete
                _container.Cursor = Cursors.Arrow;
            }
            else
            {
                _container.Cursor = Cursors.Arrow;
            }


        }


        private void Admin_login_button_Click(object sender, RoutedEventArgs e)
        {
            //takes user to admin login page
            Page adminLogin = new AdminLoginPage(_container);
            _container.Content = adminLogin;
        }

        private void exit_button_Click(object sender, RoutedEventArgs e)
        {
            //closes application
            _container.Close();
        }
    }
}
