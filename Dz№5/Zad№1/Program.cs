/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2  */
Console.Clear();

int[] array = GetArray(10, 100, 1000); // Задаем массив из 5 элементов
Console.Write($"[");
Console.Write($" {String.Join(" ", array)}");
Console.WriteLine($"]");

int countcount = GetColHcetChisel(array);
Console.WriteLine ($"Количество чётных чисел в массиве равно {countcount}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];// Создаем в памяти массив целых чисел с размером size
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}

// Находим  количество чётных чисел в массиве

int GetColHcetChisel(int[] arr)
{
    int count = 0;
    foreach (int el in arr)
    {
        
        if (el % 2 == 0) count++;
        
    }
    return count;
 
}


