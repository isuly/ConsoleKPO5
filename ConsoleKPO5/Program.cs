using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleKPO5
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 0;
            int i = 0;
            //запрос размера массива
            Console.WriteLine("Enter size:");
            Int32.TryParse(Console.ReadLine(), out size);
            int[] mass = new int[size];
            int[] result = new int[size];
            //запрос ввода данных из консоли
            Console.WriteLine("Enter numbers:");
            //считывание исходного массива чисел из консоли
            while (i < size)
            {
                //tmp = Console.ReadLine()
                Int32.TryParse(Console.ReadLine(), out mass[i]);
                i++;
            }
            //вызов метода сортировки и передать тудп исходный массив
            HeapSort heapSort = new HeapSort();
            result = heapSort.Sort(mass, size);
            i = 0;
            Console.WriteLine("Sorted mass:");
            while (i < size)
            {
                Console.WriteLine(result[i].ToString());
                i++;
            }
            Console.ReadKey(true);
        }
    }
}
