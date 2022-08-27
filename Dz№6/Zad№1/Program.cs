/* Задача 41: Пользователь вводит с клавиатуры M чисел. 
Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/

Console.Clear();

Console.Write("Введите количество цифр в массиве, которые вы хотели бы ввести: ");
int rows = int.Parse(Console.ReadLine() ?? "");

int[] array = GetArray(rows, -600, 600);
Console.Write("Получился массив значений: [");
PrintArray(array);
Console.Write("]");

int countcount = ModArray(array);
Console.WriteLine();
Console.Write($"Количество положительных чисел, которые Вы ввели равно {countcount}");



int[] GetArray(int m, int minValue, int maxValue)
{
    int[] result = new int[m];
    for (int i = 0; i < m; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        result[i] = Convert.ToInt32(Console.ReadLine());
    }

    return result;
}

void PrintArray(int[] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        Console.Write($"{inArray[i]} ");

    }
  
}

int ModArray(int[] inArray)
{
    int count = 0;
    int[] result = new int[count];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
       
        if (inArray[i] > 0) count++;
                    
    }
    return count;
}





