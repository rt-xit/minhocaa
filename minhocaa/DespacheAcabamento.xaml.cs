using Microsoft.Maui.Controls;

namespace minhocaa
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnClearButtonClicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            if (button != null)
            {
                string parameter = button.CommandParameter as string;
                switch (parameter)
                {
                    case "Quantity":
                        QuantityEntry.Text = string.Empty;
                        break;
                    case "Location":
                        LocationEntry.Text = string.Empty;
                        break;
                    case "Time":
                        TimeEntry.Text = string.Empty;
                        break;
                }
            }
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            // Lógica para voltar para a página anterior
            Navigation.PopAsync();
        }

        private void OnScheduleButtonClicked(object sender, EventArgs e)
        {
            // Lógica para fazer o agendamento
            DisplayAlert("Agendamento", "O agendamento foi realizado com sucesso!", "OK");
        }
    }
}