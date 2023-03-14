using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo5
{
    internal class Menu
    {
        public static void MenuGeral()
        {
            bool loop = true;

            while (loop)
            {
                Console.WriteLine("\nMenu de opções: \n");

                Console.WriteLine(
                    "\n1 - Construtores" + 
                    "\n2 - Sobrecarga" + 
                    "\n3 - Síntaxe alternativa" +
                    "\n4 - Palavra this" +
                    "\n5 - Encapsulamento\n");
                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        {
                            Construtores.AulaConstrutor();
                            break;
                        }
                    case 2:
                        {
                            Sobrecarga.AulaSobrecarga();
                            break;
                        }
                    case 3:
                        {
                            SintaxeAlternativa.AulaSintaxeAlternativa();
                            break;
                        }
                    case 4:
                        {
                            This.PalavraThis();
                            break;
                        }
                    case 5:
                        {
                            This.PalavraThis();
                            break;
                        }
                    case 6:
                        {
                            ExercicioFixacao.AulaExercicioFixacao();
                            break;
                        }
                    default:
                        {
                            
                            break;
                        }
                }
            }
        }
    }
}
