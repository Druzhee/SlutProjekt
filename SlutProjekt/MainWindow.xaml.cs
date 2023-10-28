using System.Windows;

namespace SlutProjekt
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            RegisterUser registerUser = new();
            registerUser.Show();
            Close();
        }

        private void LogIn_Click(object sender, RoutedEventArgs e)
        {
            string username = txtusername.Text;
            string password = txtpassword.Password;


            foreach (var user in UserManger.Users)
            {
                if (user.Username == username && user.Password == password)
                {
                    // måste sätta en bool för den ska funka   
                }
            }

            bool logInResult = UserManger.LogInUser(username, password);
            if (logInResult)
            {
                TravelsWindow travelsWindow = new();
                travelsWindow.Show();
                Close();
            }
            else
            {
                MessageBox.Show("Wrong Username or Password!", "Warning");
            }
        }
    }
}
