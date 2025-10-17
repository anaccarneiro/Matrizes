using System;

namespace Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*07. Escreva um programa que leia dois valores m e n, corresponde ao número de linhas e colunas
            de uma matriz de inteiros. Preencha a matriz (os valores podem ser lidos do teclado ou gerados
            automaticamente). Em seguida calcule e imprima o número de linhas e o número de colunas nulas
            da matriz (todos os caracteres 0).*/

            int M = 0, N = 0;

            Console.WriteLine("Número de linhas:");
            M = int.Parse(Console.ReadLine());
            Console.WriteLine("Número de colunas:");
            N = int.Parse(Console.ReadLine());

            int[,] matriz = new int[M, N];

            Random elementos = new Random();

            for (int linhas = 0; linhas < M; linhas++)
            {
                for (int colunas = 0; colunas < N; colunas++)
                {
                    matriz[linhas, colunas] = elementos.Next(2);
                    Console.Write(matriz[linhas, colunas] + "\t");
                }
                Console.WriteLine();
            }

            bool diferenteZero = false;
            int contLinhas = 0;

            for (int linhas = 0; linhas < M; linhas++)
            {
                diferenteZero = false;

                for (int colunas = 0; colunas < N; colunas++)
                {
                    if (matriz[linhas, colunas] != 0)
                    {
                        diferenteZero = true;
                        break;
                    }
                }
                if (!diferenteZero)
                {
                    contLinhas++;
                }
            }

            int contColunas = 0;

            for (int colunas = 0; colunas < N; colunas++)
            {


                for (int linhas = 0; linhas < M; linhas++)
                {
                    if (matriz[linhas, colunas] != 0)
                    {
                        diferenteZero = true;
                        break;
                    }
                }
                if (!diferenteZero)
                {
                    contColunas++;
                }
            }
            Console.WriteLine($"Há {contLinhas} linhas nulas e {contColunas} colunas nulas!");
        }
    }
}
