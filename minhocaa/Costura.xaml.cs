using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace minhocaa
{
    public partial class CosturaPage : ContentPage
    {
        public CosturaPage()
        {
            InitializeComponent();
           
        }

        private void CadastroButtonClicked(object sender, EventArgs e)
        {
      
        }

        private void ExcluirColaborador(object sender, EventArgs e)
        {
            // Implementar a lógica de exclusão
            // Por exemplo, exibir um alerta para confirmar a exclusão
            // e remover o item da lista
        }

        private void Voltar(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}