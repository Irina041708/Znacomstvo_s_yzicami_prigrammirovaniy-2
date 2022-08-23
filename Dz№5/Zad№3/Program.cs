/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76 */

Console.Clear();

int[] array = GetArray(4, -12, -5); // Задаем массив 
Console.Write($"[");
Console.Write($" {String.Join(" ", array)}");
Console.WriteLine($"]");

int Max = GetMax(array);
Console.WriteLine($"Максимум в массиве равен {Max}");

int Min = GetMin(array);
Console.WriteLine($"Минимум в массиве равен {Min}");

int rezult = Result(Max,Min);
Console.WriteLine ($"Разница между максимальным и минимальным значением в массиве равна {rezult }"); 

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

// Находим  максимум в массиве.
int GetMax(int[] arr)
{
    int max = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[0] < arr[i]) max = arr[i];
    }
    return max;
}

// Находим  минимум в массиве.
int GetMin(int[] arr)
{
    int min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[0] > arr[i]) min = arr[i];
    }
    return min;
}

// Находим  разницу между максимальным и минимальным элементов массива.
int Result (int Max, int Min)
{
    int raz = Max - Min;
    return raz;

}

