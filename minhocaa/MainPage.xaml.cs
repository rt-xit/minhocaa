﻿using Microsoft.Maui.Controls;

namespace minhocaa
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void OnClearButtonClicked(object sender, EventArgs e)
        {
        }

        private void OnCalculateButtonClicked(object sender, EventArgs e)
        {
            // Lógica para calcular o tempo aqui
            DisplayAlert("Calculando", "O cálculo está em andamento...", "OK");
        }

        private void OnBackButtonClicked(object sender, EventArgs e)
        {
            // Lógica para voltar para a página anterior
            Navigation.PopAsync();
        }
        void LimparEntrada (object sender, EventArgs e)
        {

        }

        void Calcular(object sender, EventArgs e)
        {
            
        }

        void Voltar(object sender, EventArgs e)
        {
            
        }
    }
}
