public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void Voltar_Clicked(object sender, EventArgs e)
    {
        // Lógica para quando o botão "Voltar" é clicado
        // Por exemplo, navegar para outra página
        Navigation.PopAsync();
    }
}