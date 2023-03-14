using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo5
{
    internal class SintaxeAlternativa
    {
        public static void AulaSintaxeAlternativa()
        {
            Console.WriteLine("\nAula síntaxe alternativa para inicialização de valores: \n");

            Console.WriteLine("\nEntre os dados do produto:");

            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade);

            Produto2 p1 = new Produto2()
            { 
                Nome = "TV", 
                Preco = 900.00, 
                Quantidade = 20 
            };

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
}
