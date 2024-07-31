public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void Button_Nao_Clicked(object sender, EventArgs e)
    {
        // Lógica para quando o botão "Não" é clicado
        DisplayAlert("Aviso", "Agendamento cancelado.", "OK");
    }

    private void Button_Sim_Clicked(object sender, EventArgs e)
    {
        // Lógica para quando o botão "Sim" é clicado
        DisplayAlert("Confirmação", "Agendamento confirmado.", "OK");
    }

    private void Button_Voltar_Clicked(object sender, EventArgs e)
    {
        // Lógica para quando o botão "Voltar" é clicado
        // Por exemplo, navegar para outra página
        Navigation.PopAsync();
    }
}