﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Request
{
    public class ClubUpdateRequest
    {
        public string? Name { get; set; }

        public List<string>? Categorias { get; set; }
    }
}
