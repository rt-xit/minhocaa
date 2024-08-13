using System;
using Microsoft.Maui.Controls;

namespace minhocaa
{
    public partial class ColaboradoresDaLinha : ContentPage
    {
        // Constructor
        public ColaboradoresDaLinha()
        {
            InitializeComponent();
            // Optionally set the BindingContext here if using MVVM
            // BindingContext = new ColaboradoresDaLinhaViewModel();
        }

        // Event handler for the "Cadastro" and "+" buttons
        private void CadastroButtonClicked(object sender, EventArgs e)
        {
            // Logic to handle Cadastro button click
            // Here you can navigate to a new page or show a dialog, etc.
            DisplayAlert("Cadastro", "Cadastro button clicked", "OK");
        }

        // Event handler for the "Voltar" button
        private void Voltar(object sender, EventArgs e)
        {
            // Logic to handle the "Voltar" button click
            // This will navigate back to the previous page in the navigation stack
            if (Navigation.NavigationStack.Count > 1)
            {
                Navigation.PopAsync();
            }
            else
            {
                DisplayAlert("Navigation", "No page to go back to", "OK");
            }
        }
    }
}

