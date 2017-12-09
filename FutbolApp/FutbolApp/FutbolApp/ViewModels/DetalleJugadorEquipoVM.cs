using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutbolApp.ViewModels
{
    public class DetalleJugadorEquipoVM
    {
        public string FotoJugador { get; set; }
        public string NombreJugador { get; set; }
        public string EscudoEquipo { get; set; }
        public string NombreEquipo { get; set; }
        public int Numero { get; set; }
        public int Goles { get; set; }
    }
}
