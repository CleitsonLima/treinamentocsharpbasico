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

            /* Tipos de Dados
             * Inteiro - int
             * Real - double
             * Texto - string
             */

            /* Operadores Aritmeticos
             * +  -adicao
             * -  -subtracao
             * *  -multiplicacao
             * /  -divisao
             * %  -modulo(resto da divisao)
             */

            string comando;
            string resposta="git remote add origin";

            Console.WriteLine("Qual comando para adicionar o repositorio remoto");

            comando = Console.ReadLine();

            string[] subcomando = comando.Split(' ');

            foreach (var item in subcomando)
            {
                Console.WriteLine(item);
            }

            if(subcomando.Length == 2)
            {
                if(subcomando[0].Equals("git") && subcomando[1].Equals("remote")) 
                {
                    Console.WriteLine("acertou 50%");
                }
            }
            else if(subcomando.Length == 4)
            {
                if (subcomando[0].Equals("git") && subcomando[1].Equals("remote") && subcomando[2].Equals("add") && subcomando[3].Equals("origin"))
                {
                    Console.WriteLine("acertou 100%");
                }
            }
            else
            {
                Console.WriteLine("Resposta errada");
            }

            Console.WriteLine($"A resposta é {resposta}");
            
            /*
            Console.WriteLine("Alô Mundo!");
            Console.ReadKey();
            */


            Console.ReadKey();
        }//fim do metodo;
    }//fim da classe;
}//fim do namespace;
