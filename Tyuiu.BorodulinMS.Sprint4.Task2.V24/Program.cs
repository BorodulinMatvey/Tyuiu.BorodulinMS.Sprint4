using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BorodulinMS.Sprint4.Task2.V24.Lib;
namespace Tyuiu.BorodulinMS.Sprint4.Task2.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int len = 12;

            int[] numsArray = new int[len];

            for (int i=0; i<=len-1;i++)
            {
                numsArray[i] = rnd.Next(4, 10);
            }

            Console.WriteLine("Массив:");
            for(int i=0;i<=len-1;i++)
            {
                Console.WriteLine(numsArray[i] + "\t");
            }


            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сумма не четных элементов массива равна:" + ds.Calculate(numsArray));



            Console.ReadKey();
        }
    }
}
