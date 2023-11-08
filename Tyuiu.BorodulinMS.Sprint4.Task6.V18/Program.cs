using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.BorodulinMS.Sprint4.Task6.V18.Lib;
namespace Tyuiu.BorodulinMS.Sprint4.Task6.V18
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            var pats = new string[] { "Собака", "Кошка", "Кролик", "Хомяк", "Попугай", "Рыбка", "Черепаха" };

            Console.WriteLine("Исходный массив:");
            for(int i=0;i<=pats.Length -1;i++)
            {
                Console.WriteLine(pats[i]);

            }




            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            pats = ds.Calculate(pats);

            for (int i = 0; i <= pats.Length - 1; i++)
            {
                Console.WriteLine( pats[i]);

            }
            Console.WriteLine();
            

           
            Console.ReadKey();
        }
    }
}
