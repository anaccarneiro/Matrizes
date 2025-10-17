using System;

namespace Ex4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*04. Faça programa que preencha uma matriz 3 x 6 com valores reais (os valores podem ser lidos
            do teclado ou gerados automaticamente)
            (a) Imprima a soma de todos os elementos das colunas pares (0, 2, 4).
            (b) Imprima a média aritmética dos elementos das colunas 3 e 5.
            (c) Substitua os valores da coluna 5 pela soma dos valores das colunas 1 e 2. Imprima a
            matriz modificada.*/

            double[,] matriz = new double[3, 6];
            Random elementos  = new Random();

            for (int linhas = 0; linhas < 3; linhas++)
            {
                for (int colunas = 0; colunas < 6; colunas++)
                {
                    matriz[linhas, colunas] = elementos.Next(10);
                    Console.Write(matriz[linhas, colunas] + "\t");
                }
                Console.WriteLine();
            }

            //Soma de todos os elementos das colunas pares (0, 2, 4).

            Console.WriteLine("\nSoma de todos os elementos das colunas pares (0, 2, 4).\n");

            for (int colunas = 0; colunas < 6; colunas += 2)
            {
                int soma = 0;

                for (int linhas = 0; linhas < 3; linhas++)
                {
                    soma += (int)matriz[linhas,colunas];
                }
                Console.WriteLine(soma);
            }

            //Média aritmética dos elementos das colunas 3 e 5.

            Console.WriteLine("\nMédia aritmética dos elementos das colunas 3 e 5.\n");

            for (int colunas = 0; colunas < matriz.GetLength(1); colunas ++)
            {
                if (colunas == 3 || colunas == 5)
                {
                    int soma = 0;
                    int cont = 0;

                    for (int linhas = 0; linhas < matriz.GetLength(0); linhas++)
                    {
                        soma += (int)matriz[linhas, colunas];
                        cont++;
                    }

                    int media = soma / cont;
                    Console.WriteLine($"{soma} / {cont} = {media}");
                }
            }

            //Substitua os valores da coluna 5 pela soma dos valores das colunas 1 e 2. Imprima a matriz modificada.

            Console.WriteLine("\nSubstituição dos valores da coluna 5 pela soma dos valores das colunas 1 e 2.\n");

            int somaUmDois = 0;

            for (int colunas = 0; colunas < matriz.GetLength(1); colunas++)
            {
                if (colunas > 0 && colunas < 3)
                {
                    for (int linhas = 0; linhas < matriz.GetLength(0); linhas++)
                    {
                        somaUmDois += (int)matriz[linhas, colunas];
                    }
                }

                if (colunas == 5)
                {
                    for (int linhas = 0; linhas < matriz.GetLength(0); linhas++)
                    {
                        matriz[linhas, colunas] = somaUmDois;
                    }
                }
            }
            Console.WriteLine("Soma da coluna 1 e 2 = " + somaUmDois + "\n");

            for (int linhas = 0; linhas < matriz.GetLength(0); linhas++)
            {
                for (int colunas = 0; colunas < matriz.GetLength(1); colunas++)
                {
                    Console.Write(matriz[linhas, colunas] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
