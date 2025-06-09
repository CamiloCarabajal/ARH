using Application.Interfaces;
using Application.Models;
using Application.Models.Request;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
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

        public Club GetById(int id)
        {
            return _clubRepository.GetById(id);
        }

        public ClubDto Create(ClubRequest club) 
        {
            var entity= ClubDto.ToEntity(club);

            _clubRepository.Create(entity);
           var dto= ClubDto.ToDto(entity);
            return dto;
        }

        public ClubDto Update(int id, ClubUpdateRequest club)
        {
            var clubToUpdate = _clubRepository.GetById(id);

            if (clubToUpdate == null)
            {
                throw new Exception("No se encontro");
            }
            else
            {
                // Actualizamos los campos directamente
                clubToUpdate.Name = club.Name;
                clubToUpdate.Categorias = club.Categorias;

                var clubReady = _clubRepository.Update(clubToUpdate);

                // Manualmente mapeamos a ClubDto
                var response = new ClubDto
                {
                    Name = clubReady.Name,
                    Categorias = clubReady.Categorias
                };

                return response;
            }
        }

    }
}
