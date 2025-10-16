using System;

namespace Ex1
    {
        internal class Program
        {
            static void Main(string[] args)
            {
            /*01. Considere uma matriz de n x n elementos, onde n será informado pelo usuário. Preencha a
            matriz (os valores podem ser lidos do teclado ou gerados automaticamente). Calcule e imprima:
            a) A soma de cada linha;
            b) A soma de cada coluna;
            c) A soma dos elementos da diagonal principal da matriz;
            d) A soma dos elementos da diagonal secundária.*/

                int N;
                Console.WriteLine("Informe o número de elementos: ");
                N = int.Parse(Console.ReadLine());
                Random elementos = new Random();

                int[,] matriz = new int[N, N];
                for (int linha = 0; linha < N; linha++)
                {
                    for (int coluna = 0; coluna < N; coluna++)
                    {
                        matriz[linha, coluna] = elementos.Next(50);
                        Console.Write(matriz[linha, coluna] + "\t");
                    }
                    Console.WriteLine();
                }

                for (int linha = 0; linha < N; linha++)
                {
                    int soma = 0;

                    for (int coluna = 0; coluna < N; coluna++)
                    {
                        // soma das linhas
                        soma += matriz[linha, coluna];
                    }
                    Console.WriteLine($"Soma da linha {linha}: {soma}");
                }

                Console.WriteLine();

                for (int coluna = 0; coluna < N; coluna++)
                {
                    int somaColuna = 0;

                    for (int linha = 0; linha < N; linha++)
                    {
                        // soma das colunas
                        somaColuna += matriz[linha, coluna];
                    }
                    Console.WriteLine($"Soma da coluna {coluna}: {somaColuna}");
                }

                int somaDiagonal = 0;

                for (int linha = 0; linha < N; linha++)
                {

                    for (int coluna = 0; coluna < N; coluna++)
                    {
                        // soma da diagonal
                        if (linha == coluna)
                        {
                            somaDiagonal += matriz[linha, coluna];
                        }
                    }
                }
                Console.WriteLine($"\n\nSoma da diagonal: {somaDiagonal}");

                somaDiagonal = 0;


                for (int coluna = N - 1, linha = 0; coluna >= 0; linha++, coluna--)
                {

                    // soma da diagonal secundária
                    somaDiagonal += matriz[linha, coluna];

                }
                Console.WriteLine($"\n\nSoma da diagonal secundária: {somaDiagonal}\n\n");
            }
        }
    }

    
