using Microsoft.Maui.Controls;

namespace minhocaa
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnButtonClicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                DisplayAlert("Button Clicked", $"You clicked: {button.Text}", "OK");
            }
        }
    }
}