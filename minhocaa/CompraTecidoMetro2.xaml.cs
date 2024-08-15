using Microsoft.Maui.Controls;
using System;

namespace minhocaa
{
    public partial class CompraTecidoMetro2 : ContentPage
    {
        public CompraTecidoMetro2()
        {
            InitializeComponent();
        }

        private void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            if (sender is Button button && button.CommandParameter is Entry entry)
            {
                entry.Text = string.Empty;
            }
        }

        private void OnVoltarButtonClicked(object sender, EventArgs e)
        {
            // Logic to handle the "Voltar" button click
        }

        private void OnFazerCompraButtonClicked(object sender, EventArgs e)
        {
            // Logic to handle the "Fazer Compra" button click
        }
    }
}
