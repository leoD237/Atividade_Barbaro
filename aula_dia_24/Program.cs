using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividades_Cisne
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Atividade 1
            // Ler dois números inteiros
            Console.Write("Digite o primeiro número: ");
                int num1 = int.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                int num2 = int.Parse(Console.ReadLine());

                // Calcular a soma
                int soma = num1 + num2;

                // Imprimir a mensagem com o resultado da soma
                Console.WriteLine("Soma: " + soma);
                Console.ReadLine();
            #endregion
            #region Atividade 2
            //ler numero real (com virgula)
            Console.Write("Digite um número real: ");
                double numero1 = double.Parse(Console.ReadLine());

                //calcular a terça parte
                double tercaParte = numero1 / 3.0;

                // Imprimir a terça parte
                Console.WriteLine("A terça parte desse número é: " + tercaParte);
                Console.ReadLine();
            #endregion
            #region Atividade 3
            // Ler os dois números reais
            Console.Write("Digite o primeiro número real: ");
                double num3 = double.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número real: ");
                double num4 = double.Parse(Console.ReadLine());

                // Calcular a média aritmética
                double media = (num3 + num4) / 2;

                // Imprimir a mensagem com o resultado da média formatado
                Console.WriteLine("Média: " + media.ToString("F2")); // "F2" formata para duas casas decimais
                Console.ReadLine();
            #endregion
            #region Atividade 4
            // Ler o saldo da aplicação
            Console.Write("Digite o saldo da aplicação: R$ ");
                double saldo = double.Parse(Console.ReadLine());

                // Calcular o novo saldo com reajuste de 1%
                double novoSaldo = saldo * 1.01; // O saldo é multiplicado por 1.01 para aplicar um acréscimo de 1% porque 1.01 = 101%

                // Imprimir o novo saldo
                Console.WriteLine("Novo saldo: R$ " + novoSaldo.ToString("F2")); // "F2" formata para duas casas decimais
                Console.ReadLine() ;
            #endregion
            #region Atividade 5
            // Ler dois números inteiros
            Console.Write("Digite a nota da primeira prova: ");
                int NOTA_PROVA1 = int.Parse(Console.ReadLine());

                Console.Write("Digite a nota da segunda prova: ");
                int NOTA_PROVA2 = int.Parse(Console.ReadLine());

                Console.Write("Digite a nota da terceira prova: ");
                int NOTA_PROVA3 = int.Parse(Console.ReadLine());

                Console.Write("Digite a nota da quarta prova: ");
                int NOTA_PROVA4 = int.Parse(Console.ReadLine());

                // Calcular a média aritmética
                double nota = (NOTA_PROVA1 + NOTA_PROVA2 + NOTA_PROVA3 + NOTA_PROVA4) / 4;

                // Imprimir a média final
                Console.WriteLine("Média final: " + nota.ToString("F2")); // "F2" formata para duas casas decimais
                Console.ReadLine();
            #endregion


        }
    }
    }


    

