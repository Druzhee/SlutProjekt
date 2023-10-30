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

            UpdateUi();

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
            ListViewItem selectedItem = (ListViewItem)travelListView.SelectedItem;
            Travel selectedTravel = (Travel)selectedItem.Tag;


            TravelDetails traveldetils = new TravelDetails(selectedTravel);
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
            // Hitta inloggade användaren
            IUser loggedInUser = UserManger.signedInUser;

            // Är användaren User?
            if (loggedInUser.GetType() == typeof(User))
            {
                // Casta om IUser till User
                User user = (User)loggedInUser;
                // Hämta vårt selectade item (resan som ska tas bort)
                ListViewItem selectedItem = (ListViewItem)travelListView.SelectedItem;
                // Hämta vår selectade Travel ur ITEMETS tag-property
                Travel selectedTravel = (Travel)selectedItem.Tag;
                // Ta bort resan från användarens lista
                user.Travels.Remove(selectedTravel);
                // Rensa UI-listan och uppdatera den
                UpdateUi();
            }
            else if (loggedInUser.GetType() == typeof(Admin))
            {
                Admin Admin = (Admin)loggedInUser;
                ListViewItem selectedItem = (ListViewItem)travelListView.SelectedItem;
                Travel selectedTravel = (Travel)selectedItem.Tag;

                // Loopa över alla users
                // Ta bort resan 

                foreach (var user in UserManger.Users)
                {
                    if (user is User)
                    {
                        User u = (User)user;

                        for (int i = 0; i < u.Travels.Count; i++)
                        {
                            if (u.Travels[i] == selectedTravel)
                            {
                                u.Travels.Remove(selectedTravel);
                            }
                        }
                    }
                }

                UpdateUi();
            }
        }

        private void UpdateUi()
        {
            travelListView.Items.Clear();

            // Kolla vem är inloggad
            IUser loggedInUser = UserManger.signedInUser;

            // Kolla om det är en user eller en admin...
            if (loggedInUser.GetType() == typeof(User))
            {
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
            }
            else if (loggedInUser.GetType() == typeof(Admin))
            {
                foreach (var user in UserManger.Users)
                {
                    if (user.GetType() == typeof(User))
                    {
                        User u = (User)user; List<Travel> userTravels = new List<Travel>();

                        userTravels = u.Travels;

                        foreach (Travel travel in userTravels)
                        {
                            ListViewItem item = new();
                            item.Tag = travel;
                            item.Content = travel.Destination;

                            travelListView.Items.Add(item);
                        }
                    }
                }
            }
        }
    }
}
