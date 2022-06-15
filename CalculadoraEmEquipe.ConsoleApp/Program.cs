using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraEmEquipe.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora 1.0");

            double primeiroNumero;
            double segundoNumero;
            int operacaoEscolhida;
            double resultado = 0;

            /*
             * 1 - adicao
             * 2 - subtracao
             * 3 - multi
             * 4 - divisao
             * 5 - historico
             * qualquer outro sair
             */

            Console.WriteLine("Escolha uma operação: ");
            string opcaoString = Console.ReadLine();
            operacaoEscolhida = int.Parse(opcaoString);

            Console.Clear();

            Console.WriteLine("Digite o primeiro numero: ");
            string primeiroNumeroString = Console.ReadLine();
            primeiroNumero = int.Parse(primeiroNumeroString);

            Console.WriteLine("Digite o Segundo numero: ");
            string segundoNumeroString = Console.ReadLine();
            segundoNumero = int.Parse(segundoNumeroString);


            switch (operacaoEscolhida)
            {
                case 1:
                    resultado = primeiroNumero + segundoNumero;
                    break;
                case 2:
                    break;
                case 3:
                    resultado = primeiroNumero * segundoNumero;
                    break;
                case 4:
                    break;
                case 5:
                    break;
                case 6:
                    break;
            }

            Console.WriteLine("Resultado fica: {0}.", resultado);
            Console.WriteLine();
            Console.WriteLine("Aperte ENTER para sair.");
            Console.ReadLine();
        }
    }
}
