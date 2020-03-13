///<summary>
///
/// Programa criado para explorar conhecimentos de acesso a arquivo em C#
/// e como criar e imprimir uma matriz em C#
/// 
/// </summary>

using System;
using System.IO;

namespace Acesso_a_arquivo_Matriz_CSharp
{
    class Program
    {
        public static Tuple<int, int> RetornaTupla(double[,] matriz)
        {
            int linha = matriz.GetLength(0); //Pega tamanho da linha
            int coluna = matriz.GetLength(1); //Pega tamanho da coluna
            return new Tuple<int, int>(linha, coluna);
        }

        public static void ShowMatriz(double[,] matriz)
        {
            int linha = RetornaTupla(matriz).Item1;
            int coluna = RetornaTupla(matriz).Item2;

            for (int i = 0; i < linha; i++)
            {
                for (int j = 0; j < coluna; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public static double[,] CriarMatriz(double[,] matriz, string[] texto)
        {
            int linha = matriz.GetLength(0);
            int coluna = matriz.GetLength(1);

            Console.WriteLine(linha);
            Console.WriteLine(coluna);

            for (int i = 0; i < linha; i++)
            {
                string[] aux = texto[i].Split();
                for (int j = 0; j < coluna; j++)
                {
                    matriz[i, j] = double.Parse(aux[j]);
                }
            }

            return matriz;
        }
        static void Main(string[] args)
        {
            //GeraMatriz.Randomico();
            
            string[] texto = System.IO.File.ReadAllLines(@"Coloque_seu_diretório_aqui");
            //Ex: string[] texto = System.IO.File.ReadAllLines(@"C:\Users\T.I\Desktop\ResultMatriz.txt");

            int linha = texto.Length;
            //-1 porque quando eu a matriz é criada na classe "GeraMatriz" é posto um caracter vazio " " ao final de cada linha
            int coluna = texto[0].Split().Length - 1; 

            double[,] matriz = new double[linha, coluna];

            CriarMatriz(matriz, texto);

            ShowMatriz(matriz);
        }
    }
}
