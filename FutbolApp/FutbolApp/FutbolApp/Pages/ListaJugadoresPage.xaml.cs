using FutbolApp.Models;
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
    public partial class ListaJugadoresPage : ContentPage
    {
        Equipo Equipo;
        public ListaJugadoresPage(Equipo equipo = null)
        {
            InitializeComponent();
            Equipo = equipo;
            if (Equipo != null)
            {
                if (this.ToolbarItems.Count > 0)
                    this.ToolbarItems.RemoveAt(0);
            }
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            lsvJugadores.ItemsSource = App.BaseDatos.ObtenerJugadores();
        }
        private async void lsvJugadores_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            try
            {
                Jugador jugador = (Jugador)e.SelectedItem;
                if (Equipo == null)
                    await Navigation.PushAsync(new JugadorPage(jugador));
                else
                    await Navigation.PushAsync(new JugadorEquipoPage(jugador, Equipo, true));
            }
            catch (Exception ex) { }
        }
        private async void Agregar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new JugadorPage(new Jugador()));
        }
    }
}