using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Microsoft.Win32;
namespace SchoolSystem.Views
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }

        private void SelectImage_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png)| *.jpg; *.jpeg; *.png;";
            if (openFileDialog.ShowDialog() == true)
            {
                string imagePath = openFileDialog.FileName;
                SelectedImage.Visibility = Visibility.Visible;
                SelectedImage.Source = new BitmapImage(new Uri(imagePath));
                SelectImgTxt.Visibility = Visibility.Visible;
                SelectImgTxt.Text = imagePath;
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            FNameTextBox.Clear();
            MNameTextBox.Clear(); 
            LNameTextBox.Clear();
            AddressTextbox.Clear();
            Gender.Text = "";
            ContactTextbox.Clear();
            DOB.Text = null;
            PupilClass.Clear();
            SelectImgTxt.Text = "";
            SelectImgTxt.Visibility = Visibility.Hidden;
            SelectedImage.Visibility = Visibility.Hidden;

        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ContactTextbox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string nigeriaPhoneRegex = @"^(\+?234|0)(70|80|90)[123456789]\d{7}$";
            bool isValid = Regex.IsMatch(ContactTextbox.Text, nigeriaPhoneRegex);
            if (isValid is false)
            {
                PhoneChecker.Text = "not Ok";
            }
            else {
                PhoneChecker.Text = "Ok!";
            }
        }

        //private void SelectImgTxt_TextChanged(object sender, TextChangedEventArgs e)
        //{
        //    if (new Uri(SelectImgTxt.Text) is )
        //    {
        //        SelectedImage.Visibility = Visibility.Hidden;
        //    }
        //    {
        //        SelectedImage.Visibility = Visibility.Visible;
        //        SelectedImage.Source = new BitmapImage(new Uri(SelectImgTxt.Text));
        //    }
        //}
    }
}
