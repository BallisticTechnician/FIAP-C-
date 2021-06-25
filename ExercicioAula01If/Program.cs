using System;

namespace ExercicioAula01If
{
    class ExercicioAula01If
    {
        static void Main(string[] args)
        {
            double comissao;
            Console.WriteLine("Entre com o salario fixo :");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Entre com o valor de vendas deste mês : ");
            double vendas = double.Parse(Console.ReadLine());
            if (vendas>1500.00)
            { comissao = (vendas-1500) * 0.1 +75;
            }
            else { comissao = vendas * 0.05; }
            Console.WriteLine($"Seu salario total é de R$ {comissao+salario}");
        }
    }
}
