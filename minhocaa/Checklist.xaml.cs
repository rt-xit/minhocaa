using System;
using Microsoft.Maui.Controls;

namespace minhocaa
{
    public partial class Checklist : ContentPage
    {
        public Checklist()
        {
            InitializeComponent();
        }

        private void ListaDePresenca(object sender, EventArgs e)
        {
           Application.Current.MainPage = new Checklist();
        }

        private void Voltar(object sender, EventArgs e)
        {
           Application.Current.MainPage = new TelaInicial();
        }

        private void OnSalvarClicked(object sender, EventArgs e)
        {
            // Ação para o botão Salvar
            bool produtoA = ProdutoACheckBox.IsChecked;
            bool produtoB = ProdutoBCheckBox.IsChecked;
            bool produtoC = ProdutoCCheckBox.IsChecked;
            bool produtoD = ProdutoDCheckBox.IsChecked;
            bool produtoE = ProdutoECheckBox.IsChecked;
            bool produtoF = ProdutoFCheckBox.IsChecked;
            bool produtoG = ProdutoGCheckBox.IsChecked;
            bool produtoH = ProdutoHCheckBox.IsChecked;
            bool produtoI = ProdutoICheckBox.IsChecked;
            bool produtoJ = ProdutoJCheckBox.IsChecked;
            bool produtoK = ProdutoKCheckBox.IsChecked;
            bool produtoL = ProdutoLCheckBox.IsChecked;
            bool produtoM = ProdutoMCheckBox.IsChecked;

            // Lógica para salvar os dados do checklist
            // Aqui você pode adicionar a lógica para salvar os estados dos CheckBox
        }
    }
}