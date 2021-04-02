using Microsoft.EntityFrameworkCore.Migrations;

namespace APICatalogo.Migrations
{
    public partial class Populadb : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into Categorias(Nome,ImagemUrl) Values('Bebidas','https://araujo.vteximg.com.br/image/01.jpg')");
            mb.Sql("Insert into Categorias(Nome,ImagemUrl) Values('Lanches','https://araujo.vteximg.com.br/image/01.jpg')");
            mb.Sql("Insert into Categorias(Nome,ImagemUrl) Values('Sobremesas','https://araujo.vteximg.com.br/image/01.jpg')");

            mb.Sql("Insert into Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) Values('Coca-Cola','Refrigerante de Cola 300 ML','5.80','https://araujo.vteximg.com.br/arquivos/ids/4042618-1000-1000/07894900010015.jpg?v=637436775975100000',now(),50,(Select CategoriaId from Categorias where Nome='Bebidas'))");
            mb.Sql("Insert into Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) Values('Lanche de Atum','Sandwich de Atum com maionese','8.50','https://araujo.vteximg.com.br/arquivos/ids/4042618-1000-1000/07894900010015.jpg?v=637436775975100000',now(),20,(Select CategoriaId from Categorias where Nome='Lanches'))");
            mb.Sql("Insert into Produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) Values('Pudim 100 g','Pudim de leite condensado 100g','6.95','https://araujo.vteximg.com.br/arquivos/ids/4042618-1000-1000/07894900010015.jpg?v=637436775975100000',now(),10,(Select CategoriaId from Categorias where Nome='Sobremesas'))");

        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from Categorias");
            mb.Sql("Delete from Produtos");
        }
    }
}
