using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo5
{
    internal class Sobrecarga
    {
        public static void AulaSobrecarga()
        {
            Console.WriteLine("\nAula sobrecarga: \n");


            Console.WriteLine("\nEntre os dados do produto:");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto2 p = new Produto2(nome, preco);

            Console.WriteLine($"\nDados do produto: {p}");


            Console.Write("\nDigite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());

            p.AdicionarProdutos(qte);


            Console.WriteLine($"\nDados atualizados: {p}");

            Console.Write("\nDigite o número de produtos a ser removido do estoque: \n");
            qte = int.Parse(Console.ReadLine());

            p.RemoverProdutos(qte);


            Console.WriteLine($"\nDados atualizados: {p}");

        }

    }


    internal class Produto2
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto2(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        public Produto2(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = 5;
        }

        public Produto2(string nome)
        {
            Nome = nome;
            Preco = 600.00;
            Quantidade = 5;
        }

        public Produto2()
        {
        }

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
