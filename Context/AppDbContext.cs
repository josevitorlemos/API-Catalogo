using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore; //DUVIDA
using APICatalogo.Models; //DUVIDA
using Microsoft.Extensions.Configuration; //DUVIDA
using System.IO; //DUVIDA


namespace APICatalogo.Context 
//Coordenar a funcionalidade do Entityframeworkcore para o modelo de entidades/dados
{
    public class AppDbContext : DbContext
    {
        //Cria uma sessão, um contexto, onde fornecerá métodos para o CRUD
        //Será criado uma instancia dessa dependência
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        { }

        //Mapeam as entidades 
        public DbSet<Categoria> Categorias { get; set; }

        public DbSet<Produto> Produtos { get; set; }
    }
}