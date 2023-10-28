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
        }

        private void btnGoBack_Click(object sender, RoutedEventArgs e)
        {
            TravelsWindow travelsWindow = new();
            travelsWindow.Show();
            Close();
        }

        private void CmboLand_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }

        private void CmboMeetingDetails_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }

        private void CmboTravelers_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            object selectedItem = CmboTravelers.SelectedItem;
            
        }

        private void btnAddToTravelList_Click(object sender, RoutedEventArgs e)
        {
            bool City  = txtCity.Text.Trim().Length > 0;
            bool Travelers = CmboTravelers.SelectedItem != null;
            bool Land = CmboLand .SelectedItem != null;
            bool Meetingdetails = CmboMeetingDetails.SelectedItem != null;
            if (City && Travelers && Land && Meetingdetails )
            {
                TravelsWindow travelsWindow = new();
                travelsWindow.Show();   
                Close();
            }
            else
            {
                MessageBox.Show("incompleted form","Warning");
            }
            

        }
    }
}
