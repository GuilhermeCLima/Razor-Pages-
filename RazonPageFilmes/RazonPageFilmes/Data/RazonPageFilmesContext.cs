using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RazorPagesFilmes.Model;

namespace RazonPageFilmes.Data
{
    public class RazonPageFilmesContext : DbContext
    {
        public RazonPageFilmesContext (DbContextOptions<RazonPageFilmesContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesFilmes.Model.Filme> Filme { get; set; } = default!;
    }
}
