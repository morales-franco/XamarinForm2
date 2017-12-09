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
    public partial class ListaEquiposPage : ContentPage
    {
        public ListaEquiposPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            lsvEquipos.ItemsSource = App.BaseDatos.ObtenerEquipos();
        }
        private async void lsvEquipos_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            try
            {
                Equipo equipo = (Equipo)e.SelectedItem;
                await Navigation.PushAsync(new EquipoPage(equipo));
            }
            catch (Exception ex)
            {
            }
        }
        private async void Agregar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new EquipoPage(new Equipo()));
        }
    }
}