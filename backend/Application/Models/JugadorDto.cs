using Application.Models.Request;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class JugadorDto
    {
        public  string Nombre { get; set; }
        public string Posicion { get; set; }
        public int Goles { get; set; }

        public static JugadorDto ToDto(Jugador jugador)
        {
            var dto = new JugadorDto()
            {
                Nombre = jugador.Nombre,
                Goles = jugador.Goles,
                Posicion = jugador.Posicion
            };
            return dto;
        }

        public static Jugador ToEntity(JugadorRequest jugadorDto)
        {
            var jugadorEntity = new Jugador()
            {
                Nombre = jugadorDto.Nombre,
                Apellido = jugadorDto.Apellido,
                Email = jugadorDto.Email,
                Posicion = jugadorDto.Posicion,
                Goles = jugadorDto.Goles,
                
            };
            return jugadorEntity;
        }
    }
}
