/*
Задача 63: Задайте значение N. Напишите программу, которая выведет
все натуральные числа в промежутке от 1 до N.
N = 5 -> "1, 2, 3, 4, 5"
N = 6 -> "1, 2, 3, 4, 5, 6"
*/


Console.WriteLine("Введите конечное число:");
 int b = 0, a = 1;
 if (!int.TryParse(Console.ReadLine(), out b)) Console.WriteLine("Ошибка ввода!");
Console.WriteLine(NumbersRec(a,b));
string NumbersRec(int a, int b)
{
if (a == b) 
    return a.ToString();
return a + " " + NumbersRec(a + 1, b); 
}
