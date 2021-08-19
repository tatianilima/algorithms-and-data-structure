using System;
using System.Collections.Generic;
using System.Linq;
//https://www.hackerrank.com/work/library/hackerrank?copyscrape=true&difficulties=Medium&question=321536&recommended_time=26%2C45&type=backend%2Ccoding&view=question
namespace products_defected
{
    class Program
    {
        static void Main(string[] args)
        {
            int samplesRows = Convert.ToInt32(Console.ReadLine().Trim());
            int samplesColumns = Convert.ToInt32(Console.ReadLine().Trim());

            List<List<int>> samples = new List<List<int>>();

            for (int i = 0; i < samplesRows; i++)
            {
                samples.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(samplesTemp => Convert.ToInt32(samplesTemp)).ToList());
            }

            int result = Result.largestArea(samples);

            Console.WriteLine(result);

        }
    }

    class Result
    {
        public static int largestArea(List<List<int>> samples)
        {
            //converter a list para uma matriz
            int[][] matrix = samples.Select(s => s.ToArray()).ToArray(); //Ponto de atenção

            //clonar essa matriz
            int[][] newMatrix = new int[matrix.Length][];
            Array.Copy(matrix, newMatrix, matrix.Length);

            int result = 0;
            for (int r = 0; r < matrix.Length; r++) //passa em cada linha
            {
                var row = matrix[r]; //linha i
                for (int c = 0; c < row.Length; c++) //array que passa na coluna c
                {
                    if (r > 0 && c > 0 && matrix[r][c] > 0)
                    {
                        newMatrix[r][c] = 1 + Math.Min(newMatrix[r][c-1],
                                                      Math.Min(newMatrix[r-1][c],
                                                      newMatrix[r-1][c-1]
                                                     ));
                    }
                    if (newMatrix[r][c] > result)
                    {
                        result = newMatrix[r][c];
                    }
                }
            }
            
           
            //se for forneca no minimo 3 numeros ao seu redor - o que está no topo, o que está a esquerda, 
            // e o que esta na superior diagonal esquerda

            return result;
        }
    }
}
