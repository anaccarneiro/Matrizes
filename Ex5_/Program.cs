using System;

namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*05. Escreva um programa que preencha com números inteiros uma matriz com 500 linhas e 500
            colunas (os valores podem ser lidos do teclado ou gerados automaticamente). Em seguida,
            verifique e imprima se a matriz é um quadrado mágico.
            Dizemos que uma matriz é um quadrado mágico se a soma dos elementos de cada linha, a soma
            dos elementos de cada coluna e a soma dos elementos das diagonais principal e secundária são
            todas iguais.*/

            int[,] matriz = new int[10, 10];
            Random elementos = new Random();

            for (int linhas = 0; linhas < matriz.GetLength(0); linhas++)
            {
                for (int colunas = 0; colunas < matriz.GetLength(1); colunas++)
                {
                    matriz[linhas, colunas] = elementos.Next(10);
                    Console.Write(matriz[linhas, colunas] + "\t");
                }
                Console.WriteLine();
            }

            int somaRef = 0;
            for (int colunas = 0; colunas < matriz.GetLength(1); colunas++)
                somaRef += matriz[0, colunas];
            Console.WriteLine($"\nSoma de referência = {somaRef}\n");

            //Soma dos elementos de cada linha
            Console.WriteLine("\nSoma dos elementos de cada linha\n");

            int[] somaLinhas = new int[10];
            int[] somaColunas = new int[10];
            bool linhasIguais = true;
            bool colunasIguais = true;


            for (int linhas = 0; linhas < matriz.GetLength(0); linhas++)
            {
                for (int colunas = 0; colunas < matriz.GetLength(1); colunas++)
                {
                    somaLinhas[linhas] += matriz[linhas, colunas];
                }
                Console.WriteLine($"Soma da linha {linhas} = {somaLinhas[linhas]}");

                if (somaLinhas[linhas] != somaRef)
                {
                    linhasIguais = false;
                    break;
                }
            }

            //Soma dos elementos de cada coluna
            Console.WriteLine("\nSoma dos elementos de cada coluna\n");

            for (int colunas = 0; colunas < matriz.GetLength(1); colunas++)
            {
                for (int linhas = 0; linhas < matriz.GetLength(0); linhas++)
                {
                    somaColunas[colunas] += matriz[linhas, colunas];
                }
                Console.WriteLine($"Soma da coluna {colunas} = {somaColunas[colunas]}");

                if (somaColunas[colunas] != somaRef)
                {
                    colunasIguais = false;
                    break;
                }
            }

            //Soma dos elementos das diagonal principal

            int somaDiagonal = 0;

            for (int linhas = 0; linhas < matriz.GetLength(0); linhas++)
            {
                for (int colunas = 0; colunas < matriz.GetLength(1); colunas++)
                {
                    if (linhas == colunas)
                    {
                        somaDiagonal += matriz[linhas, colunas];
                    }
                }
            }
            Console.WriteLine($"\nSoma da diagonal principal = {somaDiagonal}");

            //Soma dos elementos das diagonal principal

            int somaDiagSecundaria = 0;

            for (int linhas = 0, colunas = 10 - 1; linhas < matriz.GetLength(0); linhas++, colunas--)
            {
                somaDiagSecundaria += matriz[linhas, colunas];
            }
            Console.WriteLine($"\nSoma da diagonal secundária = {somaDiagSecundaria}\n");

            if (linhasIguais && colunasIguais && somaDiagSecundaria == somaRef && somaDiagonal == somaRef)
                Console.WriteLine("É um quadrado mágico!");
            else
                Console.WriteLine("Não é um quadrado mágico.");
        }
    }
}

