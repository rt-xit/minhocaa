using System;
using Microsoft.Maui.Controls;

namespace minhocaa
{
    public partial class Bordado : ContentPage
    {
        public Bordado()
        {
            InitializeComponent();
        }

           private void Voltar(object sender, EventArgs e)
        {
           Application.Current.MainPage = new FrameCentral();
        }
    }
}