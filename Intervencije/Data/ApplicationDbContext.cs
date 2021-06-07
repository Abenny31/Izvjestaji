using Intervencije.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Intervencije.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }
        public DbSet<Intervencija> DbIntervencija { get; set; }
        public DbSet<Plaza> DbPlaza { get; set; }
        public DbSet<Akcija> DbAkcija { get; set; }

        public DbSet<Spasilac> DbSpasilac { get; set; }
        
            
        

    }
}

