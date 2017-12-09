using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutbolApp.Models
{
    public class JugadorEquipo
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        [ForeignKey(typeof(Equipo))]
        public int IDEquipo { get; set; }
        [ForeignKey(typeof(Jugador))]
        public int IDJugador { get; set; }
        public int Numero { get; set; }
        public int Goles { get; set; }
    }
}
