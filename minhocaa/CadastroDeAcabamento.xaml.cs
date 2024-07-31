public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void Colaboradores_Clicked(object sender, EventArgs e)
    {
        // Lógica para quando o botão "Colaboradores" é clicado
        DisplayAlert("Colaboradores", "Em breve será implementada a funcionalidade para gerenciar colaboradores.", "OK");
    }

    private void Colaborador_Clicked(object sender, EventArgs e)
    {
        // Lógica para quando um colaborador é clicado
        var button = (Button)sender;
        DisplayAlert("Colaborador", $"Você clicou em {button.Text}", "OK");
    }

    private void Voltar_Clicked(object sender, EventArgs e)
    {
        // Lógica para quando o botão "Voltar" é clicado
        // Por exemplo, navegar para outra página
        Navigation.PopAsync();
    }

    private void Adicionar_Clicked(object sender, EventArgs e)
    {
        // Lógica para quando o botão "+" é clicado
        // Por exemplo, abrir uma tela para adicionar um novo colaborador
        DisplayAlert("Adicionar", "Em breve será implementada a funcionalidade para adicionar novos colaboradores.", "OK");
    }
}