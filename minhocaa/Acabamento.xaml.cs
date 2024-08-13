using System;
using Microsoft.Maui.Controls;

namespace minhocaa
{
    public partial class AcabamentoPage : ContentPage
    {
        public AcabamentoPage()
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
}