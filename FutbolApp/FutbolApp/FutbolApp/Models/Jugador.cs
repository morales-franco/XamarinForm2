using SQLite;
using SQLiteNetExtensions.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FutbolApp.Models
{
    public class Jugador
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string Nombre { get; set; }
        public string FechaNacimiento { get; set; } = DateTime.MinValue.ToString();
        public string Foto { get; set; }
        [ManyToMany(typeof(JugadorEquipo))]
        public List<Equipo> Equipos { get; set; }
    }
}
