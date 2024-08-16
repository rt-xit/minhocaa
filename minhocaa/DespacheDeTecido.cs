using Microsoft.Maui.Controls;

namespace minhocaa
{
    public partial class DespacheDeTecido : ContentPage
    {
        public DespacheDeTecido()
        {
            InitializeComponent();
        }

        private void OnClearButtonClicked(object sender, EventArgs e)
        {
            if (sender is Button button)
            {
                switch (button.CommandParameter)
                {
                    case "Fabric":
                        FabricEntry.Text = string.Empty;
                        break;
                    case "Location":
                        LocationEntry.Text = string.Empty;
                        break;
                    case "Quantity":
                        QuantityEntry.Text = string.Empty;
                        break;
                }
            }
        }

        private async void OnBackButtonClicked(object sender, EventArgs e)
        {
            // Lógica para voltar para a página anterior
            await Navigation.PopAsync();
        }

        private async void OnPurchaseButtonClicked(object sender, EventArgs e)
        {
            // Lógica para fazer a compra
            await DisplayAlert("Compra", "Sua compra foi realizada com sucesso!", "OK");
        }
    }
}
