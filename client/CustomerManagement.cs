using Contracts;
using DAL.Model;
using Services;
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

namespace client
{
    /// <summary>
    /// Interaction logic for CustomerManagement.xaml
    /// This class is for consultants to view all customers
    /// </summary>
    public partial class CustomerManagement : Window
    {
        private ICustomer customer;
       
        public CustomerManagement()
        {
            InitializeComponent();
            customer = new CustomersMenegement();
            Init();
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

       
        private void BackClick_Click(object sender, RoutedEventArgs e)
        {
                ConsultantMenu consultantMenu = new ConsultantMenu();
                consultantMenu.Show();
                this.Close();
        }
    }
}
