﻿using System;

namespace Fiap.Aula01.Exemplo01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ler uma string
            //cw -> tab tab
            Console.WriteLine("Digite o nome");
            string nome = Console.ReadLine();

            //Ler um numero (lê uma string e converte para um numero inteiro)
            Console.WriteLine("Digite a idade");
            int idade = int.Parse(Console.ReadLine());

            //Exibir um dado

       
            Console.WriteLine($"O nome digitado é {nome} e a idade é {idade} ");
        }
    }
}