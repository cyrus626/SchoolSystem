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
using System.Windows.Shapes;

namespace SchoolSystem.Views
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string loginText = LoginType.Text ;
            HeaderText.Text = $"{loginText} login";
            switch (loginText)
            {
                case "Admin":
                    AdminLogin();
                    break;
                case "Staff":
                    StaffLogin();
                    break;
                case "Visitor":
                    Visitor();
                    break;
            }
        }
        
        public void StaffLogin()
        {

        }
        public void AdminLogin()
        {

        }
        public void Visitor()
        {

        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
