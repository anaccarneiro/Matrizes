using System;

namespace Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*06. Elabore um programa que leia uma matriz 4 x 4 e indique se é uma matriz triangular superior.
            Matriz triangular superior é uma matriz onde todos os elementos abaixo da diagonal principal
            são iguais a zero.*/

            int[,] matriz = new int[4, 4];

            Console.WriteLine("Preencha a matriz:");
            for (int linhas = 0; linhas < matriz.GetLength(0); linhas++)
            {
                for (int colunas = 0; colunas < matriz.GetLength(1); colunas++)
                {
                    Console.WriteLine($"Linha {linhas}, Coluna {colunas}");
                    matriz[linhas, colunas] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine();

            for (int linhas = 0; linhas < matriz.GetLength(0); linhas++)
            {
                for (int colunas = 0; colunas < matriz.GetLength(1); colunas++)
                {
                    Console.Write(matriz[linhas, colunas] + "\t");
                }
                Console.WriteLine();
            }

            bool zeroColuna1 = true;
            bool zeroColuna2 = true;
            bool zeroColuna3 = true;

            for (int linhas = 1; linhas < matriz.GetLength(0); linhas++)
            {
                for (int colunas = 0; colunas < 1; colunas++)
                {
                    if (matriz[linhas, colunas] != 0)
                    {
                        zeroColuna1 = false;
                        break;
                    }
                }
            }

            for (int linhas = 2; linhas < matriz.GetLength(0); linhas++)
            {
                for (int colunas = 0; colunas < 2; colunas++)
                {
                    if (matriz[linhas, colunas] != 0)
                    {
                        zeroColuna2 = false;
                        break;
                    }
                }
            }

            for (int linhas = 3; linhas < matriz.GetLength(0); linhas++)
            {
                for (int colunas = 0; colunas < 3; colunas++)
                {
                    if (matriz[linhas, colunas] != 0)
                    {
                        zeroColuna3 = false;
                        break;
                    }
                }
            }

            if (zeroColuna1 && zeroColuna2 && zeroColuna3)
                Console.WriteLine("\nÉ uma matriz triângular superior");
            else
                Console.WriteLine("\nNão é uma matriz triângular superior");
        }
    }
}
