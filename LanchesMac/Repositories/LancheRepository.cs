using LanchesMac.Context;
using LanchesMac.Models;
using LanchesMac.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LanchesMac.Repositories
{
    public class LancheRepository : ILancheRepository
    {
        private readonly AppDbcontext _context;
        public LancheRepository(AppDbcontext context)
        {
            _context = context;
        }
        public IEnumerable<Lanche> Lanches => _context.Lanches.Include(c => c.Categoria);

        public IEnumerable<Lanche> LanchesPreferidos => _context.Lanches.
                                              Where(l => l.IsLanchePreferido).
                                              Include(c => c.Categoria);

        Lanche ILancheRepository.GetLancheById(int lancheid)
        {
            return _context.Lanches.FirstOrDefault(l => l.LancheId == lancheid);
        }
    }
}
