using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosVeiculos_EF
{
    public class BaseContext : DbContext
    {
        public BaseContext() : base("veiculos_db") { }    
        public DbSet<Modelo>  Modelos { get; set; }
        public DbSet<Veiculo> Veiculos { get; set; }

    }
}
