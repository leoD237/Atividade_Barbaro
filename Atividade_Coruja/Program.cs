using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Coruja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Atividade 1
            // Ler número inteiro
            Console.Write("Digite um número inteiro: ");
            int num1 = int.Parse(Console.ReadLine());

            // Calcular sucessor
            int sucessor = num1 + 1;

            Console.WriteLine("O sucessor desse número é: " + sucessor);
            Console.ReadLine();

            // Calcular antecessor
            Console.Write("Digite um número inteiro: ");
            int num2 = int.Parse(Console.ReadLine());

            int antecessor = num2 - 1;

            Console.WriteLine("O antecessor desse número é: " + antecessor);
            Console.ReadLine();
            #endregion
            #region Atividade 2
            //ler nome 
            Console.Write("Digite seu nome: ");
            string nm = Console.ReadLine();

            //ler endereço 
            Console.Write("Digite seu endereço: ");
            string address = Console.ReadLine();

            //ler telefone
            Console.Write("Digite seu telefone: ");
            string ph = Console.ReadLine();

            //mostrar no visor 
            Console.WriteLine("Seu nome é {0}", nm);
            Console.WriteLine("Seu endereço é {0}", address);
            Console.WriteLine("Seu telefone é {0}", ph);
            Console.ReadLine();
            Console.Clear();
            #endregion
            #region Atividade 3
            // Ler dois números inteiros
            Console.Write("Digite um número inteiro: ");
            int numInt = int.Parse(Console.ReadLine());

            Console.Write("Digite outro número inteiro: ");
            int numInt2 = int.Parse(Console.ReadLine());

            // Calcular a soma
            int soma = numInt + numInt2;

            // Imprimir a mensagem com o resultado da soma
            Console.WriteLine("A soma é: " + soma);
            Console.ReadLine();

            //criar variavel subtraçao
            int subtracao = numInt - numInt2;

            //imprimir a subtração
            Console.WriteLine("A subtração é: " + subtracao);
            Console.ReadLine();

            //criar variavel multiplicação
            int multiplicacao = numInt * numInt2;

            //imprimir a multiplicação
            Console.WriteLine("A multiplicação é: " + multiplicacao);
            Console.ReadLine();
            #endregion
            #region Atividade 4
            //ler peso
            Console.Write("Digite seu peso: ");
            double massa = double.Parse(Console.ReadLine());

            //ler altura
            Console.Write("Digite sua altura: ");
            double height = double.Parse(Console.ReadLine());

            //calcular imc
            double imc = massa /  Math.Pow (height, 2);

            // Imprimir a mensagem com o resultado do imc
            Console.WriteLine("Seu indice de massa corporal é: " + imc);
            Console.ReadLine();
            #endregion
        }

    }
}