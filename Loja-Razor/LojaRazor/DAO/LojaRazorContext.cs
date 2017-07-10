using LojaRazor.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LojaRazor.DAO
{
    public class LojaRazorContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<Departamento> Departamentos { get; set; }
    }
    
}