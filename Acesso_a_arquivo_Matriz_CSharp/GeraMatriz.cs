using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Acesso_a_arquivo_Matriz_CSharp
{
    class GeraMatriz
    {
        
        public static void Randomico()
        {
            Console.Write("Digite a quantidade de linhas: ");
            int linha = int.Parse(Console.ReadLine());

            Console.Write("Digite a quantidade de colunas: ");
            int coluna = int.Parse(Console.ReadLine());

            Random random = new Random();

            string dir = Directory.GetCurrentDirectory();
            
            StreamWriter sw = new StreamWriter(@"Coloque_seu_diretório_aqui");
            //Ex: StreamWriter sw = new StreamWriter(@"C:\Users\T.I\Desktop\ResultMatriz.txt");
                                   
            for (int i = 0; i < linha; i++)
            {
                for(int j = 0; j < coluna; j++)
                {
                    sw.Write(random.Next(0,100).ToString() + " ");
                }
                sw.WriteLine();
            }
            
            //É necessário sempre fechar o arquivo, se não os dados não serão gravados!!
            sw.Close();

        }

    }
}
