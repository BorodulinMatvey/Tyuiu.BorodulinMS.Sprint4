using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BorodulinMS.Sprint4.Task5.V5.Lib;
namespace Tyuiu.BorodulinMS.Sprint4.Task5.V5
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Random rnd = new Random();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int rows = 5;
            int columns = 5;
            int[,] mtrx = new int[rows, columns];
            Console.WriteLine("***************************************************************************");
            for(int i=0;i<rows;i++)
            {
                for(int j=0; j<columns;j++)
                {
                    mtrx[i, j] = rnd.Next(-5, 8);
                }
            }
            Console.WriteLine("\nМассив:");
            for(int i=0;i<rows;i++)
            {
                for(int j=0;j<columns;j++)
                {
                    Console.WriteLine($"{mtrx[i, j]} \t");
                }
                Console.WriteLine();
            }



            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            int res = ds.Calculate(mtrx);
            Console.WriteLine("Сумма всех положительных числе равнв: "+res);
            Console.ReadKey();
        }
    }
}
