using Contracts;
using Services;
using System.Windows;

namespace client
{
    /// <summary>
    /// Interaction logic for ResetPassword.xaml
    /// This class is for reset the password of the user
    /// </summary>
    public partial class ResetPassword : Window
    {
        private IUsersManagement usersManagement;
        public ResetPassword()
        {
            InitializeComponent();
            usersManagement = new UsersManagement();
        }

        private async void ResetPasswordClick(object sender, RoutedEventArgs e)
        {
            var usernameInput = username.Text;
            var passwordInput = password.Text;

            var res = await usersManagement.ResetPassword(usernameInput, passwordInput);

            if (res)
            {
                MainWindow mainWindow = new MainWindow();
                mainWindow.Show();
                
                this.Close();
                MessageBox.Show("Password changed!", "Ok", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Invalid Username", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void BackToLoginClick(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();

            this.Close();
        }
    }
}
