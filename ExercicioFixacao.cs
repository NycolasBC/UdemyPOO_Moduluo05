using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Modulo5
{
    internal class ExercicioFixacao
    {
        public static void AulaExercicioFixacao()
        {
            Console.WriteLine("\nExercícios de fixação: \n");

            Console.Write("Entre o número da conta: ");
            int numConta = Convert.ToInt32(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();

            Conta conta = new Conta(numConta, nome);

            Console.WriteLine("Haverá depósito inicial? (s/n)");
            char opcao = Convert.ToChar(Console.ReadLine().ToLower());

            if (opcao == 's')
            {
                Console.Write("\nEntre um valor para depósito: ");
                double valorDeposito = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

                conta.Deposito(valorDeposito);
                Console.WriteLine("Dados da conta:");
                Console.WriteLine(conta);
            }
            else
            {
                Console.WriteLine("Dados da conta:");
                Console.WriteLine(conta);
            }

            Console.Write("Entre um valor para depósito: ");
            double valorDeposito2 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            conta.Deposito(valorDeposito2);
            Console.WriteLine("Dados Atualizados");
            Console.WriteLine(conta);


            Console.Write("Entre um valor para saque: ");
            double valorSaque = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            conta.Saque(valorSaque);
            Console.WriteLine("Dados Atualizados");
            Console.WriteLine(conta);
        }
    }


    class Conta
    {
        public int NumeroConta { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public Conta(int numeroConta, string titular)
        {
            NumeroConta = numeroConta;
            Titular = titular;
        }

        public double Deposito(double valor)
        {
            return Saldo += valor;
        }

        public double Saque(double valor)
        {
            return Saldo = (Saldo - valor) - 5.0;
        }

        public override string ToString()
        {
            return 
                $"Conta {NumeroConta}, " +
                $"Titular: {Titular}, " +
                $"Saldo: R$ {Saldo.ToString("F2", CultureInfo.InvariantCulture)}\n\n"; 
        }
    }
}
