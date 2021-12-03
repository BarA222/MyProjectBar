using Contracts;
using Services;
using System;

namespace MenuDisplay
{
    class Display
    {
        private static IUsersManagement usersManagement = new UsersManagement();
        private static ICustomer customer = new CustomerMenegement();
        private static IMeetings meetings = new MeetingsManagement();
        public static void Menu()
        {

            Console.ReadKey();

            Console.WriteLine("Please select an option");
            Console.WriteLine();
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Reset password");
            Console.WriteLine();
            Console.WriteLine("0. Quit the Program");


        }

        public static void SubMenu()
        {
            Console.WriteLine("Please select an option");
            Console.WriteLine();
            Console.WriteLine("1. Add new meeting");
            Console.WriteLine("2. View your meetings in a specific date");
            Console.WriteLine("3. Edit a meeting");
            Console.WriteLine("4. Delete a meeting");

        }


        public static bool LoginToSystem()
        {
            Console.WriteLine("Login:");

            Console.WriteLine("Enter userName: ");
            string userName = Console.ReadLine();
            Console.WriteLine("Enter password: ");
            string password = Console.ReadLine();

            var user = usersManagement.Login(userName, password);
            if (user != null)
            {
                Console.WriteLine($"Logged in");
                return true;
            }
            else
            {
                Console.WriteLine($"UserName or password is incorrect");
                return false;
            }
        }

        public static void ResetMyPassword()
        {
            Console.WriteLine($"Reset password:");

            Console.WriteLine($"Enter your userName: ");
            string userName = Console.ReadLine();
            Console.WriteLine($"Enter your new password: ");
            string newPassword = Console.ReadLine();


            usersManagement.ResetPassword(userName, newPassword);
            Console.WriteLine("Password has been changed succefully");
        }

        public static void AddNewMeeting()
        {
            Console.WriteLine("Enter User Id: ");
            int userId = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Customer Id: ");
            int customerId = int.Parse(Console.ReadLine());
            Console.WriteLine("Subject of the meeting: ");
            string subject = Console.ReadLine();
            Console.WriteLine("Description of the meeting: ");
            string description = Console.ReadLine();

            meetings.AddNewMeeting(userId, customerId, description, subject);
        }
        public static void Failure(string message = "")
        {
            Console.WriteLine();
            Console.BackgroundColor = ConsoleColor.Red;

            if (string.IsNullOrEmpty(message))
                Console.WriteLine("Failed");
            else
                Console.WriteLine(message);

            Console.ResetColor();
        }


        //Will be the appoimtnets in the specific date
        //public static void Post(Post post)
        //{
        //    Console.WriteLine();
        //    Console.BackgroundColor = ConsoleColor.DarkGreen;
        //    Console.WriteLine("Post Details");
        //    Console.WriteLine("-------------------");
        //    Console.WriteLine($"PostID: {post.PostId}, published on: {post.DatePublished}");
        //    Console.WriteLine($"Title: {post.Title}");
        //    Console.WriteLine($"Body: {post.Body}");

        //    Console.ResetColor();
        //}


        static void Main(string[] args)
        {
            while (true)
            {
                Menu();
                var option = Console.ReadLine();

                if (option.Equals("0"))
                    break;

                switch (option)
                {
                    case "1":

                        bool result = LoginToSystem();
                        while (result)
                        {
                            SubMenu();
                            var option2 = Console.ReadLine();
                            switch (option2)
                            {
                                case "1":
                                    AddNewMeeting();
                                    break;

                            }
                        }

                        break;

                    case "2":

                        Display.ResetMyPassword();

                        break;

                    default:
                        Display.Failure("Invalid Option");
                        break;
                }
            }


        }
    }
}
