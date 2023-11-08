using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BorodulinMS.Sprint4.Task4.V22.Lib;
namespace Tyuiu.BorodulinMS.Sprint4.Task4.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int rows = 5;
            int columns = 5;
            int[,] mtrx = new int[rows, columns];

            Console.WriteLine("***************************************************************************");

            for (int i=0;i<rows;i++)
            {
                for(int j=0;j<columns;j++)
                {
                    Console.WriteLine($"Введите {i},{j} элементы массива значениями от 2 до 6:");
                    mtrx[i, j] = Convert.ToInt32(Console.ReadLine());
                    
                }
            }
            Console.WriteLine("\nМассив:");
            
                for(int i =0;i<rows;i++)
                {
                    for(int j=0;j<columns;j++)
                    {
                        Console.WriteLine($"{mtrx[i, j]} \t");
                    }
                Console.WriteLine();
                }
            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            mtrx = ds.Calculate(mtrx);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.WriteLine(mtrx[i,j]+"\t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
