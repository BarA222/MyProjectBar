using Contracts;
using Services;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
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

namespace client
{
    /// <summary>
    /// Interaction logic for CustomerManagementForAdmin.xaml
    /// This class is for admin user to view all customers and add new customers
    /// </summary>
    public partial class CustomerManagementForAdmin : Window
    {
        private ICustomer customer;
        public CustomerManagementForAdmin()
        {
            InitializeComponent();
            customer = new CustomersMenegement();
            Init();
        }

        private async void AddCustomerClick(object sender, RoutedEventArgs e)
        {
            var personalIdInput = personalId.Text;
            var firstNameInput = firstName.Text;
            var lastNameInput = lastName.Text;
            var addressInput = address.Text;

            var res = await customer.AddNewCustomer(personalIdInput, firstNameInput, lastNameInput, addressInput);
            if (res.IsSuccess)
            {
                MessageBox.Show(res.Content, "Ok", MessageBoxButton.OK, MessageBoxImage.Information);
                await InitGetCustomers();
                personalId.Clear();
                firstName.Clear();
                lastName.Clear();
                address.Clear();
            }
            else
            {
                MessageBox.Show(res.Content, "Error", MessageBoxButton.OK, MessageBoxImage.Error);

            }
            
        }

        private async Task InitGetCustomers()
        {
            CustomersDG.ItemsSource = await customer.GetCustomers();
        }

        private void BackClick_Click(object sender, RoutedEventArgs e)
        {
            AdminWindow adminWindow = new AdminWindow();
            adminWindow.Show();
            this.Close();
        }

        private async void Init()
        {
            await initCustomerMetting();
            await InitCustomers();
        }


        private async Task initCustomerMetting()
        {
            CustomersAndMeetingDG.ItemsSource = await customer.GetCustomersAppointments();
        }

        private async Task InitCustomers()
        {
            CustomersDG.ItemsSource = await customer.GetCustomers();
        }
    }
}
