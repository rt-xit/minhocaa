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

           private void Voltar(object sender, EventArgs e)
        {
           Application.Current.MainPage = new FrameCentral();
        }
    }
}