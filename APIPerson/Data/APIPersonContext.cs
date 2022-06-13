using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using APIPerson.Models;

namespace APIPerson.Data
{
    public class APIPersonContext : DbContext
    {
        public APIPersonContext (DbContextOptions<APIPersonContext> options)
            : base(options)
        {
        }

        public DbSet<APIPerson.Models.Person> Person { get; set; }
    }
}
