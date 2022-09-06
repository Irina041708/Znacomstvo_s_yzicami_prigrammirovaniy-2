﻿/*
Задача 64: Задайте значения M и N. Напишите программу, которая выведет все
натуральные числа в промежутке от M до N.
M = 1; N = 5. -> "1, 2, 3, 4, 5"
M = 4; N = 8. -> "4, 6, 7, 8"
*/

Console.WriteLine("Введите начальное число:");
int start = int.Parse(Console.ReadLine() ?? "");

Console.WriteLine("Введите конечное число:");
int end = int.Parse(Console.ReadLine() ?? "");

if (start < end)
{
    NumbersRec(end, start);
    void NumbersRec(int start, int end)
    {
        if (end == start + 1) return;
        {
            if (end == start) Console.Write(end);
            else Console.Write(end + ",");
        }
        NumbersRec(start, end + 1);
    }
}
else Console.Write("Ошибка вода");


/*
Console.WriteLine("Введите начальное число:");
int a = int.Parse(Console.ReadLine()??"") ;


int b = 1 ;
NumbersRec(a,b);
void NumbersRec(int b, int a)
{
    if (a == b+1) return;
    {
       if(a == b) Console.Write(a);
       else Console.Write(a + ",");
    }
    NumbersRec(b, a + 1);
}
*/