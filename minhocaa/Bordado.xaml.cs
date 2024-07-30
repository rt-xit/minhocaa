using System;
using Microsoft.Maui.Controls;

namespace minhocaa
{
    public partial class BordadoPage : ContentPage
    {
        public BordadoPage()
        {
            InitializeComponent();
        }

        private void NomeButtonClicked(object sender, EventArgs e)
        {
            // Lógica para quando um nome é clicado (opcional)
            Button button = (Button)sender;
            string nome = button.Text;
            // ... (sua lógica aqui, por exemplo, exibir informações detalhadas sobre o nome)
        }

        private void Calcular(object sender, EventArgs e)
        {
            // Lógica para o botão "=" (ainda não definida na imagem)
            // Por exemplo, poderia calcular uma soma total ou média
            // ... (sua lógica aqui)
        }

        private void Voltar(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}