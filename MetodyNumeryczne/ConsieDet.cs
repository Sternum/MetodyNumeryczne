using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodyNumeryczne
{
    public class ConsieDet
    {
        public void Det(double[,] matrix)
        {
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j].ToString() + "     ");
                    
                }
                Console.WriteLine();
            }
            double m;

            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = i + 1; j < matrix.GetLength(0); j++)
                {
                    m = matrix[j, i] / matrix[i, i];
                   
                    for(int k = 0; k < matrix.GetLength(1); k++)
                    {
                        matrix[j, k] -= m * matrix[i, k];
                    }
                }
            }
            Console.WriteLine("----------------------------------");
            for(int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j].ToString() + "    " );
                    
                }
                Console.WriteLine();
            }
        }
    }
}
