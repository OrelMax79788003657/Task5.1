using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            
            Console.Write("Введите семь элементов массива: \t ");
            int elementsCount = int.Parse(Console.ReadLine());
            int[]myArray = new int[elementsCount];  
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"Введите элемент массива под индексом {i}:\t");
                myArray[i] = int.Parse(Console.ReadLine());
            }
            int avg, Sum ;
            avg=0;
            Sum=0;
           
                for (int i = 0; i< elementsCount; i++)
            {
                Sum += myArray [i];
                avg= Sum/ myArray.Length;
            }
                Console.Write(" Среднее арифметическое равно = {0} ", avg);
 
            
            Console.ReadKey();


        }
    }
}
