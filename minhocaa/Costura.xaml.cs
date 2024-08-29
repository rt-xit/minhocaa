using Microsoft.Maui.Controls;

namespace minhocaa
{
    public partial class Costura : ContentPage
    {
        public Costura()
        {
            InitializeComponent();
        }
       private void Voltar(object sender, EventArgs e)
        {
           Application.Current.MainPage = new FrameCentral();
        }
    }
}
