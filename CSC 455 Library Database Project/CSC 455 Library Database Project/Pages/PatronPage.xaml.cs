using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using CSC_455_Library_Database_Project.Pages;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CSC_455_Library_Database_Project
{
    /// <summary>
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class PatronPage : Page
    {
        private Window _container = null;

        public PatronPage(Window MainWindow)
        {
            InitializeComponent();
            _container = MainWindow;
        }

        private void logout_button_Click(object sender, RoutedEventArgs e)
        {
            Page LoginPage = new LoginPage(_container);
            _container.Content = LoginPage;
        }

        private void Return_books_button_Click(object sender, RoutedEventArgs e)
        {
            Page returnBooksPage = new ReturnBooksPage(_container);
            _container.Content = returnBooksPage;
        }

        private void Pay_fine_button_Click(object sender, RoutedEventArgs e)
        {
            Page payFinePage = new PayFinePage(_container);
            _container.Content = payFinePage;
        }

        private void View_checked_out_books_Click(object sender, RoutedEventArgs e)
        {
            Page viewCheckedOutBooksPage = new ViewLoanedBooksPage(_container);
            _container.Content = viewCheckedOutBooksPage;
        }

        private void Home_button_Click(object sender, RoutedEventArgs e)
        {
        
        }
    }
}
