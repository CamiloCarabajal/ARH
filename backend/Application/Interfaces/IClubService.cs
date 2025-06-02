using Application.Models.Request;
using Application.Models;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface IClubService
    {
        public List<Club> GetAll();
        public Club GetById(int id);
        public ClubDto Create(ClubRequest club);
    }
}
