using System.Windows;
using System.Windows.Controls;

namespace SlutProjekt
{
    /// <summary>
    /// Interaction logic for TravelDetails.xaml
    /// </summary>
    public partial class TravelDetails : Window
    {
        public TravelDetails(Travel travel)
        {
            InitializeComponent();

            txtCity.Text = travel.Destination;
            txtNumberOfTravelers.Text = travel.Travellers.ToString();
            txtCountry.Text = travel.Country.ToString();

            if (travel.GetType() == typeof(Vacation))
            {
                Vacation vacation = (Vacation)travel;

                IsVacationCheckBox.IsChecked = true;

                if (vacation.AllInclusive)
                {
                    IsAllInclusive.IsChecked = true;
                }
            }
            else if (travel.GetType() == typeof(WorkTrip))
            {
                WorkTrip workTrip = (WorkTrip)travel;

                IsWorkTrip.IsChecked = true;

                txtMeetingDetails.Text = workTrip.MeetingDetails.ToString();
            }
        }
        private void txtNumberOfTravelers_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnGoBackToMainWindow_Click(object sender, RoutedEventArgs e)
        {
            TravelsWindow travelsWindow = new TravelsWindow();
            travelsWindow.Show();
            Close();
        }
    }
}
