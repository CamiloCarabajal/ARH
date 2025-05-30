using Application.Interfaces;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ClubService : IClubService
    {
        private readonly IClubRepository _clubRepository;
        public ClubService(IClubRepository clubRepository) 
        {
           _clubRepository = clubRepository;
        }

        public List<Club> GetAll() 
        {
            return _clubRepository.GetAll();
        }
    }
}
