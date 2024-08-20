using Microsoft.Maui.Controls;

namespace minhocaa
{
    public partial class FrameCliente : ContentPage
    {
        public FrameCliente()
        {
            InitializeComponent();
        }

        private void Voltar(object sender, EventArgs e)
        {
           Application.Current.MainPage = new CadastroCliente();
        }
    }
}