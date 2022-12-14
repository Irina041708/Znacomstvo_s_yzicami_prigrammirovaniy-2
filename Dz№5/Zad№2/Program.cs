/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0 */

Console.Clear();

int[] array = GetArray(4, -6, 2); // Задаем массив 
Console.Write($"[");
Console.Write($" {String.Join(" ", array)}");
Console.WriteLine($"]");

int sum2 = GetSumHcetChisel(array);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях, равна {sum2}");

//Возвращает массив из size элементов,
//заполненный случайными числами из промежутка [minValue, maxValue].

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue);
    }
    return res;
}

// Находим  cумму элементов, стоящих на нечётных позициях.
int GetSumHcetChisel(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i++)
    {
        if (i % 2 != 0) sum += arr[i];
    }
    return sum;
}
