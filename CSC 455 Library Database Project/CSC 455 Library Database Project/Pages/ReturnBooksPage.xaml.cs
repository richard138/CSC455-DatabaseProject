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
    /// Interaction logic for ReturnBooksPage.xaml
    /// </summary>
    public partial class ReturnBooksPage : Page
    {
        private Window _container;
        public ReturnBooksPage(Window MainWindow)
        {
            InitializeComponent();
            _container = MainWindow;
        }

        private void Pay_fine_button_Click(object sender, RoutedEventArgs e)
        {
            var payFinesPage = new PayFinePage(_container);
            _container.Content = payFinesPage;
        }

        private void View_checked_out_books_Click(object sender, RoutedEventArgs e)
        {
            var viewLoandedBooksPage = new ViewLoanedBooksPage(_container);
            _container.Content = viewLoandedBooksPage;
        }

        private void Home_button_Click(object sender, RoutedEventArgs e)
        {
            var patronPage = new PatronPage(_container);
            _container.Content = patronPage;
        }
    }
}
