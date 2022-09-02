/*Задача 55: Задайте двумерный массив. 
Напишите программу, которая заменяет строки на столбцы. 
В случае, если это невозможно, 
программа должна вывести сообщение для пользователя.*/


Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int colums = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(rows, colums, 0, 10);
PrintArray(array);
Console.WriteLine();


int[,] array2 = GetArray2(array);
PrintArray2(array);
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


int[,] GetArray2(int[,] inarray)
{
    int box;
    for (int j = 0; j < inarray.GetLength(1); j++)
    {
        for (int i = 0; i < inarray.GetLength(0); i++)
        {

            box = inarray[i, j];
            inarray[i, j] += inarray.GetLength(0);
            inarray[i, j] = box;
        }
    }
    return inarray;
}

void PrintArray2(int[,] inArray)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}