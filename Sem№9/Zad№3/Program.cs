/*
Задача 67: Напишите программу, которая будет принимать на вход число и
возвращать сумму его цифр.
453 -> 12
45 -> 9

*/

int Number = 0;
Console.Write("Введите число: ");
if (!int.TryParse(Console.ReadLine(), out Number)) Console.WriteLine("Ошибка ввода!");
Console.WriteLine(SummaRec(Number));

int SummaRec(int a)
{
    if (a==0) 
        return 0;
    
    return a % 10 + SummaRec(a/10);
}