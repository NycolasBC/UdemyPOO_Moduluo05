using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo5
{
    internal class This
    {
        public static void PalavraThis()
        {
            Console.WriteLine("\nAula palavra This: \n");

            Console.WriteLine("\nEntre os dados do produto:");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto3 p = new Produto3(nome, preco);

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



    internal class Produto3
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto3()
        {
            Quantidade = 10;
        }

        public Produto3(string Nome, double Preco) : this()
        {
            this.Nome = Nome;
            this.Preco = Preco;
        }

        public Produto3(string Nome, double Preco, int Quantidade) : this(Nome, Preco)
        {
            this.Quantidade = Quantidade;
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
