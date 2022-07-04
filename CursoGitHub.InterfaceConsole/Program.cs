using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoGitHub.InterfaceConsole
{//inicio do namespace;

    internal class Program
    {//inicio da classe;
        static void Main(string[] args)
        {//inicio do metodo;

            /*
             * Main - Principal
             * o método inicia-se com a letra maiscula
             * 
             */
            //Variavel
            /*
             * e um espaco reservado na memoria do computador
            */

            string pergunta;
            string resposta="git init";

            Console.WriteLine("Qual comando para iniciar o Git");
            pergunta = Console.ReadLine();
            if (pergunta.Equals(resposta))
            {
                Console.WriteLine("Acertou");
            }
            else 
            {
                Console.WriteLine("Errou");
            }
            Console.WriteLine($"A resposta é {resposta}");

            /*
            Console.WriteLine("Alô Mundo!");
            Console.ReadKey();
            */



        }//fim do metodo;
    }//fim da classe;
}//fim do namespace;
