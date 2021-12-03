using Contracts;
using DAL.Repository;
using Services;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// This class is for login to the system 
    /// </summary>
    public partial class MainWindow : Window
    {
        private IUsersManagement usersManagement;
        private ICustomer customer;
        private DbInitializer dbInitializer;
        public MainWindow()
        {
            InitializeComponent();
           
            usersManagement = new UsersManagement();
            customer = new CustomersMenegement();
            dbInitializer = new DbInitializer();
            DbInit().GetAwaiter();

        }

        /// <summary>
        /// Login function -  check if user is admin or consultant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void LoginClick(object sender, RoutedEventArgs e)
        {
            var usernameInput = username.Text;
            var passwordInput = password.Text;

            var res = await usersManagement.Login(usernameInput, passwordInput);

            if (res!=null)
            {
                if(((int)res.UserType) == 2)
                {
                    AdminWindow adminMenu = new AdminWindow();
                    adminMenu.Show();
                    
                    
                }
                else
                {
                    ConsultantMenu consultantMenu = new ConsultantMenu();
                    consultantMenu.Show();
                }
                
                this.Close();
                MessageBox.Show("Connected", "Ok", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                MessageBox.Show("Invalid username or password", "Error",MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        /// <summary>
        /// Reset password 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ResetPasswordClick(object sender, RoutedEventArgs e)
        {
            ResetPassword resetPassword = new ResetPassword();
            resetPassword.Show();
            this.Close();
        }

        /// <summary>
        /// This function will add data if there is no data exist, once the project is running for the first time
        /// </summary>
        /// <returns></returns>
        public async Task DbInit()
        {
            var getUsers =  await usersManagement.GetUsers();
            var getCustomers = await customer.GetCustomers();
            if(getCustomers.Count < 14 && getUsers.Count() < 2)
            {
                await dbInitializer.Initializer();
            }
        }
    }
}
