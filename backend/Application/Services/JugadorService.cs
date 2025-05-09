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
    public class JugadorService : IJugadorService
    {
        private readonly IJugadorRepository _repository;
        public JugadorService(IJugadorRepository jugadorRepository) 
        {
            _repository = jugadorRepository;
        }
        public List<Jugador> GetAll() 
        {
            return _repository.GetAll();
        }

        public Jugador Create(Jugador jugador) 
        {
            _repository.Add(jugador);
            return jugador;
        }
    }
}
