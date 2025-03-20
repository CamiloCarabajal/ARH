using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Partido
    {
        public int Id { get; set; }
        public int ResultadoPropio { get; set; }
        public string ResultadoRival { get; set; }
        public string Rival { get; set; }

        // Relacion con jugadores
        public List<Jugador> JugadorList { get; set; }
    }
}
