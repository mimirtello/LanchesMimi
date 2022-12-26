using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using Projeto.Context;
using Projeto.Models;
using Projeto.Repositories.Interfaces;

namespace Projeto.Repositories
{
       public class LancheRepository : ILancheRepository
    {
        private readonly AppDbContext _context;
        public LancheRepository(AppDbContext contexto)
        {
            _context = contexto;
        }

        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c => c.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches.
                                   Where(l => l.IsLanchePreferido)
                                  .Include(c => c.Categoria);

        public Lanche GetLancheById(int lancheId)
        {
            return _context.Lanches.FirstOrDefault(l => l.LancheId == lancheId);
        }

        public IEnumerable<Lanche> GetLanchesPorCategoria(string categoria)
        {
            var resultado = _context.Lanches.Include(c => c.Categoria)
                           .Where(l => l.Categoria.CategoriaNome.Equals(categoria))
                           .OrderBy(c => c.Nome);
 
            return resultado;
        }
    }
}