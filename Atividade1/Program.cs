using System;

namespace Desenvolvimento_Fullstack
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2;
            int escolha;

            do
            {
                do
                {
                    Console.Write("Digite a nota do G1 do aluno:");
                    nota1 = double.Parse(Console.ReadLine());

                    if (nota1 > 10 || nota1 < 0)
                    {
                        Console.WriteLine("Nota invalida, digite uma nota entre 0 e 10\n");
                    }

                } while (nota1 > 10 || nota1 < 0);


                do
                {
                    Console.Write("Digite a nota do G2 do aluno:");
                    nota2 = double.Parse(Console.ReadLine());

                    if (nota2 > 10 || nota2 < 0)
                    {
                        Console.WriteLine("Nota invalida, digite uma nota entre 0 e 10\n");
                    }

                } while (nota2 > 10 || nota2 < 0);

                CalcularMedia(nota1, nota2);

                escolha = DesejaContinuar();


            } while (escolha == 1);
        }

        static void CalcularMedia(double nota1, double nota2)
        {
            double media = (nota1 + nota2) / 2;

            if (media < 4)
                Console.WriteLine($"Média: {media}. Aluno reprovado\n");
            else if (media < 7)
                Console.WriteLine($"Média: {media}. Aluno em exame\n");
            else
                Console.WriteLine($"Média: {media}. Aluno aprovado\n");
        }

        static int DesejaContinuar()
        {
            int escolha;
            do
            {
                Console.Write("Deseja somar outra nota? (1)SIM, (2)NÃO.");
                escolha = int.Parse(Console.ReadLine());

                if (escolha != 1 && escolha != 2)
                {
                    Console.WriteLine("Opção escolhida invalida!\n");
                }

            } while (escolha != 1 && escolha != 2);

            return escolha;
        }

    }
}
