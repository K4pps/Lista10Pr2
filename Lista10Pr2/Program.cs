using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Lista8PR2
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao;

            do
            {
                Console.WriteLine("----MENU----");
                Console.WriteLine("Para sair 0");
                Console.WriteLine("Exec 1");
                Console.WriteLine("Exec 2");
                Console.WriteLine("Exec 3");
                Console.WriteLine("Exec 4");
                Console.WriteLine("Exec 5");
                Console.WriteLine("-------------");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        Exercicio1();
                        break;
                    case 2:
                        Exercicio2();
                        break;
                    case 3:
                        Exercicio3();
                        break;
                    case 4:
                        Exercicio4();
                        break;
                    case 5:
                        Exercicio5();
                        break;
                    case 0:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida! Tente novamente.");
                        break;
                }

                Console.WriteLine();
            } while (opcao != 0);
        }

        static void Exercicio1()
        {
            Console.Write("Digite o tamanho do vetor: ");
            int tamanho = int.Parse(Console.ReadLine());

            float[] vetor = new float[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                Console.Write($"Digite o número {i + 1}: ");
                vetor[i] = float.Parse(Console.ReadLine());
            }

            float menor = vetor[0];
            float maior = vetor[0];
            float soma = vetor[0];

            for (int i = 1; i < tamanho; i++)
            {
                if (vetor[i] < menor)
                    menor = vetor[i];

                if (vetor[i] > maior)
                    maior = vetor[i];

                soma += vetor[i];
            }

            float media = soma / tamanho;

            Console.WriteLine($"Menor número: {menor}");

            Console.WriteLine($"Maior número: {maior}");

            Console.WriteLine($"Média: {media}");
        }

        static void Exercicio2()
        {
            Console.Write("Digite o tamanho do vetor: ");
            int tamanho = int.Parse(Console.ReadLine());

            float[] vetor = new float[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                Console.Write($"Digite o número {i + 1}: ");

                vetor[i] = float.Parse(Console.ReadLine());
            }

            float soma = 0;

            for (int i = 0; i < tamanho; i++)
            {
                soma += vetor[i];
            }

            float media = soma / tamanho;

            Console.WriteLine("Números maiores ou iguais à média:");

            for (int i = 0; i < tamanho; i++)
            {
                if (vetor[i] >= media)
                    Console.WriteLine(vetor[i]);
            }
        }

        static void Exercicio3()
        {
            Random random = new Random();

            Console.Write("Digite o tamanho do vetor: ");
            int tamanho = int.Parse(Console.ReadLine());

            float[] vetor = new float[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                vetor[i] = (float)random.NextDouble() * 100;
            }

            Console.WriteLine("Vetor gerado:");

            for (int i = 0; i < tamanho; i++)
            {
                Console.WriteLine(vetor[i]);
            }
        }

        static void Exercicio4()
        {
            Console.Write("Digite a quantidade de nomes que deseja inserir: ");
            int quantidade = int.Parse(Console.ReadLine());

            List<string> assinaturas = new List<string>();

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write($"Digite o nome {i + 1}: ");
                string nome = Console.ReadLine();
                assinaturas.Add(nome);
            }

            Console.WriteLine("Nomes inseridos (do último para o primeiro):");

            for (int i = quantidade - 1; i >= 0; i--)
            {
                Console.WriteLine(assinaturas[i]);
            }
        }

        static void Exercicio5()
        {
            Console.Write("Digite o tamanho do vetor: ");
            int tamanho = int.Parse(Console.ReadLine());

            int[] vetor = new int[tamanho];
            Random random = new Random();

            int pares = 0;
            int impares = 0;

            for (int i = 0; i < tamanho; i++)
            {
                vetor[i] = random.Next(1, 101);

                if (vetor[i] % 2 == 0)
                    pares++;
                else
                    impares++;
            }

            Console.WriteLine($"Quantidade de números pares: {pares}");
            Console.WriteLine($"Quantidade de números ímpares: {impares}");
        }
    }
}

