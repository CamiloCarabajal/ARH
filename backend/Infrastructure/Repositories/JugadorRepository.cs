using Domain.Entities;
using Domain.Interfaces;
using Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class JugadorRepository : IJugadorRepository
    {
        private readonly ApplicationDbContext _context;
        public JugadorRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Jugador> GetAll() 
        {
            return _context.Jugadores.ToList();
        }

        public Jugador Add(Jugador jugador) 
        {
            _context.Add(jugador);
            return jugador;
        }
    }
}
