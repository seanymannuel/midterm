using System;
using System.Linq;
using System.Windows;

namespace midterm
{
    public partial class LoginForm : Window
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            string inputUsername = txtUsername.Text;
            string inputPassword = txtPassword.Password;

            if (!string.IsNullOrEmpty(inputUsername) && !string.IsNullOrEmpty(inputPassword))
            {
                // Proceed to login
                var user = GetUserRole(inputUsername, inputPassword);

                if (user != null)
                {
                    MessageBox.Show("Login Success", "Welcome Back", MessageBoxButton.OK, MessageBoxImage.Information);
                    var inventoryWindows = new inventory(user.UserType); // Pass UserType to the constructor
                    this.Hide();
                    inventoryWindows.Show();

                    // Check if the user is of type "user" and hide the search button
                    if (user.UserType == "user")
                    {
                        inventoryWindows.HideSearchButton();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Username and/or Password", "Login Failed", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            else
            {
                // Inform the user to input both username and password
                MessageBox.Show("Please input both username and password.", "Incomplete Information", MessageBoxButton.OK, MessageBoxImage.Exclamation);
            }
        }

        private Table_User GetUserRole(string inputUsername, string inputPassword)
        {
            return db.Table_Users.SingleOrDefault(u => u.UserID == inputUsername && u.Password == inputPassword);
        }
    }
}
