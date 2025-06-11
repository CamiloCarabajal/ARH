using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IClubRepository
    {
        public List<Club> GetAll();
        public Club GetById(int id);
        public Club Create(Club club);
        public Club Update(Club club);
        public Club Delete(Club obj);
    }
}
