using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_4_2
{
    //2. Заполнить массив из десяти элементов значениями, вводимыми с клавиатуры в ходе выполнения программы.

    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            int[] numbArr = new int[10];

            for (int i = 0; i < numbArr.Length; i++)
            {
                Console.WriteLine($"Введите элемент массива #{i + 1}:");
                numbArr[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("--------------------------------------------------");

            foreach (int i in numbArr)
            {
                Console.Write($"{i} ");
                //Console.WriteLine(numbArr[i]);
            }

            Console.ReadLine();
        }
    }
}
