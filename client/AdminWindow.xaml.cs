using Contracts;
using DAL.Model;
using Services;
using System;
using System.Data;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace client
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        private readonly IMeetings meetings;
        private readonly ICustomer customers;
        private readonly IUsersManagement usersManagement;
        public Meeting CurrentMeeting { get; set; }
        public Meeting UpdatedMeeting { get; set; }
        public AdminWindow()
        {
            InitializeComponent();

            meetings = new MeetingsManagement();
            customers = new CustomersMenegement();
            usersManagement = new UsersManagement();
            CurrentMeeting = new Meeting();
            UpdatedMeeting = new Meeting();
            Init();
            DatePicker.SelectedDate = DateTime.Today;
        }

        private async void Init()
        {
            await InitMeeting();
            await InitUsers();
            await InitCustomers();
        }

        private async Task InitUsers()
        {
            usersLst.ItemsSource = await usersManagement.GetUsers();
        }

        private async Task InitCustomers()
        {
            customersLst.ItemsSource = await customers.GetCustomers();
        }

        private async void AddMeetingClick(object sender, RoutedEventArgs e)
        {
            if (usersLst.SelectedItem == null)
            {
                MessageBox.Show("User is Required", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            var userId = (usersLst.SelectedItem as User).UserId;

            if (customersLst.SelectedItem == null)
            {
                MessageBox.Show("Customer is Required", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            var customerId = (customersLst.SelectedItem as Customer).CustomerId;
            var subjectInput = subject.Text;
            var descriptionInput = description.Text;

            var res = await meetings.AddNewMeeting(userId, customerId, subjectInput, descriptionInput);
            if (res.IsSuccess)
            {
                await InitMeeting();
                MessageBox.Show(res.Content, "Ok", MessageBoxButton.OK, MessageBoxImage.Information);

                subject.Clear();
                description.Clear();
            }
            else
            {
                MessageBox.Show(res.Content, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private async Task InitMeeting()
        {
            MeetingDG.ItemsSource = await meetings.GetMeeting();
        }

        private async void DeleteMeeting(object s, RoutedEventArgs e)
        {
            CurrentMeeting = (s as FrameworkElement).DataContext as Meeting;

            var res = await meetings.DeleteMeeting(CurrentMeeting.MeetingId);
            if (res.IsSuccess)
            {
                await InitMeeting();
                MessageBox.Show(res.Content, "Ok", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
                MessageBox.Show(res.Content, "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }



        private void UpdateMeetingForEditClick(object s, RoutedEventArgs e)
        {
            CurrentMeeting = (Meeting)MeetingDG.SelectedItem;
            UpdateMeetingGrid.DataContext = CurrentMeeting;
            
        }

        private async void UpdateMeeting(object sender, RoutedEventArgs e)
        {
            if(DatePicker.Text == string.Empty)
            {
                MessageBox.Show("Date is required", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            var dateInput = DateTime.Parse(DatePicker.Text);

            CurrentMeeting.UpdateDate(dateInput);
            var res = await meetings.UpdateMeeting(CurrentMeeting);

            if (res.IsSuccess)
            {
                MessageBox.Show(res.Content, "Ok", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else 
                MessageBox.Show(res.Content, "Error", MessageBoxButton.OK, MessageBoxImage.Error);

            await InitMeeting();
        }

        private void BackClick_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void CustomerManageClick_Click(object sender, RoutedEventArgs e)
        {
            CustomerManagementForAdmin customerManagementFromAdmin = new CustomerManagementForAdmin();
            customerManagementFromAdmin.Show();
            this.Close();
        }
    }
}
