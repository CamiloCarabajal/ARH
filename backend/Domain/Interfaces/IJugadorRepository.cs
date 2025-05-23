﻿using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IJugadorRepository
    {
        public List<Jugador> GetAll();
        public Jugador Add(Jugador jugador);
        public Jugador GetById(int id);
        public Jugador Update(Jugador jugador);

    }
}
