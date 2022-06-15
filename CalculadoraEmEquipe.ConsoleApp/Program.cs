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

            double primeiroNumero = 0;
            double segundoNumero = 0;
            int operacaoEscolhida;
            double resultado = 0;
            List<string> historicoDeOperacoes = new List<string>();
            string salvarOperacao = "";
            bool fecharApp = false;
            string primeiroNumeroString = "";
            string segundoNumeroString = "";          

            while (fecharApp == false)
            {
                Console.WriteLine("Bem vindo a Calculadora 1.0");
                Console.WriteLine();

                /*
                 * 1 - adicao
                 * 2 - subtracao
                 * 3 - multi
                 * 4 - divisao
                 * 5 - historico
                 * qualquer outro sair
                 */

                Console.Write("Escolha uma operação: ");
                string opcaoString = Console.ReadLine();
                operacaoEscolhida = int.Parse(opcaoString);

                Console.Clear();

                if (operacaoEscolhida != 5)
                {
                    Console.Write("Digite o primeiro numero: ");
                    primeiroNumeroString = Console.ReadLine();
                    primeiroNumero = int.Parse(primeiroNumeroString);

                    Console.Write("Digite o Segundo numero: ");
                    segundoNumeroString = Console.ReadLine();
                    segundoNumero = int.Parse(segundoNumeroString);
                }
               
                switch (operacaoEscolhida)
                {
                    case 1:
                        resultado = primeiroNumero + segundoNumero;
                        salvarOperacao = primeiroNumeroString + " + " + segundoNumero + " = " + resultado.ToString();
                        break;
                    case 2:
                        salvarOperacao = primeiroNumeroString + " - " + segundoNumero + " = " + resultado.ToString();
                        break;
                    case 3:
                        resultado = primeiroNumero * segundoNumero;
                        salvarOperacao = primeiroNumeroString + " * " + segundoNumero + " = " + resultado.ToString();
                        break;
                    case 4:
                        salvarOperacao = primeiroNumeroString + " / " + segundoNumero + " = " + resultado.ToString();
                        break;
                    case 5:
                        Console.WriteLine("Historico de Operacoes.");
                        Console.WriteLine();

                        mostrarHistorico(historicoDeOperacoes);
                        break;
                }

                if(operacaoEscolhida != 5)
                {
                    Console.WriteLine();
                    Console.WriteLine("Resultado fica: {0}.", resultado);
                    historicoDeOperacoes.Add(salvarOperacao);
                    
                }

                Console.WriteLine();
                Console.Write("Aperte ENTER para continuar.");
                Console.ReadLine();
                Console.Clear();
            }

            #region Metodos.
            void mostrarHistorico(List<string> listaDeResultados)
            {
                int i = 0;
               foreach (var resultadoGravado in listaDeResultados){
                    i++;
                    Console.WriteLine("{0}. {1}", i, resultadoGravado);
                    Console.WriteLine();
               }
            }
            #endregion
        }
    }
}
