using Microsoft.Maui.Controls;

namespace minhocaa
{
    public partial class TelaInicial : ContentPage
    {
        public TelaInicial()
        {
            InitializeComponent();
        }

        private void Cliente(object sender, EventArgs e)
        {
           Application.Current.MainPage = new CadastroCliente();
        }

        private void Tecido(object sender, EventArgs e)
        {
           Application.Current.MainPage = new CompraTecidoMetro2();
        }

        private void TempoDeProducao(object sender, EventArgs e)
        {
           Application.Current.MainPage = new FrameCentral();
        }
    }
     
}
