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
            double primeiroNumero;
            double segundoNumero;
            int operacaoEscolhida;
            double resultado;

            Console.WriteLine("Escolha uma operação: ");
            string opcaoString = Console.ReadLine();
            operacaoEscolhida = int.Parse(opcaoString);

            /*
             * 1 - adicao
             * 2 - subtracao
             * 3 - multi
             * 4 - divisao
             * 5 - historico
             * qualquer outro sair
             */

            if (operacaoEscolhida == 1)
            {

            }
            else if(operacaoEscolhida == 2)
            {

            }
        }
    }
}
