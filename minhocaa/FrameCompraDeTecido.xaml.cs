using Microsoft.Maui.Controls;

namespace minhocaa
{
    public partial class FrameCompraDeTecido : ContentPage
    {
        public FrameCompraDeTecido()
        {
            InitializeComponent();
        }

        private void OnAddClicked(object sender, EventArgs e)
        {
            // Implementar a lógica para adicionar mais tecidos aqui
            // Por exemplo, você pode adicionar o texto de inputText a uma lista
        }

        private void OnBackClicked(object sender, EventArgs e)
        {
            // Implementar a lógica para voltar aqui
            // Por exemplo, você pode navegar para a página anterior
        }

        private void Voltar(object sender, EventArgs e)
        {
           Application.Current.MainPage = new CompraTecidoMetro2();
        }
    }
}
