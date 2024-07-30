using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace minhocaa
{
    public partial class ColaboradoresPage : ContentPage
    {
        public ObservableCollection<string> ListaColaboradores { get; set; }

        public ColaboradoresPage()
        {
            InitializeComponent();
            ListaColaboradores = new ObservableCollection<string>
            {
                "Ana", "Renato", "Sofia", "Juliana", "Laura", "Larissa"
            };
            BindingContext = this;
        }

        private void CadastroButtonClicked(object sender, EventArgs e)
        {
            // Navegar para a página de cadastro
            Navigation.PushAsync(new CadastroColaboradorPage());
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