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

namespace CSC_455_Library_Database_Project.Pages
{
    /// <summary>
    /// Interaction logic for PayFinePage.xaml
    /// </summary>
    public partial class PayFinePage : Page
    {
        private Window _container = null;
        public PayFinePage(Window mainWindow)
        {
            InitializeComponent();
            _container = mainWindow;
        }

        private void logout_button_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Home_button_Click(object sender, RoutedEventArgs e)
        {
            var patronPage = new PatronPage(_container);
            _container.Content = patronPage;
        }

        private void View_checked_out_books_Click(object sender, RoutedEventArgs e)
        {
            var viewLoandedBooksPage = new ViewLoanedBooksPage(_container);
            _container.Content = viewLoandedBooksPage;
        }

        private void Return_books_button_Click(object sender, RoutedEventArgs e)
        {
            Page returnBooksPage = new ReturnBooksPage(_container);
            _container.Content = returnBooksPage;
        }

        private void Pay_fine_button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
