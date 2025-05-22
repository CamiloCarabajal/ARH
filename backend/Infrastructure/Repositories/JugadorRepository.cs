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
        public Jugador GetById(int id) 
        {
            return _context.Jugadores.Find(id);
        }
        public Jugador Add(Jugador jugador) 
        {
            _context.Add(jugador);
            _context.SaveChanges();
            return jugador;
        }

        public Jugador Update(Jugador jugador) 
        {
            _context.Update(jugador);
            _context.SaveChanges();
            return jugador;
        }
    }
}
