using System;

namespace ExemploWhile
{
    class ExemploWhile
    {
        static void Main(string[] args)
        {

            int opcao;
            double alunosA = 0;
            double alunosB = 0;
            double notaTA = 0;
            double notaTB = 0;
            double mediaA = 0;
            double mediaB = 0;
            double mediacurso;
            double notaA;
            double notaB;
            do
            {
                Console.WriteLine("\n\n---------------------\n\nEscolha uma das opções abaixo :");
                Console.WriteLine("1 - Inserir a quantidade de alunos da turma A e B");
                Console.WriteLine("2 - Inserir as notas dos alunos da turma A e B");
                Console.WriteLine("3 - Exibir as médias das turmas e do  curso geral");
                Console.WriteLine("4 - Comparar as médias dos alunos");
                Console.WriteLine("5 - Sair\n\n------------------------\n");
                opcao = int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Entre com a quantidade de alunos na turma A : ");
                        alunosA = double.Parse(Console.ReadLine());
                        Console.WriteLine("Entre com a quantidade de alunos na turma B : ");
                        alunosB = double.Parse(Console.ReadLine());
                        break;

                    case 2:
                        for (int i = 0; i < alunosA; i++)
                        {
                            Console.WriteLine($"Entre com a nota do aluno (Turma A) {i + 1}");
                            notaA = double.Parse(Console.ReadLine());
                            notaTA = notaA + notaTA;
                        }
                        for (int i = 0; i < alunosB; i++)
                        {
                            Console.WriteLine($"Entre com a nota do aluno (Turma B) {i + 1}");
                            notaB = double.Parse(Console.ReadLine());
                            notaTB = notaB + notaTB;
                        }
                        break;
                    case 3:
                        mediaA = notaTA / alunosA;
                        mediaB = notaTB / alunosB;
                        mediacurso = (mediaA+mediaB) / 2;
                        Console.WriteLine($"Média da sala A = {mediaA}");
                        Console.WriteLine($"Média da sala B = {mediaB}");
                        Console.WriteLine($"Média do curso = {mediacurso}");
                        break;
                    case 4:
                        if ((mediaA) > (mediaB))
                        { Console.WriteLine($"A média da turma A é maior que a turma B"); }
                        else if ((mediaB) > (mediaA))
                        { Console.WriteLine($"A média da turma B é maior que a turma A"); }
                        else
                        { Console.WriteLine($"As médias são iguais"); }
                        break;
                    case 5:
                        Console.WriteLine("Obrigado por usar nosso programa");
                        break;
                    default:
                        { Console.WriteLine("Entrada incorreta"); }
                        break;
                }
            } while (opcao != 5);
           
        }
      
    }
}
