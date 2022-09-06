/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.WriteLine("Введите начальное число:");
int start = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Введите конечное число:");
int end = int.Parse(Console.ReadLine() ?? "");

if (start < end)
{
    int sum = 0;
    NumbersRec(end, start, sum);
    void NumbersRec(int start, int end, int sum)
    {
        if (start < end)
        {
            Console.Write(sum);
            return;
        }
        sum = sum + (end++);
        NumbersRec(start, end, sum);
    }
}

else Console.Write("Ошибка ввода");
