using SlutProjekt.Enums;
using System;
using System.Windows;

namespace SlutProjekt
{
    /// <summary>
    /// Interaction logic for AddTravelDetails.xaml
    /// </summary>
    public partial class AddTravelDetails : Window
    {
        public AddTravelDetails()
        {
            InitializeComponent();
            CmboTypeOfTrip.Items.Add("Work Trip");
            CmboTypeOfTrip.Items.Add("Vacation");

            foreach (Country country in Enum.GetValues(typeof(Country)))
            {
                CmboLand.Items.Add(country);
            }
        }

        private void btnGoBack_Click(object sender, RoutedEventArgs e)
        {
            TravelsWindow travelsWindow = new();
            travelsWindow.Show();
            Close();
        }



        private void CmboMeetingDetails_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (CmboTypeOfTrip.SelectedItem == "Work Trip")
            {
                txtMeetingdetalis.Visibility = Visibility.Visible;
                ALLInclusive.Visibility = Visibility.Hidden;


            }
            else if (CmboTypeOfTrip.SelectedItem == "Vacation")
            {
                ALLInclusive.Visibility = Visibility.Visible;
                txtMeetingdetalis.Visibility = Visibility.Hidden;


            }

        }

        private void CmboTravelers_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            object selectedItem = CmboTravelers.SelectedItem;

        }

        private void btnAddToTravelList_Click(object sender, RoutedEventArgs e)
        {
            bool City = txtCity.Text.Trim().Length > 0;
            bool Travelers = CmboTravelers.SelectedItem != null;
            bool Land = CmboLand.SelectedItem != null;
            bool TypOfTrip = CmboTypeOfTrip.SelectedItem != null;

            if (City && Travelers && Land && TypOfTrip)
            {
                Country selectedCountry = (Country)CmboLand.SelectedItem;
                TravelsWindow travelsWindow = new();
                travelsWindow.Show();
                Close();
            }
            else
            {
                MessageBox.Show("incompleted form", "Warning");
            }


        }
    }
}
