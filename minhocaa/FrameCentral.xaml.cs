using Microsoft.Maui.Controls;

namespace minhocaa
{
    public partial class FrameCentral : ContentPage
    {
        public FrameCentral()
        {
            InitializeComponent();
        }
         private void Costura(object sender, EventArgs e)
        {
           Application.Current.MainPage = new Costura();
        }

         private void Corte(object sender, EventArgs e)
        {
           Application.Current.MainPage = new Corte();
        }

         private void Voltar(object sender, EventArgs e)
        {
           Application.Current.MainPage = new TelaInicial();
        }

        private void Bordado(object sender, EventArgs e)
        {
           Application.Current.MainPage = new Bordado();
        }

         private void Acabamento(object sender, EventArgs e)
        {
           Application.Current.MainPage = new AcabamentoPage();
        }
    }
}
