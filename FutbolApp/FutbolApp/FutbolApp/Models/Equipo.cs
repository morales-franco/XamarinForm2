using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutbolApp.Models
{
    public class Equipo
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string Escudo { get; set; }
        [ManyToMany(typeof(JugadorEquipo))]
        public List<Jugador> Jugadores { get; set; }
    }
}
