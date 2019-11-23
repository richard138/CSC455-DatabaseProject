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
    /// Interaction logic for AdminLoginPage.xaml
    /// </summary>
    public partial class AdminLoginPage : Page

    {
        private Window _container = null;

        public AdminLoginPage(Window mainWindow)
        {
            InitializeComponent();
            _container = mainWindow;
        }

        private void Back_button_Click(object sender, RoutedEventArgs e)
        {
            var loginPage = new LoginPage(_container);
            _container.Content = loginPage;
        }

        private void login_button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
