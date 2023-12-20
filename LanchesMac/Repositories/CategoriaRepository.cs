using LanchesMac.Context;
using LanchesMac.Models;
using LanchesMac.Repositories.Interfaces;

namespace LanchesMac.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly AppDbcontext _context;
        public CategoriaRepository(AppDbcontext context)
        {
            _context = context;
        }

        public IEnumerable<Categoria> categorias => _context.Categorias;
    }
}
