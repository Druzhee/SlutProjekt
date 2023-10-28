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

        private void CmboTravelers_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            CmboTravelers.Items.Clear();

            // Add numbers from 1 to 9 to the ComboBox
            for (int i = 1; i <= 11; i++)
            {
                CmboTravelers.Items.Add(i);
            }

        }
    }
}
