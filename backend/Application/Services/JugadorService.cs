using Application.Interfaces;
using Application.Models;
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
        public List<JugadorDto> GetAll() 
        {
            var list = _repository.GetAll();

            var dtoList= list.Select(JugadorDto.ToDto).ToList();
            return dtoList;

            // Recibir una entidad y enviar un dto
        }

        public Jugador Create(Jugador jugador) 
        {
            _repository.Add(jugador);
            return jugador;
        }        
    }
}
