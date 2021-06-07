using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Intervencije.Models
{
    public class Spasilac
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; }

        public String Prezime { get; set; }


    }
}
