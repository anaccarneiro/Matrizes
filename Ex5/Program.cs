using System;
using System.Xml.Linq;

namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[10, 10];
            Random elementos = new Random();

            for (int linhas = 0; linhas < matriz.GetLength(0); linhas++)
            {
                for (int colunas = 0; colunas < matriz.GetLength(1); colunas++) 
                {
                    matriz[linhas, colunas] = elementos.Next(2);
                    Console.Write(matriz[linhas, colunas] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
