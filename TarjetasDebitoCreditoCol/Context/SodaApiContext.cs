using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TarjetasDebitoCreditoCol.Models;

namespace TarjetasDebitoCreditoCol.Context
{
    public class SodaApiContext: DbContext
    {
        public DbSet<Operacion> Operaciones { get; set; }

        public SodaApiContext(DbContextOptions<SodaApiContext> options) : base(options)
        {

        }
    }
}
