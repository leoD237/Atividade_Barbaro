using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Águia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Atividade 1 + trabalho com loop 
            // Ler dois número para tabuada
            Console.Write("Digite um número para ver a tabuada: ");
            int numero = int.Parse(Console.ReadLine());


            Console.WriteLine("Tabuada do numero:");
            for (int i = 1; i <= 10; i++)

            //for significa loop

            //i1 é para dar o valor de 1 e
            //i<=10 é para seguir com o loop 10 vezes
            {
                int resultado = numero * i;
                Console.WriteLine($"{numero} x {i} = {resultado}");

     
            }
                #endregion
                #region Atividade 2
                //ler numero de laudas
                Console.Write("Digite o número de folhas: ");
                
            double folha = double.Parse(Console.ReadLine());


                // Calcular o valor
                double valor = folha * 50;

                //calcular parcela 
                double parcela = valor / 3;

                // Imprimir a mensagem com o valor
                Console.WriteLine("o custo foi: R$ " + valor);
                Console.ReadLine();

                // Imprimir a mensagem com o valor
                Console.WriteLine("pagamento a parcela: R$ " + parcela);
                Console.ReadLine();
            #endregion
            #region Atividade 3
            //ler nome
            Console.Write("Digite seu nome: ");
                string nm = Console.ReadLine();
                Console.WriteLine("Seu nome é {0}", nm);
                Console.ReadLine();

                //mensagem de boas vindas 
                Console.WriteLine("Bem-vindo(a) ao programa! ");

                Console.WriteLine("Tecle ENTER para finalizar");

                // Aguarda o usuário pressionar a tecla ENTER para finalizar
                Console.ReadLine();
            #endregion
        }

    }
    }
