using Contracts;
using DAL.Model;
using Services;
using System;
using System.Threading.Tasks;
using System.Windows;

namespace client
{
    /// <summary>
    /// Interaction logic for ConsultantMenu.xaml
    /// </summary>
    public partial class ConsultantMenu : Window
    {
        private IMeetings meetings;
        private IUsersManagement UsersManagement;
        public ConsultantMenu()
        {
            InitializeComponent();
            meetings = new MeetingsManagement();
            UsersManagement = new UsersManagement();
            Init();
            DatePicker.SelectedDate = DateTime.Today;

        }
        private async void Init()
        {
            await InitUsers();
        }
        private async Task InitUsers()
        {
            usersLst.ItemsSource = await UsersManagement.GetUsers();
        }

        private void BackClick(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private async void SeeDetailsClick(object sender, RoutedEventArgs e)
        {
            if(usersLst.SelectedItem == null)
            {
                MessageBox.Show("User is Required", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            if(DatePicker.Text == string.Empty)
            {
                MessageBox.Show("Date is Required", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            var userIdInput = (usersLst.SelectedItem as User).UserId;
            
            var dateInput = DateTime.Parse(DatePicker.Text);

            MeetingsList.ItemsSource = await meetings.GetMeetingsForconsultant(userIdInput, dateInput);

        }

        private void CustomerManagementClick_Click(object sender, RoutedEventArgs e)
        {
            CustomerManagement customerManagement = new CustomerManagement();
            customerManagement.Show();
            this.Close();
        }
    }
}
