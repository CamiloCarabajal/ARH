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
    public class ClubRepository :IClubRepository
    {
        private readonly ApplicationDbContext _context;
        public ClubRepository(ApplicationDbContext context) 
        {
            _context = context;
        }

        public List<Club> GetAll() 
        {

            var clubes=_context.Clubes.ToList();
            return clubes;
        }
        public Club GetById(int id) 
        {
            return _context.Clubes.First(c => c.Id == id);
        }
        public Club Create(Club club) 
        {
            _context.Clubes.Add(club);
            _context.SaveChanges();
            return club;

        }

        public Club Update(Club club) 
        {
            _context.Clubes.Update(club);
            _context.SaveChanges();
            return club;
        }

        public Club Delete(Club obj) 
        {
            _context.Clubes.Remove(obj);
            return null;
        }
    }
}
