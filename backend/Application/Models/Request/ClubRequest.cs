using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Request
{
    public class ClubRequest
    {
        public string? Name { get; set; }
        public string? Direccion { get; set; }
        public List<string>? Categorias { get; set; }
    }
}
