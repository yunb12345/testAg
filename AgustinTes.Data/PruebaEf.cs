using System;
using Microsoft.EntityFrameworkCore;

namespace AgustinTes.Data
{
    public class PruebaEf : DbContext
    {
        public PruebaEf(DbContextOptions<PruebaEf> options)
            : base(options)
        {

        }
        public DbSet<Juego> Juegos { get; set; }
    }
}

//en el package manager console add-migration *insertar nombre*
//update-database
//tiene que tener las librerias de ef.design