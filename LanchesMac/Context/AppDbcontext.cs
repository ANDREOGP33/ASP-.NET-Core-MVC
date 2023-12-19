using LanchesMac.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace LanchesMac.Context
{
    public class AppDbcontext : DbContext
    {
        public AppDbcontext(DbContextOptions<AppDbcontext> options) : base(options)
        {
        }

        public DbSet<Categoria> Categorias {  get; set; }
        public DbSet<Lanche> Lanches { get; set; }

    }
}
