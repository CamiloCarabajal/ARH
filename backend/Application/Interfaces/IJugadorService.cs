using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IJugadorService
    {
        public List<Jugador> GetAll();
        public Jugador Create(Jugador jugador);
    }
}
