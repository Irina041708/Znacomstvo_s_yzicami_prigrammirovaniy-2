/*
Задача 65: Задайте значения M и N. Напишите программу, которая
выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"
*/

Console.WriteLine("Введите начальное число:");

int b = 0, a = 0;

if (!int.TryParse(Console.ReadLine(), out a)) Console.WriteLine("Ошибка ввода!");
Console.WriteLine("Введите конечное число:");

if (!int.TryParse(Console.ReadLine(), out b)) Console.WriteLine("Ошибка ввода!");
Console.WriteLine(NumbersRec(a,b));


string NumbersRec(int a, int b)
{
if (a == b) 
    return a.ToString();
return a + " " + NumbersRec(a + 1, b); 
}
