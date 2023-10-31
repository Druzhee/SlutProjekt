using SlutProjekt.Enums;
using System;
using System.Windows;
using System.Windows.Controls;

namespace SlutProjekt
{
    /// <summary>
    /// Interaction logic for AddTravelDetails.xaml
    /// </summary>
    public partial class AddTravelDetails : Window
    {
        bool CheckBox = false;
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
            bool alliclusive = CheckBox;
            string City = txtCity.Text;
            int Travellers = CmboTravelers.SelectedIndex;
            Country Land = (Country)CmboLand.SelectedItem;
            //Country Land = 0;
            //try
            //{
            //   Land = (Country)CmboLand.SelectedIndex;
            //}
            //catch(NullReferenceException)
            //{
            //    MessageBox.Show("sho");
            //}   
            string meetingDetails = txtMeetingdetalis.Text;

            if (txtCity.Text != "" && CmboTravelers.SelectedIndex > -1 && CmboLand.SelectedIndex > -1 && CmboTypeOfTrip.SelectedIndex > -1 )
            {
                if (CmboTypeOfTrip.SelectedIndex == 0) 
                {
                    WorkTrip newWorktrip = new(meetingDetails, Travellers, City, Land);
                    TravelManager.AddTravel(newWorktrip);

                }
                else if (CmboTypeOfTrip.SelectedIndex == 1)
                {
                    Vacation newVacation = new(alliclusive, Travellers, City, Land);
                    TravelManager.AddTravel(newVacation);

                }
                TravelsWindow travelsWindow = new();
                travelsWindow.Show();
                Close();
            }
            else
            {
                MessageBox.Show("incompleted form", "Warning");
            }
        }

        private void CmboLand_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            CheckBox = true;
        }
    }
}
