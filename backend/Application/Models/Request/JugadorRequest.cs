using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Request
{
    public class JugadorRequest
    {
        public string Nombre { get; set; }
        public string Email { get; set; }
        public int Edad { get; set; }
        public string Posicion { get; set; }
    }
}
