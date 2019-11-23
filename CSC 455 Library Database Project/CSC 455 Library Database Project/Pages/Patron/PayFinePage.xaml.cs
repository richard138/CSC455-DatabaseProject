using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using CSC_455_Library_Database_Project.Connection;
using MySql.Data.MySqlClient;

namespace CSC_455_Library_Database_Project.Pages
{
    /// <summary>
    /// Interaction logic for PayFinePage.xaml
    /// </summary>
    public partial class PayFinePage : Page
    {
        private Window _container = null;
        private String _user = null;
        private Int32 _owes = 0;
        private Connector _connection = new Connector();


        public PayFinePage(Window mainWindow, String user)
        {
            InitializeComponent();

            _container = mainWindow;
            _user = user;
            _owes = this.GetFines() ;
            
        }

        public Int32 GetFines()
        {
            _connection.addParameter("@user", MySqlDbType.Int64, 30, Int32.Parse(_user));
            string queryString = "Select * from Borrowers b join Fines f on b.Card_No = f.Card_No where b.Card_No = @user";
            var ds = _connection.GetDataSet(queryString);
            _connection.ClearParameters();

            return 10;
        }

        private void logout_button_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Home_button_Click(object sender, RoutedEventArgs e)
        {
            var patronPage = new PatronPage(_container, _user);
            _container.Content = patronPage;
        }

        private void View_checked_out_books_Click(object sender, RoutedEventArgs e)
        {
            var viewLoandedBooksPage = new ViewLoanedBooksPage(_container, _user);
            _container.Content = viewLoandedBooksPage;
        }

        private void Return_books_button_Click(object sender, RoutedEventArgs e)
        {
            Page returnBooksPage = new ReturnBooksPage(_container, _user);
            _container.Content = returnBooksPage;
        }

        private void Pay_fine_button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
