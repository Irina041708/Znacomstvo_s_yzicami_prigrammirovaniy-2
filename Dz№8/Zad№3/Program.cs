/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить 
произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int colums = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(rows, colums, 0, 10);
PrintArray(array);
Console.WriteLine();

int[,] array2 = GetArray2(rows, colums, 0, 10);
PrintArray(array2);
Console.WriteLine();

Multiplication(array, array2);



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

int[,] GetArray2(int m, int n, int minValue, int maxValue)
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



void Multiplication(int[,] inArray, int[,] inArray2)
{
    if (inArray2.GetLength(0) == inArray.GetLength(1))
    {
        int[,] multiplicationArray = new int[inArray.GetLength(0), inArray2.GetLength(1)];
        int size = inArray.GetLength(1);
        for (int i = 0; i < inArray.GetLength(0); i++)
        {
            for (int j = 0; j < inArray.GetLength(1); j++)
            {
                for (int k = 0; k < size; k++)
                {
                    multiplicationArray[i, j] += inArray[i, k] * inArray2[k, j];
                }
            }
            Console.WriteLine();
        }
       PrintArray(multiplicationArray);
    }
    else
        Console.WriteLine("Ошибка ввода. Размер матриц должен совпадать");

}


