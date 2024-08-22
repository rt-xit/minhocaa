using Microsoft.Maui.Controls;

namespace minhocaa
{
    public partial class CadastroCliente : ContentPage
    {
        public CadastroCliente()
        {
            InitializeComponent();
        }
         private void EntrarEmContato(object sender, EventArgs e)
        {
           Application.Current.MainPage = new FrameCliente();
        }

        private void Voltar(object sender, EventArgs e)
        {
           Application.Current.MainPage = new TelaInicial();
        }
    }

}
    