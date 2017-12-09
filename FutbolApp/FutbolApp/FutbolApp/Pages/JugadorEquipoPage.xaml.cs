using FutbolApp.Models;
using FutbolApp.ViewModels;
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
    public partial class JugadorEquipoPage : ContentPage
    {
        DetalleJugadorEquipoVM Detalle;
        JugadorEquipo JugadorEquipo;
        Jugador Jugador;
        Equipo Equipo;
        bool Nuevo;
        public JugadorEquipoPage(Jugador jugador, Equipo equipo, bool nuevo)
        {
            InitializeComponent();
            Jugador = jugador;
            Equipo = equipo;
            Detalle = App.BaseDatos.ObtenerDetalleJugadorEquipo(equipo, jugador);
            JugadorEquipo = App.BaseDatos.ObtenerJugadorEquipo(equipo.ID, jugador.ID);
            Nuevo = nuevo;
            this.BindingContext = Detalle;
        }
        private async void Guardar_Clicked(object sender, EventArgs e)
        {
            JugadorEquipo.Goles = Detalle.Goles;
            JugadorEquipo.Numero = Detalle.Numero;
            App.BaseDatos.ActualizarJugador(Jugador, Equipo);
            App.BaseDatos.ActualizarJugadorEquipo(JugadorEquipo);
            await DisplayAlert("FutbolApp", "Datos actualizados con éxito", "OK");
        }
    }
}