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
    public class PartidoRepository : IPartidoRepository
    {
        private readonly ApplicationDbContext _context;
        public PartidoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Partido> GetAll() 
        {
            return _context.Partidos.ToList();
        }
    }
}
