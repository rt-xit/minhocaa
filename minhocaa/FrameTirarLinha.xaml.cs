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
            InputEntry.Text = string.Empty;
        }

        private void OnCalculateButtonClicked(object sender, EventArgs e)
        {
            // Lógica para calcular o tempo aqui
            DisplayAlert("Calculando", "O cálculo está em andamento...", "OK");
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            // Lógica para voltar para a página anterior
            Navigation.PopAsync();
        }
    }
}