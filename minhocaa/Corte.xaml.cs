using System;
using Microsoft.Maui.Controls;

namespace minhocaa
{
    public partial class Corte : ContentPage
    {
        public Corte()
        {
            InitializeComponent();
        }

       private void Voltar(object sender, EventArgs e)
        {
           Application.Current.MainPage = new FrameCentral();
        }
        
    }
}