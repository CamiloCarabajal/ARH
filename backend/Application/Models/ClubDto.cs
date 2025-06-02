using Application.Models.Request;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class ClubDto
    {
        public string? Name { get; set; }
        public string? Direccion { get; set; }
        public List<string>? Categorias { get; set; }

        public static ClubDto ToDto(Club club)
        {
            var dto = new ClubDto()
            {
                Name = club.Name,
                Direccion = club.Direccion,
                Categorias = club.Categorias
            };
            return dto;
        }
        public static Club ToEntity(ClubRequest clubDto) 
        {
            var entity = new Club()
            {
                Name = clubDto.Name,
                Direccion = clubDto.Direccion,
                Categorias = clubDto.Categorias
            };
            return entity;
        }
    }
}
