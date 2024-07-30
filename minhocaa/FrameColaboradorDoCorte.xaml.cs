using System;
using Microsoft.Maui.Controls;

namespace minhocaa
{
    public partial class FrameColaboradorDoCorte : ContentPage
    {
        public FrameColaboradorDoCorte()
        {
            InitializeComponent();
        }

        private void FrameColaboradorDoCorte(object sender, EventArgs e)
        {
            // Lógica para adicionar o novo colaborador
            string nomeColaborador = NomeColaboradorEntry.Text;
            // ... (sua lógica aqui, por exemplo, adicionar a um banco de dados)
            DisplayAlert("Sucesso", $"Colaborador {nomeColaborador} adicionado!", "OK");
            NomeColaboradorEntry.Text = string.Empty;
        }

        private void ExcluirColaborador(object sender, EventArgs e)
        {
            // Lógica para excluir um colaborador
            // ... (sua lógica aqui, por exemplo, remover de um banco de dados)
        }

        private void Voltar(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}