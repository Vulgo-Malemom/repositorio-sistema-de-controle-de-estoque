using System;

namespace RepositorioSistemaDeControleDeEstoque
{
    class Program
    {
        static void Main (string[] args)
        {
            Produto produto = new Produto();
            Produto.NomeDoProduto = "Tenis";
            Produto.PrecoDoProduto = "35";
            Produto.QuantidadeDoProduto = 1
        }
    }
        public class Produto
    {
        public string NomeDoProduto;
        public decimal PrecoDoProduto;
        public int QuantidadeDoProduto;

     public Produto(string nome, decimal preco, int quantidade)
     {
         NomeDoProduto = nome;
         PrecoDoProduto = preco;
         QuantidadeDoProduto = quantidade;
        }

     public void AtualizarQuantidade(int quantidade)
     {
            QuantidadeDoProduto += quantidade;
     }

     public override string ToString()
     {
         return $"Produto: {Nome}, Preço: R${Preco:F2}, Quantidade: {Quantidade}";
     }
    }
}