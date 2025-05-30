using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Club
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Direccion { get; set; }
        public List<string>? Categorias { get; set; }

        //Relacion con jugadores
        public List<Jugador>? Jugadores { get; set; }
    }
}
