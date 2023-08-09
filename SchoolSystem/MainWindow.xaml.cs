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
using SchoolSystem.Views;
namespace SchoolSystem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string name, age, pupilClass;
            name = "Ade"; age = "4"; pupilClass = "Primary four";
            PupilRecord.Items.Add($"{name} {age} {pupilClass}");
        }
        private void PupReg_Click(object sender, RoutedEventArgs e)
        {
            Register register = new Register();
            register.Show();
        }
        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            MenuItem loginOptions = sender as MenuItem;
            string loginOptionString = loginOptions.Header.ToString();
            Login login = new Login();
            //login.LoginType.SelectedItem = loginOptionString;
            //login.HeaderText.Text = loginOptionString;
            login.Show();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
