using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace P2_2020BQ601_2020AU601_2020QQ650.Models
{
    public class covidConnection : DbContext
    {
        public covidConnection(DbContextOptions options) : base(options)
        {
        }

        public DbSet<CasosReportados> CasosReportados { get; set; }
        public DbSet<Departamentos> Departamentos { get; set; }
        public DbSet<Generos> Generos { get; set; }
    }
}
