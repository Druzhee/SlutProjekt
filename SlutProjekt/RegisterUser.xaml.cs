using System.Windows;

namespace SlutProjekt
{
    /// <summary>
    /// Interaction logic for RegisterUser.xaml
    /// </summary>
    public partial class RegisterUser : Window
    {

        public RegisterUser()
        {
            InitializeComponent();
        }

        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new();
            mainWindow.Show();
            Close();
        }


        private void btnReg_Click(object sender, RoutedEventArgs e)
        {
            string Username = txtRegUsername.Text;
            string Password = txtRegPassword.Password;

            bool addUserResult = UserManger.AddUser(new User(Username, Password));

            if (addUserResult)
            {
                // Det funkade att lägga till en ny användare
                MainWindow mainWindow = new();
                mainWindow.Show();
                Close();
            }
            else
            {
                // Det funkade INTE att lägga till en ny användare

                MessageBox.Show("Failed to register a new user. Username might already be taken.", "Warning!");
            }
        }

       
    }
}
