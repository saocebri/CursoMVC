using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CursoMVC.Models;

namespace CursoMVC.Models
{
    public class Context : DbContext
    {
        public DbSet<Categoria>Categorias { get; set; }
        public List<Produto> Produtos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=CursoMVC;Integrated Security=True");
        }

        public DbSet<CursoMVC.Models.Produto> Produto { get; set; }
    }
}
