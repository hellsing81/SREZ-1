
using Laboratory.Models;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace Laboratory.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для Auth.xaml
    /// </summary>
    public partial class Auth : Page
    {
        public Auth()
        {
            InitializeComponent();
        }

      

   
        

        private void Btn(object sender, RoutedEventArgs e)

        {

            {
                AccountData user = App.DBConnection.AccountData.FirstOrDefault(c => c.Login == Login.Text && c.Password == Password.Password);
                try
                {
                    if (user != null)
                    {
                        NavigationService.Navigate(new Pages.MainMenu(1, user.FullName));
                        MessageBox.Show("Вы успешно авторизировались!");
                    }
                    else
                    {
                        MessageBox.Show("Аккаунт не найден!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Произошла ошибка соединения с базой данных!");
                }
            }
        }

        private void Button_MouseDown(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Password.Visibility = Visibility.Collapsed;
            vision.Visibility = Visibility.Visible;
            vision.Text = Password.Password;
        }

        private void Button_MouseUp(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            Password.Visibility = Visibility.Visible;
            vision.Visibility = Visibility.Collapsed;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
