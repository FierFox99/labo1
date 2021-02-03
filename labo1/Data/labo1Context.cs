using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using labo1.Models;

namespace labo1.Data
{
    public class labo1Context : DbContext
    {
        public labo1Context (DbContextOptions<labo1Context> options)
            : base(options)
        {
        }

        public DbSet<labo1.Models.Class> Class { get; set; }
    }
}
