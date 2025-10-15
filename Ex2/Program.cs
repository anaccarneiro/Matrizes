using System;

namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*02. Elabore um programa que preencha duas matrizes de n x m elementos, onde n e m serão
            informados pelo usuário. Preencha as duas matrizes (os valores podem ser lidos do teclado ou
            gerados automaticamente). Em seguida, o programa deve verificar e imprimir se as duas matrizes
            são iguais, isto é, possuem os mesmos valores em cada posição.*/

            int N, M;
            Console.WriteLine("Digite o número de linhas (N):");
            N = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o número de colunas (M):");
            M = int.Parse(Console.ReadLine());

            int[,] matrizN = new int[N, M];
            int[,] matrizM = new int[N, M];
            Random elementos = new Random();

            Console.WriteLine("\n" + "Matriz N");

            for (int linha = 0; linha < N; linha++)
            {
                for (int coluna = 0; coluna < M; coluna++)
                {
                    matrizN[linha, coluna] = elementos.Next(0, 10);
                    Console.Write(matrizN[linha, coluna] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n" + "Matriz M");

            for (int linha = 0; linha < N; linha++)
            {
                for (int coluna = 0; coluna < M; coluna++)
                {
                    matrizM[linha, coluna] = elementos.Next(0, 10);
                    Console.Write(matrizM[linha, coluna] + "\t");
                }
                Console.WriteLine();
            }

            bool diferentes = false;

            for (int linha = 0; linha < N; linha++)
            {
                for (int coluna = 0; coluna < M; coluna++)
                {
                    if (matrizN[linha, coluna] != matrizM[linha, coluna])
                    {
                        diferentes = true;
                        break;
                    }
                }
            }
            if (diferentes)
            {
                Console.WriteLine("\n" + "As matrizes são diferentes.");
            }

            else if (!diferentes)
            {
                Console.WriteLine("\n" + "As matrizes são iguais.");
            }
        }
    }
}
