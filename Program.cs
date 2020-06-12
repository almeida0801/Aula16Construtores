using System;

namespace Aula16Construtores
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instância sem argumentos
            Produto tenis = new Produto();
            tenis.Nome = "Nike";

            // Instância com 1 argumento
            Produto chinelo = new Produto(45);
            System.Console.WriteLine(chinelo.Codigo);

            // Instância com todos os atributos como argumento
            Produto camiseta = new Produto(48, "Adidas", "Roxa", 514);
            System.Console.WriteLine(camiseta.Codigo);
            System.Console.WriteLine(camiseta.Nome);
            System.Console.WriteLine(camiseta.Descricao);
            System.Console.WriteLine(camiseta.Estoque);

        }
    }
}