using Application.Interfaces;
using Application.Models;
using Application.Models.Request;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
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

        public JugadorDto GetById(int id)
        {
            var jugador= _repository.GetById(id);
            var jugadordto= JugadorDto.ToDto(jugador);
            return jugadordto;
        }

        public JugadorDto Create(JugadorRequest jugadordto) 
        {
            var jugadorEntity = JugadorDto.ToEntity(jugadordto);
            _repository.Add(jugadorEntity);

            var jugadorDto = JugadorDto.ToDto(jugadorEntity);
            return jugadorDto;
        }

        public JugadorDto Update(JugadorRequest jugadorDto, int id) 
        {
            var jugador = _repository.GetById(id);
            if (jugador == null)
            {
                throw new Exception("Jugador no encontrado");
            }
            else 
            {
                var jugadorEntity = JugadorDto.ToEntity(jugadorDto);
                _repository.Update(jugadorEntity);
                var jugadorResponse = JugadorDto.ToDto(jugadorEntity);
                return jugadorResponse;
            }
        }
    }
}
