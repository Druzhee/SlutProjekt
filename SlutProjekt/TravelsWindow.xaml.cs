using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace SlutProjekt
{
    /// <summary>
    /// Interaction logic for TravelsWindow.xaml
    /// </summary>
    public partial class TravelsWindow : Window
    {
        List<Travel> userTravels = new List<Travel>();
        public TravelsWindow()
        {
            InitializeComponent();

            // Kolla vem är inloggad
            IUser loggedInUser = UserManger.signedInUser;

            // Kolla om det är en user eller en admin...
            if (loggedInUser.GetType() == typeof(User))
            {
                // OM det är en user..
                // Hämta dens resor
                User user = (User)loggedInUser;
                userTravels = user.Travels;
                if (userTravels != null)
                {
                    foreach (var travel in userTravels)
                    {
                        ListViewItem item = new();
                        item.Tag = travel;
                        item.Content = travel.Destination;

                        travelListView.Items.Add(item);
                    }
                }
                // Lägg till resorna i listviewen
                //foreach (var travel in userTravels)
                //{
                //    ListViewItem item = new();

                //    item.Tag = travel;
                //    item.Content = travel.Destination;

                //    travelListView.Items.Add(item);
                //}
            }
            else if (loggedInUser.GetType() == typeof(Admin))
            {
                //foreach(var user in UserManger.Users)
                //{
                //    List<Travel> userTravels = new List<Travel>();
                //    userTravels = user.
                //    ListViewItem item = new ListViewItem();
                //    item.Tag = user;
                //    item.Content = 
                //}
            }
            // OM det är en admin...
            // Hämta alla users resor
            // Lägg till dom i listviewen
        }

        private void btnSignOut_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainwidow = new();
            mainwidow.Show();
            Close();
        }

        private void btnInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Press Add Travel to Add a new travel. Press Detalis to show the travel details. Press Remove to remove a travel from the list. Press Sign Out to go back to Mainwindow.");
        }

        private void btnTravelDetails_Click(object sender, RoutedEventArgs e)
        {
            TravelDetails traveldetils = new TravelDetails();
            traveldetils.Show();
            Close();
        }

        private void btnAddTravel_Click(object sender, RoutedEventArgs e)
        {
            AddTravelDetails addTravelDetails = new();
            addTravelDetails.Show();
            Close();
        }

        private void btnRemoveTravel_Click(object sender, RoutedEventArgs e)
        {
           //userTravels = new List<Travel>();
           // int index = travelListView.SelectedIndex.;
           // userTravels.Remove(index);

        }
    }
}
