public partial class FrameAcabamento : ContentPage
{
    public FrameAcabamento()
    {
        InitializeComponent();
    }

    private void Limpar_Clicked(object sender, EventArgs e)
    {
        // Limpa o campo de entrada
        EntradaCalculo.Text = string.Empty;
    }

    private void Calcular_Clicked(object sender, EventArgs e)
    {
        // Lógica para realizar o cálculo
        if (double.TryParse(EntradaCalculo.Text, out double valor))
        {
            // Realize o cálculo aqui, por exemplo:
            double resultado = valor * 2; // Substitua por sua lógica de cálculo
            DisplayAlert("Resultado", $"O resultado é: {resultado}", "OK");
        }
        else
        {
            DisplayAlert("Erro", "Digite um valor válido.", "OK");
        }
    }

    private void Voltar_Clicked(object sender, EventArgs e)
    {
        // Lógica para quando o botão "Voltar" é clicado
        // Por exemplo, navegar para outra página
        Navigation.PopAsync();
    }
}