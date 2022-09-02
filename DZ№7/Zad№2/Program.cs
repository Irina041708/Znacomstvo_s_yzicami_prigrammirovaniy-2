/* Задача 50. Напишите программу, которая на вход принимает позиции элемента
 в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/
Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int colums = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(rows, colums, 0, 10);
PrintArray(array);
Console.WriteLine();

GetArray2(array);
Console.WriteLine();

/////////////////////////////////////////////////////////////////////////

int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

void GetArray2(int[,] inArray)
{   
    Console.Write("Введите номер строки искомого значения: ");
    int rows = int.Parse(Console.ReadLine() ?? "");
    Console.Write("Введите номер столбца искомого значения: ");
    int colums = int.Parse(Console.ReadLine() ?? "");
    if (rows <= inArray.GetUpperBound(0)+1 && colums <= inArray.GetUpperBound(1)+1)
        Console.Write($"Этот элемент = {inArray[(rows-1),(colums-1)]}");
    else
        Console.Write("Такого числа в массиве нет.");
}