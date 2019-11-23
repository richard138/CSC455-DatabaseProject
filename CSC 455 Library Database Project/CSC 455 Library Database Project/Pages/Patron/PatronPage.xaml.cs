using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using CSC_455_Library_Database_Project.Pages;
using CSC_455_Library_Database_Project.Connection;
using MySql.Data.MySqlClient;
using System.Windows.Data;

namespace CSC_455_Library_Database_Project
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class PatronPage : Page
    {
        private Window _container = null;
        private String _user = null;
        private Connector _connection = new Connector();

        public PatronPage(Window MainWindow, String userName)
        {
            InitializeComponent();
            _container = MainWindow;
            _user = userName;

        }

        private void logout_button_Click(object sender, RoutedEventArgs e)
        {
            Page LoginPage = new LoginPage(_container);
            _container.Content = LoginPage;
        }

        private void Return_books_button_Click(object sender, RoutedEventArgs e)
        {
            Page returnBooksPage = new ReturnBooksPage(_container, _user);
            _container.Content = returnBooksPage;
        }

        private void Pay_fine_button_Click(object sender, RoutedEventArgs e)
        {
            Page payFinePage = new PayFinePage(_container, _user);
            _container.Content = payFinePage;
        }

        private void View_checked_out_books_Click(object sender, RoutedEventArgs e)
        {
            Page viewCheckedOutBooksPage = new ViewLoanedBooksPage(_container, _user);
            _container.Content = viewCheckedOutBooksPage;
        }

        private void Home_button_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private string buildWhere()
        {
            StringBuilder where = new StringBuilder();
            string emptyCheck = txtAuthor.Text + txtTitle.Text;

            if (emptyCheck == string.Empty)
            {
                return string.Empty;
            }
            where.Append("where ");

            if(txtAuthor.Text != string.Empty)
            {
                where.AppendFormat("Author_Name like @author ");
            }

            if (txtTitle.Text != string.Empty && txtAuthor.Text != string.Empty)
            {
                where.AppendFormat(" and Title like @title ");
            }   
            if (txtTitle.Text != string.Empty && txtAuthor.Text == string.Empty)
             { 
                where.AppendFormat("title like @title");
            }
            return where.ToString();
        }

        private void search_button_Click(object sender, RoutedEventArgs e)
        {
            _connection.addParameter("@author", MySqlDbType.VarChar, 30, "%" + txtAuthor.Text + "%");
            _connection.addParameter("@title", MySqlDbType.VarChar, 30, "%" + txtTitle.Text + "%");
            string queryString = "Select b.ISBN as ISBN, Title, Author_Name as Author, " +
                "Publisher_Name as Publisher, No_of_copies as Copies, Branch_Name as Branch " +
                " from Books b Join Book_Authors ba on b.ISBN = ba.ISBN join Book_Copies bc on ba.ISBN = bc.ISBN join Branches br on bc.Branch_ID = br.Branch_ID " + buildWhere();
            var ds = _connection.GetDataSet(queryString);
            _connection.ClearParameters();
            dgBookResults.SetBinding(ItemsControl.ItemsSourceProperty, new Binding { Source = ds.Tables[0] });

        }

        private void btnCheckout_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
