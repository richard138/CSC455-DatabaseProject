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
    /// Interaction logic for LoginPage.xaml
    /// </summary>
    public partial class LoginPage : Page
    {
        private Window _container = null;
        public LoginPage(Window MainWindow)
        {
            InitializeComponent();
            _container = MainWindow;

        }

        private void Login_button_Click(object sender, RoutedEventArgs e)
        {
            Page mainPage = new PatronPage(_container);
            _container.Content = mainPage;
        }


        private void Admin_login_button_Click(object sender, RoutedEventArgs e)
        {
            Page adminLogin = new AdminLoginPage(_container);
            _container.Content = adminLogin;
        }
    }
}
