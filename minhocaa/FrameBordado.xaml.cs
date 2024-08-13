using System;
using Microsoft.Maui.Controls;

namespace minhocaa
{
    public partial class FrameBordado : ContentPage
    {
        public FrameBordado()
        {
            InitializeComponent();
        }

        private void LimparEntrada(object sender, EventArgs e)
        {
            EntradaTexto.Text = string.Empty;
        }

        private void Calcular(object sender, EventArgs e)
        {
            // Lógica para o cálculo
            string entrada = EntradaTexto.Text;
            // ... (sua lógica aqui, por exemplo, converter a entrada em um número e realizar um cálculo)
            // Exemplo:
            if (double.TryParse(entrada, out double valor))
            {
                // Realizar o cálculo com o valor
                double resultado = valor * 2; // Exemplo de cálculo simples
                DisplayAlert("Resultado", $"O resultado é: {resultado}", "OK");
            }
            else
            {
                DisplayAlert("Erro", "Entrada inválida", "OK");
            }
        }

        private void Voltar(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}