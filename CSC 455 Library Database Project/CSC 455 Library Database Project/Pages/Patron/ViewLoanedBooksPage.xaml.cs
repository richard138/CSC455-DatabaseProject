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
    /// Interaction logic for ViewLoanedBooksPage.xaml
    /// </summary>
    public partial class ViewLoanedBooksPage : Page
    {
        private Window _container = null;
        private String _user = null;

        public ViewLoanedBooksPage(Window MainWindow, String userName)
        {
            InitializeComponent();
            _container = MainWindow;
            _user = userName;
        }

        private void Pay_fine_button_Click(object sender, RoutedEventArgs e)
        {
            var payFinesPage = new PayFinePage(_container, _user);
            _container.Content = payFinesPage;
        }

        private void Home_button_Click(object sender, RoutedEventArgs e)
        {
            var patronPage = new PatronPage(_container, _user);
            _container.Content = patronPage;
        }

        private void Return_books_button_Click(object sender, RoutedEventArgs e)
        {
            Page returnBooksPage = new ReturnBooksPage(_container, _user);
            _container.Content = returnBooksPage;
        }

        private void View_checked_out_books_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
