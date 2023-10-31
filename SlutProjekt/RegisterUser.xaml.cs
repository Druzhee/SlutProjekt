using SlutProjekt.Enums;
using System;
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

            foreach (Country country in Enum.GetValues(typeof(Country)))
            {
                txtChooseACountry.Items.Add(country);
            }
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
            string ChooseACountry = txtChooseACountry.Text;
            bool addUser = UserManger.AddUser(new User(Username, Password));

            if (addUser != null && Username != "" && Password != "" && txtChooseACountry.SelectedIndex > -1)
            {
                // Det funkade att lägga till en ny användare
                MessageBox.Show("User added.");
                MainWindow mainWindow = new();
                mainWindow.Show();
                Close();
            }
            else
            {
                // Det funkade INTE att lägga till en ny användare

                MessageBox.Show("Failed to register a new user. Username might already be taken. or check your inputs", "Warning!");
            }
        }

        private void txtChooseACountry_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

            foreach (Country country in Enum.GetValues(typeof(Country)))
            {
                txtChooseACountry.Items.Add(country);
            }
        }
    }
}
