public partial class FrameCadastroDeAcabamento : ContentPage
{
    public FrameCadastroDeAcabamento()
    {
        InitializeComponent();
    }

    private void RemoverCaractere_Clicked(object sender, EventArgs e)
    {
        // Remove o último caractere do Entry
        if (NomeColaborador.Text.Length > 0)
        {
            NomeColaborador.Text = NomeColaborador.Text.Substring(0, NomeColaborador.Text.Length - 1);
        }
    }

    private void AdicionarColaborador_Clicked(object sender, EventArgs e)
    {
        // Lógica para adicionar o colaborador (implemente aqui)
        string nome = NomeColaborador.Text;
        // ... faça algo com o nome do colaborador, como adicionar a uma lista
        DisplayAlert("Sucesso", $"Colaborador {nome} adicionado!", "OK");
        NomeColaborador.Text = string.Empty; // Limpa o campo após adicionar
    }

    private void Voltar_Clicked(object sender, EventArgs e)
    {
        // Lógica para quando o botão "Voltar" é clicado
        // Por exemplo, navegar para outra página
        Navigation.PopAsync();
    }
}