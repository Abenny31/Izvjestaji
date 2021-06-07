using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Intervencije.Models;

namespace Intervencije.Models
{
    public class Intervencija
    {
        [Key]
        public int Id { get; set; }
        public DateTime Datum { get; set;}
     
        
        public int FkUser { get; set; }
        
        public int FkAkcija { get; set; }
       
        public int FkPlaza { get; set; }


        


    }
}
