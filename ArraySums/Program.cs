using System;
using System.Globalization;
namespace ArraySums
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Altura: ");
            string alt = Console.ReadLine();
            Console.Write("Largura: ");
            string larg = Console.ReadLine();

            int altura = int.Parse(alt); //troca ambas avariáveis de string para float
            int largura = int.Parse(larg);

            float [,] tabela = new float [altura ,largura ]; //cria uma tabela tipo float com alturas e larguras dadas pelo utilizador

            for (int i = 0; i < tabela.GetLength(0); i++) //corre por linha
            {
                for (int j = 0; j < tabela.GetLength(1); j++) //corre por coluna
                {
                    Console.Write($"linha {i}, coluna {j}. Insira um número: ");
                    string result = Console.ReadLine();
                    float resultado = float.Parse(result, CultureInfo.InvariantCulture.NumberFormat ); //O uso do "CultureInfo.InvariantCulture.NumberFormat" vem ajudar o Parse a perceber o que é um ponto
                    tabela[i,j] = resultado;
                }
                Console.WriteLine("");
            }

            for (int i = 0; i < tabela.GetLength(0); i++) //corre por linha
            {
                float conta = 0f;
                Console.Write($"A soma da {i + 1}ª linha é:");
                for ( int j = 0; j < tabela.GetLength(1); j++) //corre por coluna
                {
                    conta += tabela[i , j]; //adiciona todos os números de uma linha
                }
                Console.WriteLine(conta);
            }

            for (int j = 0; j < tabela.GetLength(1); j++) //corre por coluna
            {
                float conta = 0f;
                Console.Write($"A soma da {j + 1}ª coluna é:");
                for (int i = 0; i < tabela.GetLength(0); i++) //corre por linha
                {
                    conta += tabela[i , j]; //adiciona todos os números de uma coluna
                }
                Console.WriteLine(conta);
            }


        }
    }
}
