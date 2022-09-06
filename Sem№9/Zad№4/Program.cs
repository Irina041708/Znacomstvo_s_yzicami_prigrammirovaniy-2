/*
Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
*/

int Number = 0, Power = 0;
Console.Write("Введите число: ");
if (!int.TryParse(Console.ReadLine(), out Number)) Console.WriteLine("Ошибка ввода!");

Console.Write("Введите степень числа: ");
if (!int.TryParse(Console.ReadLine(), out Power)) Console.WriteLine("Ошибка ввода!");
Console.Write(PowerRec(Number,Power));

double PowerRec(int Number, int Power)
{
    if (Power == 1) return Number;

    return PowerRec(Number, Power - 1 )* Number;
}