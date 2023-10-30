using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BorodulinMS.Sprint4.Task0.V1.Lib;
namespace Tyuiu.BorodulinMS.Sprint4.Task0.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            int g;
            DataService ds = new DataService();

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int[] numsArray = { 6, 4, 3, 2, 1, 0, 9, 8, 7, 5 };

            Console.WriteLine("Исходный массив: " );
            for(int i = 0; i <=numsArray.Length -1; i++)
            {
                Console.WriteLine(numsArray[i]);
            }    
           


            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Сумма четных элементов массива равна:" + ds.GetSumEvenArrEl(numsArray));
            

          
            Console.ReadKey();
        }
    }
}
