using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOSS_Unicornio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s_pala;
            Console.Write("\n Digite seu nome: ");
            s_pala = Console.ReadLine();
            
            Console.Write("\nO primeiro caractere do seu nome é : {0}", s_pala.Substring(0, 1));
           
            char ultimo = s_pala[s_pala.Length - 1];
            Console.Write("\nO último caractere do seu nome é: {0}", ultimo);
           
            Console.Write("\nO primeiro até o terceiro caractere do seu nome é : {0}", s_pala.Substring(0, 3));

            char quartoCaractere = s_pala[3];

            Console.Write("\nO quarto caractere do seu nome é : {0}", quartoCaractere);

            string primeiro = s_pala.Substring(1);
            Console.Write("\nTodos menos o primeiro caractere : {0}", primeiro);

            string ultimos = s_pala.Substring(s_pala.Length - 2);
            Console.Write("\nOs dois ultimos caracteres são : {0}", ultimos);
            
            Console.ReadLine();
        }
    }
}
