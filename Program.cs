using System;
using System.Linq;
public static class ArrayHelper
{
    public static void ReverseArray<T>(T[] array)
    {
        if (array == null)
        {
            Console.WriteLine("Масив є null. Перевернути неможливо.");
            return;
        }
        Array.Reverse(array);
        Console.WriteLine("Масив успішно перевернуто.");
    }
    public static void DisplayArray<T>(T[] array)
    {
        if (array == null)
        {
            Console.WriteLine("Масив є null.");
            return;
        }
        Console.WriteLine("Елементи масиву: " + string.Join(", ", array));
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        Console.WriteLine("\nВведіть цілі числа для масиву, розділені пробілами (наприклад, 1 2 3 4 5):");
        string intInput = Console.ReadLine();
        try
        {
            int[] intArray = intInput.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                     .Select(int.Parse)
                                     .ToArray();
            Console.WriteLine("Оригінальний масив цілих чисел:");
            ArrayHelper.DisplayArray(intArray);
            ArrayHelper.ReverseArray(intArray);
            Console.WriteLine("Перевернутий масив цілих чисел:");
            ArrayHelper.DisplayArray(intArray);
        }
        catch (FormatException)
        {
            Console.WriteLine("Помилка: Введено некоректні цілі числа.");
        }
        Console.WriteLine();
        Console.WriteLine("Введіть рядки для масиву, розділені пробілами (наприклад, яблуко банан вишня):");
        string stringInput = Console.ReadLine();
        string[] stringArray = stringInput.Split(' ', StringSplitOptions.RemoveEmptyEntries);
        Console.WriteLine("Оригінальний масив рядків:");
        ArrayHelper.DisplayArray(stringArray);
        ArrayHelper.ReverseArray(stringArray);
        Console.WriteLine("Перевернутий масив рядків:");
        ArrayHelper.DisplayArray(stringArray);
        Console.WriteLine();
    }
} 