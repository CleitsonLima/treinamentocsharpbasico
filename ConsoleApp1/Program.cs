using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade;
            int dia;

            Console.WriteLine("Aula 1 - GitHub");
            Console.WriteLine("Qual a sua idade?");
            idade = int.Parse(Console.ReadLine());

            if (idade <= 15)
            {
                Console.WriteLine("GitHub Sesi");
            }
            else
            {
                Console.WriteLine("GitHub Senai");
                Console.WriteLine("Qual o melhor dia para uma aula presencial?");
                Console.WriteLine("1-Domingo\n2-Segunda\n3-Terça\n4-Quarta\n5-Quinta\n6-Sexta\n7-Sabado");
                dia = int.Parse(Console.ReadLine());
                
                switch (dia)
                {
                    case 1: Console.WriteLine("Domingo".ToUpper());break;
                    case 2: Console.WriteLine("Segunda-Feira".ToUpper());break;
                    case 3: Console.WriteLine("Terça-Feira".ToUpper());break;
                    case 4: Console.WriteLine("Quarta-Feira".ToUpper());break;
                    case 5: Console.WriteLine("Quinta-Feira".ToUpper());break;
                    case 6: Console.WriteLine("Sexta-Feira".ToUpper());break;
                    case 7: Console.WriteLine("Sabádo".ToUpper());break;
                    default: Console.WriteLine("Dado inserido fora do padrão");break;

                }
                Console.WriteLine("Qual o seu nome?");
                string nome = Console.ReadLine();
                Console.WriteLine($"tudo minusculo: {nome.ToUpper()}");
                Console.WriteLine($"Tamanho da string: {nome.Length}");
                Console.WriteLine($"tem t: {nome.Contains("t")}");
                Console.WriteLine(nome.Substring(1,nome.Length -1));
            }
            Console.ReadKey();
        }
    }
}
