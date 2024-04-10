// Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.

using System;
class Program
{
    static void Main()
    {
        int[] arr = {1, 2, 3, 4, 5};
        PrintArrayReversed(arr, arr.Length - 1);
    }
    static void PrintArrayReversed(int[] arr, int index)
    {
        if (index < 0)
        {
            return;
        }
        Console.WriteLine(arr[index]);
        PrintArrayReversed(arr, index - 1);
    }
}