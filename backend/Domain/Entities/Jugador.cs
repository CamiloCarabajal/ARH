using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Jugador : User
    {
        public int Edad { get; set; }
        public string Posicion { get; set; }
        public int Goles { get; set; }

        public List<Partido> PartidosList { get; set; }
    }
}
