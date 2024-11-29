using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazonPageFilmes.Data;
using RazorPagesFilmes.Model;

namespace RazonPageFilmes.Pages.Filmes
{
    public class IndexModel : PageModel
    {
        private readonly RazonPageFilmes.Data.RazonPageFilmesContext _context;

        public IndexModel(RazonPageFilmes.Data.RazonPageFilmesContext context)
        {
            _context = context;
        }

        public IList<Filme> Filme { get;set; } = default!;//Modelo que seria a lista de filmes

        public async Task OnGetAsync()
        {
            if (_context.Filme != null)
            {
                Filme = await _context.Filme.ToListAsync();
            }
        }
    }
}
