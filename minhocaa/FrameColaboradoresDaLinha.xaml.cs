using System.Collections.ObjectModel;
using Microsoft.Maui.Controls;

namespace minhocaa
{
    public partial class ColaboradoresPage : ContentPage
    {
        public ObservableCollection<string> ListaColaboradores { get; set; }

        public ColaboradoresPage()
        {
            InitializeComponent();
            ListaColaboradores = new ObservableCollection<string>
        }
    }
}