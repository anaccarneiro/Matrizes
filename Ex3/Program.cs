using System;

namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*03. Desenvolva um programa que:
            ● Preencha uma matriz 10x10 (os valores podem ser lidos do teclado ou gerados
            automaticamente)
            ● Imprima a matriz gerada;
            ● Modifique os elementos que estão na diagonal principal da matriz: cada posição da diagonal
            principal deve receber a raiz quadrada do valor que consta naquela posição;
            ● Imprima a matriz modificada.*/

            int [,] matriz = new int [10, 10];
            double [,] raiz = new double [10, 10];
            Random elementos = new Random();

            for (int linha = 0; linha < 10 ; linha++)
            {
                for (int coluna = 0; coluna < 10; coluna++)
                {
                    matriz[linha, coluna] = elementos.Next(50);
                    Console.Write(matriz[linha, coluna] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n\nMatriz modificada:\n\n");

            for (int linha = 0; linha < 10; linha++)
            {
                for (int coluna = 0; coluna < 10; coluna++)
                {
                    if (linha == coluna)
                    {
                        raiz[linha, coluna] = Math.Sqrt(matriz[linha, coluna]);
                        Console.Write(raiz[linha, coluna].ToString("N2") + "\t");
                    }

                    else
                    {
                         raiz[linha, coluna] = matriz[linha, coluna];
                        Console.Write(raiz[linha, coluna] + "\t");
                    }
                    
                }
                Console.WriteLine();
            }
        }
    }
}
