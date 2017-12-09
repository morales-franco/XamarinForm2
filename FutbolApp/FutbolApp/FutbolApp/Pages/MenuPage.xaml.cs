using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FutbolApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private async void Jugadores_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListaJugadoresPage());
        }
        private async void Equipos_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ListaEquiposPage());
        }

    }
}