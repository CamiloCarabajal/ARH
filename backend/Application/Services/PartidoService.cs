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
    public class PartidoService : IPartidoService
    {
        private readonly IPartidoRepository _partidoRepository;

        public PartidoService (IPartidoRepository partidoRepository)
        {
            _partidoRepository = partidoRepository;
        }

        public List<Partido> GetAll()
        {
            return _partidoRepository.GetAll();
        }
    }
}
