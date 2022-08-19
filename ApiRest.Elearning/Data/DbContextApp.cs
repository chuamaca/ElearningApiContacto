using ApiRest.Elearning.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiRest.Elearning.Data
{
    public class DbContextApp : DbContext
    {
        public DbContextApp(DbContextOptions<DbContextApp> options) : base(options)
        {

        }
        public DbSet<Empresa> empresa{get; set;}
        public DbSet<Contacto> contacto{get; set;}

    }
}
