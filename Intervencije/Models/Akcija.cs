﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Intervencije.Models
{
    public class Akcija
    {
        [Key]
        public int Id { get; set; }
        public string Vrsta { get; set; }
    }
}
