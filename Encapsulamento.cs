using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo5
{
    internal class Encapsulamento
    {
        public static void AulaEncapsulamento()
        {
            Console.WriteLine("\nAula encapsulamento e properties: \n");

            Console.WriteLine("\nEntre os dados do produto:");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Produto4 p = new Produto4(nome, preco);
            p.Nome = "TV 4k";

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


    internal class Produto4
    {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        
        public Produto4()
        {
            Quantidade = 10;
        }

        public Produto4(string Nome, double Preco) : this()
        {
            _nome = Nome;
            this.Preco = Preco;
        }

        public Produto4(string Nome, double Preco, int Quantidade) : this(Nome, Preco)
        {
            this.Quantidade = Quantidade;
        }


        public string Nome
        {
            get { return _nome; }

            set
            {
                if (value != null && value.Length > 1)
                {
                    _nome = value;
                }
            }
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
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
