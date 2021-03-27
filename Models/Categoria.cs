using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace APICatalogo.Models
{
    [Table("Categorias")]

    public class Categoria 
    {
        public Categoria()
        {
            Produtos = new Collection<Produto>(); //Boa pratica - Responsabilidade de categoria inicializar Produto
        }
        [Key]

        public int CategoriaID { get; set; }
        [Required]
        [MaxLength(80)]

        public string Nome { get; set; }
        [Required]
        [MaxLength(300)]

        public string ImageUrl { get; set; }

        public ICollection<Produto> Produtos { get; set; } //Criou uma tabela para convenção, que informar ao EnptyFrameworkCore um relacionamento.
    }
}