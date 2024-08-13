
using Microsoft.Maui.Controls;

namespace minhocaa
{
    public partial class FrameAcabamento : ContentPage
    {
        public FrameAcabamento()
        {
            InitializeComponent();
        }

        private void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            // Clear the text in the Entry field
            inputEntry.Text = string.Empty;
        }

        private void OnCalculateButtonClicked(object sender, EventArgs e)
        {
            // Add your logic here for what happens when the "=" button is clicked
            DisplayAlert("Calculation", "Calculation logic goes here.", "OK");
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            // Logic to navigate back or close the page
            Navigation.PopAsync();
        }
    }
}
